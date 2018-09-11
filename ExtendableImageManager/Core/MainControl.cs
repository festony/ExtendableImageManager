using ExtendableImageManager.Crawler;
using ExtendableImageManager.Crawler.BasicImpl;
using ExtendableImageManager.Fetcher;
using ExtendableImageManager.Fetcher.SkkImpl;
using ExtendableImageManager.FileStorage;
using ExtendableImageManager.FileStorage.HierarchyImpl;
using ExtendableImageManager.Persistence;
using ExtendableImageManager.Persistence.ImplFake;
using ExtendableImageManager.Persistence.Model;
using ExtendableImageManager.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendableImageManager.Core
{
    public class MainControl
    {
        private static int RETRY_INTERVAL_PAGE = 3500;
        private static int RETRY_INTERVAL_INDEX = 500;

        private string _baseFolder;
        private MainForm _mainForm;
        private TestForm _testForm;
        private FetcherForm _fetcherForm;
        private TagManagementForm _tagManagementForm;
        private ViewerForm _viewerForm;
        private IPersistenceForImage _persistence;
        private IFileStorage _fileStorage;
        private ICrawler _crawler;
        private Dictionary<string, IFetcher> _fetcherDict;
        private int _retryIntervalPage;
        private int _retryIntervalIndex;

        public string BaseFolder
        {
            get
            {
                return _baseFolder;
            }
        }

        public MainForm MainForm
        {
            get
            {
                return _mainForm;
            }
        }

        public TestForm TestForm
        {
            get
            {
                return _testForm;
            }
        }

        public FetcherForm FetcherForm
        {
            get
            {
                return _fetcherForm;
            }
        }

        public TagManagementForm TagManagementForm
        {
            get
            {
                return _tagManagementForm;
            }
        }

        public ViewerForm ViewerForm
        {
            get
            {
                return _viewerForm;
            }
        }

        public IPersistenceForImage Persistence
        {
            get
            {
                return _persistence;
            }
        }

        public IFileStorage FileStorage
        {
            get
            {
                return _fileStorage;
            }
        }

        public ICrawler Crawler
        {
            get
            {
                return _crawler;
            }
        }

        public Dictionary<string, IFetcher> FetcherDict
        {
            get
            {
                return _fetcherDict;
            }
        }

        public int RetryIntervalPage
        {
            get
            {
                return _retryIntervalPage;
            }
        }

        public int RetryIntervalIndex
        {
            get
            {
                return _retryIntervalIndex;
            }
        }

        public MainControl()
        {
            _mainForm = new MainForm();
            _mainForm.Init(this);
            _testForm = new TestForm();
            _testForm.Init(this);
            _fetcherForm = new FetcherForm();
            _tagManagementForm = new TagManagementForm();
            _tagManagementForm.Init(this);
            _viewerForm = new ViewerForm();
            _viewerForm.Init(this);
            _persistence = new FakePersistenceSimulator();
            _fileStorage = new HierarchyFileStorage();
            _crawler = new SimpleCrawler();

            _fetcherDict = new Dictionary<string, IFetcher>();
            _fetcherDict["skk"] = new SkkFetcher();
            _fetcherDict["skk"].Init(this);

            _retryIntervalPage = RETRY_INTERVAL_PAGE;
            _retryIntervalIndex = RETRY_INTERVAL_INDEX;
        }

        public void Init(string baseFolder)
        {
            _baseFolder = baseFolder;
            //_mainForm.Init(this);
            //_testForm.Init(this);
            _fetcherForm.Init(this);
            //_tagManagementForm.Init(this);
            //_viewerForm.Init(this);
            _persistence.Init(this);
            _fileStorage.Init(this);
            _crawler.Init(this);

            // TODO: remove testing code
            //temp();
        }

        void temp()
        {
            List<ImageItem> images = _persistence.GetImages(null);
            var c0 = 0;
            var c1 = 0;
            var c2 = 0;
            var c3 = 0;
            var c4 = 0;
            images.ForEach(i =>
            {
                c0++;
                if (i.visited)
                {
                    c1++;
                }
                if (i.liked)
                {
                    c2++;
                }
                if (i.disliked)
                {
                    c3++;
                }
                if (i.fetched)
                {
                    c4++;
                }
            });
            Trace.WriteLine("-------- c0 " + c0);
            Trace.WriteLine("-------- c1 " + c1);
            Trace.WriteLine("-------- c2 " + c2);
            Trace.WriteLine("-------- c3 " + c3);
            Trace.WriteLine("-------- c4 " + c4);

            //images.ForEach(i =>
            //{
            //    i.fetched = true;
            //});
        }

        public void Uninit()
        {
            _persistence.Uninit();
            _fetcherForm.Uninit();
            _baseFolder = null;
        }

        /// <summary>
        /// Run application by starting main form.
        /// </summary>
        public void Run()
        {
            Application.Run(_mainForm);
        }
    }
}
