using ExtendableImageManager.DB;
using ExtendableImageManager.DB.ImplFake;
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
        private IDbForImage _db;

        public MainForm MainForm
        {
            get
            {
                return _mainForm;
            }
        }

        public IDbForImage Db
        {
            get
            {
                return _db;
            }
        }

        public MainControl()
        {
            _mainForm = new MainForm(this);
            _db = new FakeImageDbSimulator();
        }

        public void Init(string baseFolder)
        {
            _db.Init(baseFolder);
        }

        public void Uninit()
        {
            _db.Uninit();
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
