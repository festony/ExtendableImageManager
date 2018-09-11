﻿using ExtendableImageManager.Core;
using ExtendableImageManager.Persistence.Model;
using ExtendableImageManager.UserException;
using ExtendableImageManager.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Persistence.ImplFake
{
    class FakePersistenceSimulator : IPersistenceForImage
    {
        private static string IMAGE_DATA_FILE_NAME = "imageData";
        private static string TAGS_DATA_FILE_NAME = "tagsData";
        private static string IGNORED_TAGS_DATA_FILE_NAME = "ignoredTagsData";

        private MainControl _mainControl;
        private string _baseFolder;
        private string _imageItemsDataFilePath;
        private string _tagsDataFilePath;
        private string _ignoredTagsDataFilePath;

        private Dictionary<string, ImageItem> _imageItems;
        private Dictionary<string, TagItem> _tags;
        private Dictionary<string, TagItem> _ignoredTags;

        public FakePersistenceSimulator()
        {
            _imageItems = new Dictionary<string, ImageItem>();
            _tags = new Dictionary<string, TagItem>();
            _ignoredTags = new Dictionary<string, TagItem>();
        }

        public void Init(MainControl mainControl)
        {
            if (_mainControl != null)
            {
                Uninit();
            }
            _baseFolder = mainControl.BaseFolder;
            Directory.CreateDirectory(_baseFolder);

            _imageItemsDataFilePath = Path.Combine(_baseFolder, IMAGE_DATA_FILE_NAME);
            _tagsDataFilePath = Path.Combine(_baseFolder, TAGS_DATA_FILE_NAME);
            _ignoredTagsDataFilePath = Path.Combine(_baseFolder, IGNORED_TAGS_DATA_FILE_NAME);

            var initMatrix = new Dictionary<string, object>
            {
                { _imageItemsDataFilePath, null },
                { _tagsDataFilePath, null },
                { _ignoredTagsDataFilePath, null }
            };

            BinaryFormatter formatter = new BinaryFormatter();

            var keyList = initMatrix.Keys.ToList();
            foreach (var p in keyList)
            {
                if (File.Exists(p))
                {
                    using (var fs = new FileStream(p, FileMode.Open))
                    {
                        try
                        {
                            initMatrix[p] = formatter.Deserialize(fs);
                        }
                        catch (SerializationException e)
                        {
                            Trace.WriteLine("Failed to deserialize " + p + ". Reason: " + e.Message);
                        }
                    }
                }
            }

            if (initMatrix[_imageItemsDataFilePath] != null)
            {
                _imageItems = (Dictionary<string, ImageItem>)initMatrix[_imageItemsDataFilePath];
            }
            if (initMatrix[_tagsDataFilePath] != null)
            {
                _tags = (Dictionary<string, TagItem>)initMatrix[_tagsDataFilePath];
            }
            if (initMatrix[_ignoredTagsDataFilePath] != null)
            {
                _ignoredTags = (Dictionary<string, TagItem>)initMatrix[_ignoredTagsDataFilePath];
            }

            _mainControl = mainControl;
        }

        public void Uninit()
        {
            if (_mainControl == null)
            {
                return;
            }
            _mainControl = null;

            var uninitMatrix = new Dictionary<string, object>
            {
                { _imageItemsDataFilePath, _imageItems },
                { _tagsDataFilePath, _tags },
                { _ignoredTagsDataFilePath, _ignoredTags }
            };

            BinaryFormatter formatter = new BinaryFormatter();
            var dateTimePostfix = "." + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            foreach (var p in uninitMatrix.Keys)
            {
                if (File.Exists(p))
                {
                    File.Move(p, p + dateTimePostfix);
                }

                using (var fs = new FileStream(p, FileMode.Create))
                {
                    try
                    {
                        formatter.Serialize(fs, uninitMatrix[p]);
                    }
                    catch (SerializationException e)
                    {
                        Trace.WriteLine("Failed to serialize " + p + ". Reason: " + e.Message);
                    }
                }
            }
            
            _ignoredTags.Clear();
            _tags.Clear();
            _imageItems.Clear();
        }

        private TagItem addTagIfNotExist(string tagName, string tagType)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            TagItem tag;
            if (_tags.ContainsKey(tagName))
            {
                tag = _tags[tagName];
            }
            else
            {
                tag = new TagItem();
                tag.tagName = tagName;
                tag.tagType = tagType;
                _tags.Add(tagName, tag);
            }

            return tag;
        }

        public bool AddImage(string filename, string url, Dictionary<string, string> tags)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            if (_imageItems.ContainsKey(filename))
            {
                return false;
            }

            var image = new ImageItem();
            image.fileName = filename;
            image.pageUrl = url;
            image.tags = tags.Select(pair => addTagIfNotExist(pair.Key, pair.Value)).ToList();
            image.created = DateTime.Now;
            image.fetched = true;

            _imageItems[filename] = image;

            return true;
        }

        public Dictionary<string, TagItem> AllTags
        {
            get
            {
                return _tags;
            }
        }

        public List<ImageItem> GetImages(FileFilter filter)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            // TODO: implement this
            if (filter == null)
            {
                // return all images;
                return _imageItems.Values.ToList();
            }
            return null;
        }

        public void IgnoreTag(string tag)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            if (_tags.ContainsKey(tag))
            {
                _ignoredTags[tag] = _tags[tag];
            }
        }

        public void UnignoreTag(string tag)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            if (_ignoredTags.ContainsKey(tag))
            {
                _ignoredTags.Remove(tag);
            }
        }

        public Dictionary<string, TagItem> AllIgnoredTags
        {
            get
            {
                return _ignoredTags;
            }
        }
    }
}
