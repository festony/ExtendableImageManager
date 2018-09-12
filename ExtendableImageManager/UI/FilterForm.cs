using ExtendableImageManager.Core;
using ExtendableImageManager.Persistence;
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
    public partial class FilterForm : Form
    {
        class OptionSet
        {
            public RadioButton selected;
            public Label label;
            public CheckBox activated;
            public ListBox tags;
        }

        private MainControl _mainControl;
        private List<OptionSet> _optionSets;
        private int _currOptionSetIndex;
        private bool _inSettingRadioButton = false;
        private List<string> _allTagsList;
        private List<string> _allArtistsList;
        private FileFilter _fileFilter;

        public FilterForm()
        {
            InitializeComponent();

            _optionSets = new List<OptionSet>();

            var optionSet0 = new OptionSet();
            optionSet0.selected = radioButtonAndSet0;
            optionSet0.label = labelAndSet0;
            optionSet0.activated = checkBoxAndSet0;
            optionSet0.tags = listBoxAndSet0;
            _optionSets.Add(optionSet0);

            var optionSet1 = new OptionSet();
            optionSet1.selected = radioButtonAndSet1;
            optionSet1.label = labelAndSet1;
            optionSet1.activated = checkBoxAndSet1;
            optionSet1.tags = listBoxAndSet1;
            _optionSets.Add(optionSet1);

            var optionSet2 = new OptionSet();
            optionSet2.selected = radioButtonAndSet2;
            optionSet2.label = labelAndSet2;
            optionSet2.activated = checkBoxAndSet2;
            optionSet2.tags = listBoxAndSet2;
            _optionSets.Add(optionSet2);

            var optionSet3 = new OptionSet();
            optionSet3.selected = radioButtonAndSet3;
            optionSet3.label = labelAndSet3;
            optionSet3.activated = checkBoxAndSet3;
            optionSet3.tags = listBoxAndSet3;
            _optionSets.Add(optionSet3);

            var optionSet4 = new OptionSet();
            optionSet4.selected = radioButtonAndSet4;
            optionSet4.label = labelAndSet4;
            optionSet4.activated = checkBoxAndSet4;
            optionSet4.tags = listBoxAndSet4;
            _optionSets.Add(optionSet4);

            var optionSet5 = new OptionSet();
            optionSet5.selected = radioButtonAndSet5;
            optionSet5.label = labelAndSet5;
            optionSet5.activated = checkBoxAndSet5;
            optionSet5.tags = listBoxAndSet5;
            _optionSets.Add(optionSet5);

            var optionSet6 = new OptionSet();
            optionSet6.selected = radioButtonNotSet;
            optionSet6.label = labelNotSet;
            optionSet6.activated = checkBoxNotSet;
            optionSet6.tags = listBoxNotSet;
            _optionSets.Add(optionSet6);

            for (int i = 0; i < 7; i++)
            {
                _optionSets[i].selected.Checked = (i == 0);
            }
            _currOptionSetIndex = 0;

            foreach (var ops in _optionSets)
            {
                ops.selected.CheckedChanged += radioButtonSelect_CheckedChanged;
                ops.tags.GotFocus += listBox_GotFocus;
            }

            _fileFilter = new FileFilter();
        }

        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;

            var tags = _mainControl.Persistence.AllTags.Values.Except(_mainControl.Persistence.AllIgnoredTags.Values).ToList();

            _allTagsList = tags.Select(t => t.tagName).ToList();
            _allArtistsList = tags.Where(t => t.tagType == "artist").Select(t => t.tagName).ToList();

            listBoxTags.Items.AddRange(_allArtistsList.ToArray());
        }

        private void FilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void radioButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (!_inSettingRadioButton)
            {
                _inSettingRadioButton = true;
                var button = sender as RadioButton;
                for (int i = 0; i < 7; i++)
                {
                    if (_optionSets[i].selected == button)
                    {
                        _currOptionSetIndex = i;
                        _optionSets[i].selected.Checked = true;
                    }
                    else
                    {
                        _optionSets[i].selected.Checked = false;
                    }
                }
                _inSettingRadioButton = false;
            }
        }

        private void listBox_GotFocus(object sender, EventArgs e)
        {
            var box = sender as ListBox;
            foreach (var ops in _optionSets)
            {
                if (ops.tags == box)
                {
                    ops.selected.Checked = true;
                    break;
                }
            }
        }

        private void FilterForm_Shown(object sender, EventArgs e)
        {
            if (_mainControl != null)
            {
                //listBoxTags.Items.AddRange(_allArtistsList.ToArray());
            }
        }

        private void generateFilterOptions()
        {
            var criteria = new HashSet<HashSet<string>>();
            foreach (var ops in _optionSets)
            {
                if (ops.activated.Checked)
                {
                    criteria.Add(new HashSet<string>(ops.tags.Items.Cast<string>()));
                }
            }
            _fileFilter.AndOrCriteria = criteria;
            _fileFilter.IncludeVisited = checkBoxVisited.Checked;
            _fileFilter.IncludeNotVisited = checkBoxNotVisited.Checked;
            _fileFilter.IncludeLiked = checkBoxLiked.Checked;
            _fileFilter.IncludeNotLiked = checkBoxNotLiked.Checked;
            _fileFilter.IncludeDisliked = checkBoxDisliked.Checked;
            _fileFilter.IncludeNotDisliked = checkBoxNotDisliked.Checked;
            _fileFilter.DoShuffle = checkBoxShuffle.Checked;
        }

        private void doTagFiltering()
        {
            var list = new List<string>();
            if (checkBoxArtistOnly.Checked)
            {
                list.AddRange(_allArtistsList);
            }
            else
            {
                list.AddRange(_allTagsList);
            }

            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                string searchTerm = textBoxSearch.Text.Trim();
                list = list.Where(t => t.Contains(searchTerm)).ToList();
            }

            listBoxTags.Items.Clear();
            listBoxTags.Items.AddRange(list.ToArray());
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            doTagFiltering();
        }

        private void checkBoxArtistOnly_CheckedChanged(object sender, EventArgs e)
        {
            doTagFiltering();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _optionSets[_currOptionSetIndex].tags.Items.AddRange(listBoxTags.SelectedItems.Cast<string>().Except(_optionSets[_currOptionSetIndex].tags.Items.Cast<string>()).ToArray());
            _optionSets[_currOptionSetIndex].activated.Checked = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            _optionSets[_currOptionSetIndex].tags.SelectedItems.Cast<string>().ToList().ForEach(i => _optionSets[_currOptionSetIndex].tags.Items.Remove(i));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            generateFilterOptions();
            _mainControl.ViewerForm.UpdateImages(_fileFilter);
            Close();
        }
    }
}
