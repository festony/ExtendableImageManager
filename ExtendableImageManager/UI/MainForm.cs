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

        public MainForm(MainControl mainControl)
        {
            InitializeComponent();
            _mainControl = mainControl;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainControl.Uninit();
        }
    }
}
