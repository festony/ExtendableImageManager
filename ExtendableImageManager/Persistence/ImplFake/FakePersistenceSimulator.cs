using ExtendableImageManager.Persistence.Model;
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
        //private static string ARTISTS_DATA_FILE_NAME = "artistsData";
        private static string TAGS_DATA_FILE_NAME = "tagsData";
        private static string IGNORED_TAGS_DATA_FILE_NAME = "ignoredTagsData";

        private string _baseFolder;
        private string _imageItemsDataFilePath;
        //private string _artistsDataFilePath;
        private string _tagsDataFilePath;
        private string _ignoredTagsDataFilePath;

        private bool _initialized;

        private Dictionary<string, ImageItem> _imageItems;
        //private Dictionary<string, TagItem> _artists;
        private Dictionary<string, TagItem> _tags;
        private Dictionary<string, TagItem> _ignoredTags;

        public FakePersistenceSimulator()
        {
            _initialized = false;

            _imageItems = new Dictionary<string, ImageItem>();
            //_artists = new Dictionary<string, TagItem>();
            _tags = new Dictionary<string, TagItem>();
            _ignoredTags = new Dictionary<string, TagItem>();
        }

        public void Init(string baseFolder)
        {
            if (_initialized)
            {
                Uninit();
            }

            _baseFolder = baseFolder;
            Directory.CreateDirectory(_baseFolder);

            _imageItemsDataFilePath = Path.Combine(_baseFolder, IMAGE_DATA_FILE_NAME);
            //_artistsDataFilePath = Path.Combine(_baseFolder, ARTISTS_DATA_FILE_NAME);
            _tagsDataFilePath = Path.Combine(_baseFolder, TAGS_DATA_FILE_NAME);
            _ignoredTagsDataFilePath = Path.Combine(_baseFolder, IGNORED_TAGS_DATA_FILE_NAME);

            var initMatrix = new Dictionary<string, object>
            {
                { _imageItemsDataFilePath, null },
                //{ _artistsDataFilePath, null },
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

            _initialized = true;
        }

        public void Uninit()
        {
            if (!_initialized)
            {
                return;
            }
            _initialized = false;

            var uninitMatrix = new Dictionary<string, object>
            {
                { _imageItemsDataFilePath, _imageItems },
                //{ _artistsDataFilePath, _artists },
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
            //_artists.Clear();
            _imageItems.Clear();
        }

        private TagItem addTagIfNotExist(string tagName, string tagType)
        {
            // TODO: maybe change this to exception throw
            if (!_initialized)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
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
            if (!_initialized)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return false;
            }
            if (_imageItems.ContainsKey(filename))
            {
                return false;
            }

            var image = new ImageItem();
            image.fileName = filename;
            image.url = url;
            image.tags = tags.Select(pair => addTagIfNotExist(pair.Key, pair.Value)).ToList();
            image.created = DateTime.Now;

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
            if (!_initialized)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
            }
            // TODO: implement this
            return null;
        }

        public void IgnoreTag(string tag)
        {
            if (!_initialized)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return;
            }
            if (_tags.ContainsKey(tag))
            {
                _ignoredTags[tag] = _tags[tag];
            }
        }

        public void UnignoreTag(string tag)
        {
            if (!_initialized)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return;
            }
            if (_ignoredTags.ContainsKey(tag))
            {
                _ignoredTags.Remove(tag);
            }
        }
    }
}
