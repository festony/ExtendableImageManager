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
    public partial class TagManagementForm : Form
    {
        private MainControl _mainControl;

        public TagManagementForm()
        {
            InitializeComponent();
        }
        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;
        }

        private void updateData()
        {
            List<string> allTags = _mainControl.Persistence.AllTags.Values.Select(t => t.tagName + "|" + t.tagType).ToList();
            List<string> allIgnoredTags = _mainControl.Persistence.AllIgnoredTags.Values.Select(t => t.tagName + "|" + t.tagType).ToList();

            string term = textBoxFilter.Text;
            if (!string.IsNullOrWhiteSpace(term))
            {
                term = term.ToLower();
                allTags = allTags.Where(t => t.ToLower().Contains(term)).ToList();
                allIgnoredTags = allIgnoredTags.Where(t => t.ToLower().Contains(term)).ToList();
            }

            listBoxValidTags.Items.Clear();
            listBoxValidTags.Items.AddRange(allTags.Except(allIgnoredTags).ToArray());

            listBoxIgnoredTags.Items.Clear();
            listBoxIgnoredTags.Items.AddRange(allIgnoredTags.ToArray());
        }

        private void addLeftSelectionToIgnoreTags()
        {
            List<string> toBeIgnored = new List<string>(listBoxValidTags.SelectedItems.Cast<string>()).Select(t => t.Substring(0, t.LastIndexOf('|'))).ToList();

            toBeIgnored.ForEach(t => _mainControl.Persistence.IgnoreTag(t));
            updateData();
        }

        private void removeRightSelectionFromIgnoreTags()
        {
            List<string> toBeUnignored = new List<string>(listBoxIgnoredTags.SelectedItems.Cast<string>()).Select(t => t.Substring(0, t.LastIndexOf('|'))).ToList();

            toBeUnignored.ForEach(t => _mainControl.Persistence.UnignoreTag(t));
            updateData();
        }

        private void TagManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void TagManagementForm_Shown(object sender, EventArgs e)
        {
            updateData();
        }

        private void buttonLeftToRight_Click(object sender, EventArgs e)
        {
            addLeftSelectionToIgnoreTags();
        }

        private void buttonRightToLeft_Click(object sender, EventArgs e)
        {
            removeRightSelectionFromIgnoreTags();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
