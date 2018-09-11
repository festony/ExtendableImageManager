using ExtendableImageManager.Core;
using ExtendableImageManager.Persistence.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendableImageManager.UI
{
    public partial class ViewerForm : Form
    {
        private MainControl _mainControl;
        private List<ImageItem> _imageItems;
        private int _currImageIndex;
        private int _timeTick;

        public ViewerForm()
        {
            InitializeComponent();
        }

        private void ViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            trackBarAutoSlide.Value = 0;
            timerAutoSlide.Stop();
            e.Cancel = true;
            this.Hide();
        }

        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;
        }

        private void resetOptions()
        {
            pictureBoxMain.ImageLocation = null;
            _currImageIndex = 0;
            _timeTick = 0;
            trackBarAutoSlide.Value = 0;
            listBoxArtists.Items.Clear();
            listBoxTags.Items.Clear();
            buttonLike.Text = "Like";
            buttonDislike.Text = "Dislike";
            buttonUnvisit.Text = "Unvisit";
            labelCurrentIndex.Text = _currImageIndex.ToString();
            labelFileName.Text = "-";
        }

        private void doFiltering()
        {
            // TODO: implement this
            // open filter form
            resetOptions();
            _imageItems = _mainControl.Persistence.GetImages(null);
            _imageItems = _imageItems.Where(img => !img.fileName.Contains("webm")).ToList();
            showImage();
        }

        private void updateLikeButtonText()
        {
            // TODO: implement this
        }

        private void updateDislikeButtonText()
        {
            // TODO: implement this
        }

        private void updateUnvisitButtonText()
        {
            // TODO: implement this
        }

        private void showImage()
        {
            if (_imageItems.Count > 0)
            {
                if (_currImageIndex < 0)
                {
                    _currImageIndex = 0;
                }
                if (_currImageIndex > _imageItems.Count - 1)
                {
                    _currImageIndex = _imageItems.Count - 1;
                }

                var image = _imageItems[_currImageIndex];

                pictureBoxMain.ImageLocation = _mainControl.FileStorage.GetFile(image.fileName);

                image.visited = true;

                updateLikeButtonText();
                updateDislikeButtonText();
                updateUnvisitButtonText();

                string[] allTags = image.tags.Where(t => t.tagType !="artist").Select(t => t.tagName + "|" + t.tagType).ToArray();
                string[] allArtists = image.tags.Where(t => t.tagType == "artist").Select(t => t.tagName).ToArray();
                listBoxTags.Items.Clear();
                listBoxTags.Items.AddRange(allTags);
                listBoxArtists.Items.Clear();
                listBoxArtists.Items.AddRange(allArtists);

                labelCurrentIndex.Text = _currImageIndex.ToString();
                labelFileName.Text = Path.GetFileNameWithoutExtension(image.fileName);
            }
            else
            {
                resetOptions();
            }
        }

        public void showPrevImage()
        {
            if (_imageItems.Count > 0)
            {
                _currImageIndex -= 1;
                if (_currImageIndex < 0)
                {
                    _currImageIndex += _imageItems.Count;
                }
                showImage();
            }
        }

        private void showNextImage()
        {
            if (_imageItems.Count > 0)
            {
                _currImageIndex += 1;
                if (_currImageIndex >= _imageItems.Count)
                {
                    _currImageIndex -= _imageItems.Count;
                }
                showImage();
            }
        }

        private void ViewerForm_Shown(object sender, EventArgs e)
        {
            // TODO: make this right
            resetOptions();
            _imageItems = _mainControl.Persistence.GetImages(null);
            _imageItems = _imageItems.Where(img => !img.fileName.Contains("webm")).ToList();
            showImage();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            showPrevImage();
            _timeTick = 0;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            showNextImage();
            _timeTick = 0;
        }
    }
}
