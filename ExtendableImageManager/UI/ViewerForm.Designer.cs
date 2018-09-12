namespace ExtendableImageManager.UI
{
    partial class ViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonDislike = new System.Windows.Forms.Button();
            this.buttonUnvisit = new System.Windows.Forms.Button();
            this.trackBarAutoSlide = new System.Windows.Forms.TrackBar();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.labelCurrentIndex = new System.Windows.Forms.Label();
            this.listBoxArtists = new System.Windows.Forms.ListBox();
            this.listBoxTags = new System.Windows.Forms.ListBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.timerAutoSlide = new System.Windows.Forms.Timer(this.components);
            this.labelFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAutoSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(12, 13);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(63, 25);
            this.buttonFilter.TabIndex = 0;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(12, 44);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(29, 25);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<-";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(47, 44);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(29, 25);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "->";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(12, 76);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(63, 25);
            this.buttonLike.TabIndex = 3;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // buttonDislike
            // 
            this.buttonDislike.Location = new System.Drawing.Point(12, 107);
            this.buttonDislike.Name = "buttonDislike";
            this.buttonDislike.Size = new System.Drawing.Size(63, 25);
            this.buttonDislike.TabIndex = 4;
            this.buttonDislike.Text = "Dislike";
            this.buttonDislike.UseVisualStyleBackColor = true;
            this.buttonDislike.Click += new System.EventHandler(this.buttonDislike_Click);
            // 
            // buttonUnvisit
            // 
            this.buttonUnvisit.Location = new System.Drawing.Point(12, 139);
            this.buttonUnvisit.Name = "buttonUnvisit";
            this.buttonUnvisit.Size = new System.Drawing.Size(63, 25);
            this.buttonUnvisit.TabIndex = 5;
            this.buttonUnvisit.Text = "Unvisit";
            this.buttonUnvisit.UseVisualStyleBackColor = true;
            this.buttonUnvisit.Click += new System.EventHandler(this.buttonUnvisit_Click);
            // 
            // trackBarAutoSlide
            // 
            this.trackBarAutoSlide.Location = new System.Drawing.Point(30, 170);
            this.trackBarAutoSlide.Name = "trackBarAutoSlide";
            this.trackBarAutoSlide.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAutoSlide.Size = new System.Drawing.Size(45, 113);
            this.trackBarAutoSlide.TabIndex = 6;
            this.trackBarAutoSlide.ValueChanged += new System.EventHandler(this.trackBarAutoSlide_ValueChanged);
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.Location = new System.Drawing.Point(12, 306);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(13, 13);
            this.labelTotalCount.TabIndex = 7;
            this.labelTotalCount.Text = "0";
            // 
            // labelCurrentIndex
            // 
            this.labelCurrentIndex.AutoSize = true;
            this.labelCurrentIndex.Location = new System.Drawing.Point(12, 319);
            this.labelCurrentIndex.Name = "labelCurrentIndex";
            this.labelCurrentIndex.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentIndex.TabIndex = 8;
            this.labelCurrentIndex.Text = "0";
            // 
            // listBoxArtists
            // 
            this.listBoxArtists.FormattingEnabled = true;
            this.listBoxArtists.Location = new System.Drawing.Point(12, 341);
            this.listBoxArtists.Name = "listBoxArtists";
            this.listBoxArtists.Size = new System.Drawing.Size(60, 43);
            this.listBoxArtists.TabIndex = 10;
            // 
            // listBoxTags
            // 
            this.listBoxTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.Location = new System.Drawing.Point(12, 391);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(60, 251);
            this.listBoxTags.TabIndex = 11;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxMain.Location = new System.Drawing.Point(82, 13);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(733, 623);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 12;
            this.pictureBoxMain.TabStop = false;
            // 
            // timerAutoSlide
            // 
            this.timerAutoSlide.Interval = 1000;
            this.timerAutoSlide.Tick += new System.EventHandler(this.timerAutoSlide_Tick);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(14, 289);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(10, 13);
            this.labelFileName.TabIndex = 13;
            this.labelFileName.Text = "-";
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 649);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.listBoxTags);
            this.Controls.Add(this.listBoxArtists);
            this.Controls.Add(this.labelCurrentIndex);
            this.Controls.Add(this.labelTotalCount);
            this.Controls.Add(this.trackBarAutoSlide);
            this.Controls.Add(this.buttonUnvisit);
            this.Controls.Add(this.buttonDislike);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFilter);
            this.KeyPreview = true;
            this.Name = "ViewerForm";
            this.Text = "ViewerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewerForm_FormClosing);
            this.Shown += new System.EventHandler(this.ViewerForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ViewerForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAutoSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonDislike;
        private System.Windows.Forms.Button buttonUnvisit;
        private System.Windows.Forms.TrackBar trackBarAutoSlide;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Label labelCurrentIndex;
        private System.Windows.Forms.ListBox listBoxArtists;
        private System.Windows.Forms.ListBox listBoxTags;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Timer timerAutoSlide;
        private System.Windows.Forms.Label labelFileName;
    }
}