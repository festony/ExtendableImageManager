using ExtendableImageManager.Core;
using ExtendableImageManager.UserException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendableImageManager.UI
{
    public partial class MainForm : Form
    {
        private MainControl _mainControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_mainControl != null)
            {
                _mainControl.Uninit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainControl.Uninit();
            _mainControl.Init(textBox1.Text);
        }

        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _mainControl.Uninit();
            _mainControl.Init(textBoxBaseFolder.Text);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            _mainControl.TestForm.Show();
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            _mainControl.FetcherForm.Show();
        }

        private void buttonTag_Click(object sender, EventArgs e)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            _mainControl.TagManagementForm.Show();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            _mainControl.ViewerForm.Show();
        }
    }
}
