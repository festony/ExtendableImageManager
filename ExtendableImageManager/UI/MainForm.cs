using ExtendableImageManager.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
