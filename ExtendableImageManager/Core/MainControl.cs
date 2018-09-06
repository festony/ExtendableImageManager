using ExtendableImageManager.Crawler;
using ExtendableImageManager.Crawler.BasicImpl;
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
        private IPersistenceForImage _persistence;
        private IFileStorage _fileStorage;
        private ICrawler _crawler;

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

        public MainControl()
        {
            _mainForm = new MainForm();
            _mainForm.Init(this);
            _persistence = new FakePersistenceSimulator();
            _fileStorage = new HierarchyFileStorage();
            _crawler = new SimpleCrawler();
        }

        public void Init(string baseFolder)
        {
            _baseFolder = baseFolder;
            _mainForm.Init(this);
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
