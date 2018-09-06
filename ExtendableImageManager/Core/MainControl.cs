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

        public MainControl()
        {
            _mainForm = new MainForm(this);
            _persistence = new FakePersistenceSimulator();
            _fileStorage = new HierarchyFileStorage();
        }

        public void Init(string baseFolder)
        {
            _baseFolder = baseFolder;
            _persistence.Init(_baseFolder);
            _fileStorage.Init(_baseFolder);
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
