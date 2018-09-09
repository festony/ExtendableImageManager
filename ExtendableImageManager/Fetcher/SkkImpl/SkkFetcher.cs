using ExtendableImageManager.Core;
using ExtendableImageManager.Persistence.Model;
using ExtendableImageManager.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ExtendableImageManager.Fetcher.SkkImpl
{
    public class SkkFetcher : IFetcher
    {
        private MainControl _mainControl;

        public SkkFetcher() { }

        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;
        }

        private Dictionary<string, string> extractTags(string html)
        {
            var result = new Dictionary<string, string>();
            var tagsContent = StringAnalysisUtil.GetSubString(html, "<ul id=tag-sidebar>", "</ul>");
            while (tagsContent.Contains("<li class=tag-type-"))
            {
                var liContent = StringAnalysisUtil.GetSubString(tagsContent, "<li class=tag-type-", "</li>");
                var tagType = liContent.Substring(0, liContent.IndexOf('>'));
                var innerA = StringAnalysisUtil.GetSubString(liContent, "<a href=", "</a>");
                var tagName = innerA.Substring(innerA.IndexOf('>') + 1);
                //var tag = new TagItem();
                //tag.tagName = tagName;
                //tag.tagType = tagType;
                //result.Add(tag);
                result[tagName] = tagType;
                //Trace.WriteLine("------- post c tag [" + tagName + "] [" + tagType + "]");

                tagsContent = tagsContent.Substring(tagsContent.IndexOf("</li>") + 5);
                //Trace.WriteLine("------- post c tagsc "+ tagsContent.Length);
            }
            return result;
        }

        private void fetchPost(string url)
        {
            // url should be ...skk../post/show/[postId]
            var html = _mainControl.Crawler.FetchHtml(url/* + "?" + Stopwatch.GetTimestamp().ToString()*/);

            var content = StringAnalysisUtil.GetSubString(html, "<div id=post-content>", "</p>");

            var contentUrl = "";
            if (content.Contains("<video id=image"))
            {
                // post - video
                contentUrl = StringAnalysisUtil.GetSubString(content, "src=\"", "\"");
            }
            else if (content.Contains("<a id=image-link"))
            {
                // post - image
                content = StringAnalysisUtil.GetSubString(content, "<a id=image-link", "</a>");
                if (content.Contains("href="))
                {
                    // post - image resized
                    contentUrl = StringAnalysisUtil.GetSubString(content, "href=\"", "\"");
                }
                else
                {
                    // post - image original directly
                    contentUrl = StringAnalysisUtil.GetSubString(content, "src=\"", "\"");
                }
            }
            else
            {
                Trace.WriteLine("Error: unable to proceed post url [" + url + "]");
                return;
            }

            contentUrl = WebUtility.HtmlDecode(contentUrl);
            //Trace.WriteLine("------- post c url " + contentUrl);
            if (!contentUrl.Contains("https"))
            {
                contentUrl = "https:" + contentUrl;
            }
            var tempFilePath = _mainControl.Crawler.FetchFile(contentUrl);
            //Trace.WriteLine("------- post c path " + tempFilePath);
            var fileName = _mainControl.FileStorage.PutFile(tempFilePath);

            //var img = new ImageItem();
            //img.fileName = fileName;
            //img.pageUrl = url;
            //img.tags = extractTags(html);

            _mainControl.Persistence.AddImage(fileName, url, extractTags(html));
        }

        private HashSet<string> fetchIndex(string url)
        {
            Uri uriAddress = new Uri(url);
            var host = uriAddress.GetLeftPart(UriPartial.Authority);
            var html = _mainControl.Crawler.FetchHtml(url/* + "&" + Stopwatch.GetTimestamp().ToString()*/);
            //Trace.WriteLine("------- post c\n" + html);
            var content = StringAnalysisUtil.GetSubString(html, "<div class=content>", "<iframe ");
            var postIds = new HashSet<string>();
            var subContent = content;
            while (subContent.Contains("<a href=\"/post/show/"))
            {
                var postId = StringAnalysisUtil.GetSubString(subContent, "<a href=\"/post/show/", "\"");
                postIds.Add(postId);
                subContent = subContent.Substring(subContent.IndexOf("<a href=\"/post/show/") + "<a href=\"/post/show/".Length);
            }

            while (content.Contains("<div next-page-url=\""))
            {
                var nextPageUrl = StringAnalysisUtil.GetSubString(content, "<div next-page-url=\"", "\"");
                nextPageUrl = WebUtility.HtmlDecode(nextPageUrl);
                nextPageUrl = host + "/post" + nextPageUrl;
                //Trace.WriteLine("------- post nxt\n" + nextPageUrl);
                Thread.Sleep(400);
                content = _mainControl.Crawler.FetchHtml(nextPageUrl);
                subContent = content;
                while (subContent.Contains("<a href=\"/post/show/"))
                {
                    var postId = StringAnalysisUtil.GetSubString(subContent, "<a href=\"/post/show/", "\"");
                    postIds.Add(postId);
                    subContent = subContent.Substring(subContent.IndexOf("<a href=\"/post/show/") + "<a href=\"/post/show/".Length);
                }
            }
            var postUrls = new HashSet<string>();
            //Trace.WriteLine("------- post ids");
            foreach (var i in postIds)
            {
                //Trace.WriteLine("------- post id " + i);
                postUrls.Add(host + "/post/show/" + i);
            }
            return postUrls;
        }

        //private void FetchFromUrl(string url)
        //{
        //    // TODO: maybe change this to exception throw
        //    if (_mainControl == null)
        //    {
        //        Trace.WriteLine("Error: function called before initialize.");
        //        return;
        //    }
        //    // TODO: implement this
        //    Regex postUrlRegex = new Regex(@"http.*\/post\/show\/[0-9]*");
        //    if (postUrlRegex.Match(url).Success)
        //    {
        //        fetchPost(url);
        //    }
        //    else
        //    {
        //        fetchIndex(url);
        //    }
        //}

        public List<string> ExtractPageUrls(List<string> urls)
        {
            // TODO: maybe change this to exception throw
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
            }
            // TODO: implement this
            var postUrls = new HashSet<string>();
            Regex postUrlRegex = new Regex(@"http.*\/post\/show\/[0-9]*");

            foreach(var url in urls)
            {
                if (postUrlRegex.Match(url).Success)
                {
                    //fetchPost(url);
                    postUrls.Add(url);
                }
                else
                {
                    Thread.Sleep(300);
                    var moreUrls = fetchIndex(url);
                    postUrls.UnionWith(moreUrls);
                }
            }

            foreach (var img in _mainControl.Persistence.GetImages(null))
            {
                if (postUrls.Contains(img.pageUrl))
                {
                    postUrls.Remove(img.pageUrl);
                }
            }

            Trace.WriteLine("Skk Fetcher: " + postUrls.Count + " posts in total.");

            return postUrls.ToList();
        }

        public void Fetch(string pageUrl)
        {
            fetchPost(pageUrl);
        }
    }
}
