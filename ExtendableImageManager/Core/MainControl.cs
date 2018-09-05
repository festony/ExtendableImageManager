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
        private MainForm _mainForm;
        private IPersistenceForImage _persistence;

        public MainForm MainForm
        {
            get
            {
                return _mainForm;
            }
        }

        public IPersistenceForImage Db
        {
            get
            {
                return _persistence;
            }
        }

        public MainControl()
        {
            _mainForm = new MainForm(this);
            _persistence = new FakePersistenceSimulator();
        }

        public void Init(string baseFolder)
        {
            _persistence.Init(baseFolder);
        }

        public void Uninit()
        {
            _persistence.Uninit();
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
