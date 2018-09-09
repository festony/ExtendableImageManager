using ExtendableImageManager.Core;
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
    public partial class FetcherForm : Form
    {
        private MainControl _mainControl;
        private List<string> _pageUrls;
        private List<string> _fetchedPageUrls;

        public FetcherForm()
        {
            InitializeComponent();
            _pageUrls = new List<string>();
            _fetchedPageUrls = new List<string>();
        }

        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;
            comboBoxFetcher.Items.AddRange(_mainControl.FetcherDict.Keys.ToArray());
        }

        public void Uninit()
        {
            _mainControl = null;
            comboBoxFetcher.Items.Clear();
        }

        private void FetcherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxFetcher.Text))
            {
                MessageBox.Show("select fetcher");
                return;
            }
            var morePageUrls = _mainControl.FetcherDict[comboBoxFetcher.Text].ExtractPageUrls(textBoxUrls.Lines.ToList());
            _pageUrls.AddRange(morePageUrls);
            textBoxTotal.Text = _pageUrls.Count.ToString();
            textBoxNotFetched.Text = (_pageUrls.Count - _fetchedPageUrls.Count).ToString();
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxFetcher.Text))
            {
                MessageBox.Show("select fetcher");
                return;
            }
            var i = 0;
            foreach(var url in _pageUrls)
            {
                if (!_fetchedPageUrls.Contains(url))
                {
                    Trace.WriteLine("----- fetching " + i + "-th url " + url);
                    _mainControl.FetcherDict[comboBoxFetcher.Text].Fetch(url);
                    _fetchedPageUrls.Add(url);
                    i++;
                    if (i > numericUpDownFetchBatchSize.Value)
                    {
                        break;
                    }
                }
            }
            MessageBox.Show("fetching done");
        }
    }
}
