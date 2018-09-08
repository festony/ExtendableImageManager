using ExtendableImageManager.Core;
using ExtendableImageManager.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExtendableImageManager.Crawler.BasicImpl
{
    public class SimpleCrawler : ICrawler
    {
        private static int DEFAULT_TIMEOUT = 60000;
        private static int MAX_RETRY_TIME = 10;

        private MainControl _mainControl;
        private int _timeout;
        // TODO: move webClient here - then also need Uninit to close the client.

        public int Timeout
        {
            get
            {
                return _timeout;
            }
            set
            {
                _timeout = value;
            }
        }

        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;
            _timeout = DEFAULT_TIMEOUT;
        }

        public string FetchHtml(string url)
        {
            // TODO: maybe change this to exception throw
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
            }
            string data = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = _timeout;
            request.UserAgent = @"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                for (int i = 0; i < MAX_RETRY_TIME; i++)
                {
                    try
                    {
                        data = readStream.ReadToEnd();
                        break;
                    }
                    catch (Exception e)
                    {
                        Trace.WriteLine("Failed to retrieve html data from url [" + url + "]: " + e);
                    }
                    Thread.Sleep(1000);
                }

                response.Close();
                readStream.Close();
            }

            return data;
        }

        public string FetchFile(string url)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
            }
            using (WebClient webClient = new WebDownload(_timeout))
            {
                try
                {
                    //webClient.DownloadFile(imageUrl, filepath);
                    webClient.Headers.Add("user-agent", @"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36");
                    var bytes = webClient.DownloadData(url);
                    var totalBytes = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
                    if (bytes.Length < totalBytes)
                    {
                        throw new Exception("Download incompleted - received only " + bytes.Length + " bytes but expecting " + totalBytes + "bytes.");
                    }
                    var contentType = webClient.ResponseHeaders["Content-Type"];
                    if (contentType == null)
                    {
                        throw new Exception("Got NULL content type");
                    }
                    var postfix = RandomFileNameUtils.GetFilePostfixFromContentType(contentType);
                    var tempFilePath = _mainControl.FileStorage.GetTempFilePath(postfix);
                    using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                    }
                    return tempFilePath;
                }
                catch (Exception e)
                {
                    Trace.WriteLine(string.Format("Exception {0} while downloading {1}", e, url));
                    return null;
                }
            }
            //var tempFilePath = _mainControl.FileStorage.GetTempFilePath("?");
        }
    }
}
