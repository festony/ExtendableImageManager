﻿using ExtendableImageManager.Crawler;
using ExtendableImageManager.Crawler.BasicImpl;
using ExtendableImageManager.Fetcher;
using ExtendableImageManager.Fetcher.SkkImpl;
using ExtendableImageManager.FileStorage;
using ExtendableImageManager.FileStorage.HierarchyImpl;
using ExtendableImageManager.Persistence;
using ExtendableImageManager.Persistence.ImplFake;
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
        private string _baseFolder;
        private MainForm _mainForm;
        private TestForm _testForm;
        private IPersistenceForImage _persistence;
        private IFileStorage _fileStorage;
        private ICrawler _crawler;
        private Dictionary<string, IFetcher> _fetcherDict;

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

        public MainControl()
        {
            _mainForm = new MainForm();
            _mainForm.Init(this);
            _testForm = new TestForm();
            _testForm.Init(this);
            _persistence = new FakePersistenceSimulator();
            _fileStorage = new HierarchyFileStorage();
            _crawler = new SimpleCrawler();

            _fetcherDict = new Dictionary<string, IFetcher>();
            _fetcherDict["skk"] = new SkkFetcher();
            _fetcherDict["skk"].Init(this);
        }

        public void Init(string baseFolder)
        {
            _baseFolder = baseFolder;
            //_mainForm.Init(this);
            //_testForm.Init(this);
            _persistence.Init(this);
            _fileStorage.Init(this);
            _crawler.Init(this);
        }

        public void Uninit()
        {
            _persistence.Uninit();
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
