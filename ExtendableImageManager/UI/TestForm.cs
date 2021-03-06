﻿using ExtendableImageManager.Core;
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
    public partial class TestForm : Form
    {
        private MainControl _mainControl;

        public TestForm()
        {
            InitializeComponent();
        }

        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            //_mainControl.FetcherDict["skk"].Fetch(textBoxUrl.Text);
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            Trace.WriteLine("----- image data");
            
        }
    }
}
