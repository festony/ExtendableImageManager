namespace ExtendableImageManager.UI
{
    partial class FilterForm
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
            this.listBoxTags = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxArtistOnly = new System.Windows.Forms.CheckBox();
            this.labelAndSet0 = new System.Windows.Forms.Label();
            this.radioButtonAndSet0 = new System.Windows.Forms.RadioButton();
            this.checkBoxAndSet0 = new System.Windows.Forms.CheckBox();
            this.listBoxAndSet0 = new System.Windows.Forms.ListBox();
            this.labelAndSet1 = new System.Windows.Forms.Label();
            this.radioButtonAndSet1 = new System.Windows.Forms.RadioButton();
            this.checkBoxAndSet1 = new System.Windows.Forms.CheckBox();
            this.listBoxAndSet1 = new System.Windows.Forms.ListBox();
            this.labelAndSet2 = new System.Windows.Forms.Label();
            this.radioButtonAndSet2 = new System.Windows.Forms.RadioButton();
            this.checkBoxAndSet2 = new System.Windows.Forms.CheckBox();
            this.listBoxAndSet2 = new System.Windows.Forms.ListBox();
            this.labelAndSet3 = new System.Windows.Forms.Label();
            this.radioButtonAndSet3 = new System.Windows.Forms.RadioButton();
            this.checkBoxAndSet3 = new System.Windows.Forms.CheckBox();
            this.listBoxAndSet3 = new System.Windows.Forms.ListBox();
            this.labelAndSet4 = new System.Windows.Forms.Label();
            this.radioButtonAndSet4 = new System.Windows.Forms.RadioButton();
            this.checkBoxAndSet4 = new System.Windows.Forms.CheckBox();
            this.listBoxAndSet4 = new System.Windows.Forms.ListBox();
            this.labelAndSet5 = new System.Windows.Forms.Label();
            this.radioButtonAndSet5 = new System.Windows.Forms.RadioButton();
            this.checkBoxAndSet5 = new System.Windows.Forms.CheckBox();
            this.listBoxAndSet5 = new System.Windows.Forms.ListBox();
            this.labelNotSet = new System.Windows.Forms.Label();
            this.radioButtonNotSet = new System.Windows.Forms.RadioButton();
            this.checkBoxNotSet = new System.Windows.Forms.CheckBox();
            this.listBoxNotSet = new System.Windows.Forms.ListBox();
            this.checkBoxShuffle = new System.Windows.Forms.CheckBox();
            this.checkBoxVisited = new System.Windows.Forms.CheckBox();
            this.checkBoxNotVisited = new System.Windows.Forms.CheckBox();
            this.checkBoxNotLiked = new System.Windows.Forms.CheckBox();
            this.checkBoxLiked = new System.Windows.Forms.CheckBox();
            this.checkBoxNotDisliked = new System.Windows.Forms.CheckBox();
            this.checkBoxDisliked = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTags
            // 
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 12;
            this.listBoxTags.Location = new System.Drawing.Point(12, 40);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTags.Size = new System.Drawing.Size(162, 484);
            this.listBoxTags.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(162, 21);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(180, 292);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(44, 23);
            this.buttonRemove.TabIndex = 40;
            this.buttonRemove.Text = "<-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(180, 246);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 23);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "->";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxArtistOnly
            // 
            this.checkBoxArtistOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxArtistOnly.AutoSize = true;
            this.checkBoxArtistOnly.Location = new System.Drawing.Point(180, 18);
            this.checkBoxArtistOnly.Name = "checkBoxArtistOnly";
            this.checkBoxArtistOnly.Size = new System.Drawing.Size(120, 16);
            this.checkBoxArtistOnly.TabIndex = 41;
            this.checkBoxArtistOnly.Text = "Show Artist Only";
            this.checkBoxArtistOnly.UseVisualStyleBackColor = true;
            this.checkBoxArtistOnly.CheckedChanged += new System.EventHandler(this.checkBoxArtistOnly_CheckedChanged);
            // 
            // labelAndSet0
            // 
            this.labelAndSet0.AutoSize = true;
            this.labelAndSet0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAndSet0.Location = new System.Drawing.Point(312, 45);
            this.labelAndSet0.Name = "labelAndSet0";
            this.labelAndSet0.Size = new System.Drawing.Size(26, 12);
            this.labelAndSet0.TabIndex = 43;
            this.labelAndSet0.Text = "AND";
            // 
            // radioButtonAndSet0
            // 
            this.radioButtonAndSet0.AutoSize = true;
            this.radioButtonAndSet0.Location = new System.Drawing.Point(211, 146);
            this.radioButtonAndSet0.Name = "radioButtonAndSet0";
            this.radioButtonAndSet0.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAndSet0.TabIndex = 42;
            this.radioButtonAndSet0.TabStop = true;
            this.radioButtonAndSet0.Text = "-";
            this.radioButtonAndSet0.UseVisualStyleBackColor = true;
            // 
            // checkBoxAndSet0
            // 
            this.checkBoxAndSet0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAndSet0.AutoSize = true;
            this.checkBoxAndSet0.Location = new System.Drawing.Point(246, 44);
            this.checkBoxAndSet0.Name = "checkBoxAndSet0";
            this.checkBoxAndSet0.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAndSet0.TabIndex = 44;
            this.checkBoxAndSet0.Text = "Active";
            this.checkBoxAndSet0.UseVisualStyleBackColor = true;
            // 
            // listBoxAndSet0
            // 
            this.listBoxAndSet0.FormattingEnabled = true;
            this.listBoxAndSet0.ItemHeight = 12;
            this.listBoxAndSet0.Location = new System.Drawing.Point(246, 66);
            this.listBoxAndSet0.Name = "listBoxAndSet0";
            this.listBoxAndSet0.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAndSet0.Size = new System.Drawing.Size(162, 184);
            this.listBoxAndSet0.TabIndex = 45;
            // 
            // labelAndSet1
            // 
            this.labelAndSet1.AutoSize = true;
            this.labelAndSet1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAndSet1.Location = new System.Drawing.Point(312, 296);
            this.labelAndSet1.Name = "labelAndSet1";
            this.labelAndSet1.Size = new System.Drawing.Size(26, 12);
            this.labelAndSet1.TabIndex = 47;
            this.labelAndSet1.Text = "AND";
            // 
            // radioButtonAndSet1
            // 
            this.radioButtonAndSet1.AutoSize = true;
            this.radioButtonAndSet1.Location = new System.Drawing.Point(211, 397);
            this.radioButtonAndSet1.Name = "radioButtonAndSet1";
            this.radioButtonAndSet1.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAndSet1.TabIndex = 46;
            this.radioButtonAndSet1.TabStop = true;
            this.radioButtonAndSet1.Text = "-";
            this.radioButtonAndSet1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAndSet1
            // 
            this.checkBoxAndSet1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAndSet1.AutoSize = true;
            this.checkBoxAndSet1.Location = new System.Drawing.Point(246, 295);
            this.checkBoxAndSet1.Name = "checkBoxAndSet1";
            this.checkBoxAndSet1.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAndSet1.TabIndex = 48;
            this.checkBoxAndSet1.Text = "Active";
            this.checkBoxAndSet1.UseVisualStyleBackColor = true;
            // 
            // listBoxAndSet1
            // 
            this.listBoxAndSet1.FormattingEnabled = true;
            this.listBoxAndSet1.ItemHeight = 12;
            this.listBoxAndSet1.Location = new System.Drawing.Point(246, 317);
            this.listBoxAndSet1.Name = "listBoxAndSet1";
            this.listBoxAndSet1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAndSet1.Size = new System.Drawing.Size(162, 184);
            this.listBoxAndSet1.TabIndex = 49;
            // 
            // labelAndSet2
            // 
            this.labelAndSet2.AutoSize = true;
            this.labelAndSet2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAndSet2.Location = new System.Drawing.Point(520, 45);
            this.labelAndSet2.Name = "labelAndSet2";
            this.labelAndSet2.Size = new System.Drawing.Size(26, 12);
            this.labelAndSet2.TabIndex = 51;
            this.labelAndSet2.Text = "AND";
            // 
            // radioButtonAndSet2
            // 
            this.radioButtonAndSet2.AutoSize = true;
            this.radioButtonAndSet2.Location = new System.Drawing.Point(419, 146);
            this.radioButtonAndSet2.Name = "radioButtonAndSet2";
            this.radioButtonAndSet2.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAndSet2.TabIndex = 50;
            this.radioButtonAndSet2.TabStop = true;
            this.radioButtonAndSet2.Text = "-";
            this.radioButtonAndSet2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAndSet2
            // 
            this.checkBoxAndSet2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAndSet2.AutoSize = true;
            this.checkBoxAndSet2.Location = new System.Drawing.Point(454, 44);
            this.checkBoxAndSet2.Name = "checkBoxAndSet2";
            this.checkBoxAndSet2.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAndSet2.TabIndex = 52;
            this.checkBoxAndSet2.Text = "Active";
            this.checkBoxAndSet2.UseVisualStyleBackColor = true;
            // 
            // listBoxAndSet2
            // 
            this.listBoxAndSet2.FormattingEnabled = true;
            this.listBoxAndSet2.ItemHeight = 12;
            this.listBoxAndSet2.Location = new System.Drawing.Point(454, 66);
            this.listBoxAndSet2.Name = "listBoxAndSet2";
            this.listBoxAndSet2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAndSet2.Size = new System.Drawing.Size(162, 184);
            this.listBoxAndSet2.TabIndex = 53;
            // 
            // labelAndSet3
            // 
            this.labelAndSet3.AutoSize = true;
            this.labelAndSet3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAndSet3.Location = new System.Drawing.Point(520, 296);
            this.labelAndSet3.Name = "labelAndSet3";
            this.labelAndSet3.Size = new System.Drawing.Size(26, 12);
            this.labelAndSet3.TabIndex = 55;
            this.labelAndSet3.Text = "AND";
            // 
            // radioButtonAndSet3
            // 
            this.radioButtonAndSet3.AutoSize = true;
            this.radioButtonAndSet3.Location = new System.Drawing.Point(419, 397);
            this.radioButtonAndSet3.Name = "radioButtonAndSet3";
            this.radioButtonAndSet3.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAndSet3.TabIndex = 54;
            this.radioButtonAndSet3.TabStop = true;
            this.radioButtonAndSet3.Text = "-";
            this.radioButtonAndSet3.UseVisualStyleBackColor = true;
            // 
            // checkBoxAndSet3
            // 
            this.checkBoxAndSet3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAndSet3.AutoSize = true;
            this.checkBoxAndSet3.Location = new System.Drawing.Point(454, 295);
            this.checkBoxAndSet3.Name = "checkBoxAndSet3";
            this.checkBoxAndSet3.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAndSet3.TabIndex = 56;
            this.checkBoxAndSet3.Text = "Active";
            this.checkBoxAndSet3.UseVisualStyleBackColor = true;
            // 
            // listBoxAndSet3
            // 
            this.listBoxAndSet3.FormattingEnabled = true;
            this.listBoxAndSet3.ItemHeight = 12;
            this.listBoxAndSet3.Location = new System.Drawing.Point(454, 317);
            this.listBoxAndSet3.Name = "listBoxAndSet3";
            this.listBoxAndSet3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAndSet3.Size = new System.Drawing.Size(162, 184);
            this.listBoxAndSet3.TabIndex = 57;
            // 
            // labelAndSet4
            // 
            this.labelAndSet4.AutoSize = true;
            this.labelAndSet4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAndSet4.Location = new System.Drawing.Point(729, 45);
            this.labelAndSet4.Name = "labelAndSet4";
            this.labelAndSet4.Size = new System.Drawing.Size(26, 12);
            this.labelAndSet4.TabIndex = 59;
            this.labelAndSet4.Text = "AND";
            // 
            // radioButtonAndSet4
            // 
            this.radioButtonAndSet4.AutoSize = true;
            this.radioButtonAndSet4.Location = new System.Drawing.Point(628, 146);
            this.radioButtonAndSet4.Name = "radioButtonAndSet4";
            this.radioButtonAndSet4.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAndSet4.TabIndex = 58;
            this.radioButtonAndSet4.TabStop = true;
            this.radioButtonAndSet4.Text = "-";
            this.radioButtonAndSet4.UseVisualStyleBackColor = true;
            // 
            // checkBoxAndSet4
            // 
            this.checkBoxAndSet4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAndSet4.AutoSize = true;
            this.checkBoxAndSet4.Location = new System.Drawing.Point(663, 44);
            this.checkBoxAndSet4.Name = "checkBoxAndSet4";
            this.checkBoxAndSet4.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAndSet4.TabIndex = 60;
            this.checkBoxAndSet4.Text = "Active";
            this.checkBoxAndSet4.UseVisualStyleBackColor = true;
            // 
            // listBoxAndSet4
            // 
            this.listBoxAndSet4.FormattingEnabled = true;
            this.listBoxAndSet4.ItemHeight = 12;
            this.listBoxAndSet4.Location = new System.Drawing.Point(663, 66);
            this.listBoxAndSet4.Name = "listBoxAndSet4";
            this.listBoxAndSet4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAndSet4.Size = new System.Drawing.Size(162, 184);
            this.listBoxAndSet4.TabIndex = 61;
            // 
            // labelAndSet5
            // 
            this.labelAndSet5.AutoSize = true;
            this.labelAndSet5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAndSet5.Location = new System.Drawing.Point(729, 296);
            this.labelAndSet5.Name = "labelAndSet5";
            this.labelAndSet5.Size = new System.Drawing.Size(26, 12);
            this.labelAndSet5.TabIndex = 63;
            this.labelAndSet5.Text = "AND";
            // 
            // radioButtonAndSet5
            // 
            this.radioButtonAndSet5.AutoSize = true;
            this.radioButtonAndSet5.Location = new System.Drawing.Point(628, 397);
            this.radioButtonAndSet5.Name = "radioButtonAndSet5";
            this.radioButtonAndSet5.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAndSet5.TabIndex = 62;
            this.radioButtonAndSet5.TabStop = true;
            this.radioButtonAndSet5.Text = "-";
            this.radioButtonAndSet5.UseVisualStyleBackColor = true;
            // 
            // checkBoxAndSet5
            // 
            this.checkBoxAndSet5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAndSet5.AutoSize = true;
            this.checkBoxAndSet5.Location = new System.Drawing.Point(663, 295);
            this.checkBoxAndSet5.Name = "checkBoxAndSet5";
            this.checkBoxAndSet5.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAndSet5.TabIndex = 64;
            this.checkBoxAndSet5.Text = "Active";
            this.checkBoxAndSet5.UseVisualStyleBackColor = true;
            // 
            // listBoxAndSet5
            // 
            this.listBoxAndSet5.FormattingEnabled = true;
            this.listBoxAndSet5.ItemHeight = 12;
            this.listBoxAndSet5.Location = new System.Drawing.Point(663, 317);
            this.listBoxAndSet5.Name = "listBoxAndSet5";
            this.listBoxAndSet5.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAndSet5.Size = new System.Drawing.Size(162, 184);
            this.listBoxAndSet5.TabIndex = 65;
            // 
            // labelNotSet
            // 
            this.labelNotSet.AutoSize = true;
            this.labelNotSet.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNotSet.Location = new System.Drawing.Point(943, 296);
            this.labelNotSet.Name = "labelNotSet";
            this.labelNotSet.Size = new System.Drawing.Size(26, 12);
            this.labelNotSet.TabIndex = 67;
            this.labelNotSet.Text = "AND";
            // 
            // radioButtonNotSet
            // 
            this.radioButtonNotSet.AutoSize = true;
            this.radioButtonNotSet.Location = new System.Drawing.Point(842, 397);
            this.radioButtonNotSet.Name = "radioButtonNotSet";
            this.radioButtonNotSet.Size = new System.Drawing.Size(29, 16);
            this.radioButtonNotSet.TabIndex = 66;
            this.radioButtonNotSet.TabStop = true;
            this.radioButtonNotSet.Text = "-";
            this.radioButtonNotSet.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotSet
            // 
            this.checkBoxNotSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNotSet.AutoSize = true;
            this.checkBoxNotSet.Location = new System.Drawing.Point(877, 295);
            this.checkBoxNotSet.Name = "checkBoxNotSet";
            this.checkBoxNotSet.Size = new System.Drawing.Size(60, 16);
            this.checkBoxNotSet.TabIndex = 68;
            this.checkBoxNotSet.Text = "Active";
            this.checkBoxNotSet.UseVisualStyleBackColor = true;
            // 
            // listBoxNotSet
            // 
            this.listBoxNotSet.FormattingEnabled = true;
            this.listBoxNotSet.ItemHeight = 12;
            this.listBoxNotSet.Location = new System.Drawing.Point(877, 317);
            this.listBoxNotSet.Name = "listBoxNotSet";
            this.listBoxNotSet.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxNotSet.Size = new System.Drawing.Size(162, 184);
            this.listBoxNotSet.TabIndex = 69;
            // 
            // checkBoxShuffle
            // 
            this.checkBoxShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShuffle.AutoSize = true;
            this.checkBoxShuffle.Checked = true;
            this.checkBoxShuffle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShuffle.Location = new System.Drawing.Point(855, 15);
            this.checkBoxShuffle.Name = "checkBoxShuffle";
            this.checkBoxShuffle.Size = new System.Drawing.Size(114, 16);
            this.checkBoxShuffle.TabIndex = 70;
            this.checkBoxShuffle.Text = "Shuffle Results";
            this.checkBoxShuffle.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisited
            // 
            this.checkBoxVisited.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxVisited.AutoSize = true;
            this.checkBoxVisited.Checked = true;
            this.checkBoxVisited.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVisited.Location = new System.Drawing.Point(855, 37);
            this.checkBoxVisited.Name = "checkBoxVisited";
            this.checkBoxVisited.Size = new System.Drawing.Size(66, 16);
            this.checkBoxVisited.TabIndex = 71;
            this.checkBoxVisited.Text = "Visited";
            this.checkBoxVisited.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotVisited
            // 
            this.checkBoxNotVisited.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNotVisited.AutoSize = true;
            this.checkBoxNotVisited.Checked = true;
            this.checkBoxNotVisited.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotVisited.Location = new System.Drawing.Point(961, 37);
            this.checkBoxNotVisited.Name = "checkBoxNotVisited";
            this.checkBoxNotVisited.Size = new System.Drawing.Size(90, 16);
            this.checkBoxNotVisited.TabIndex = 72;
            this.checkBoxNotVisited.Text = "Not Visited";
            this.checkBoxNotVisited.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotLiked
            // 
            this.checkBoxNotLiked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNotLiked.AutoSize = true;
            this.checkBoxNotLiked.Checked = true;
            this.checkBoxNotLiked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotLiked.Location = new System.Drawing.Point(961, 59);
            this.checkBoxNotLiked.Name = "checkBoxNotLiked";
            this.checkBoxNotLiked.Size = new System.Drawing.Size(78, 16);
            this.checkBoxNotLiked.TabIndex = 74;
            this.checkBoxNotLiked.Text = "Not Liked";
            this.checkBoxNotLiked.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiked
            // 
            this.checkBoxLiked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxLiked.AutoSize = true;
            this.checkBoxLiked.Checked = true;
            this.checkBoxLiked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLiked.Location = new System.Drawing.Point(855, 59);
            this.checkBoxLiked.Name = "checkBoxLiked";
            this.checkBoxLiked.Size = new System.Drawing.Size(54, 16);
            this.checkBoxLiked.TabIndex = 73;
            this.checkBoxLiked.Text = "Liked";
            this.checkBoxLiked.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotDisliked
            // 
            this.checkBoxNotDisliked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNotDisliked.AutoSize = true;
            this.checkBoxNotDisliked.Checked = true;
            this.checkBoxNotDisliked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotDisliked.Location = new System.Drawing.Point(961, 81);
            this.checkBoxNotDisliked.Name = "checkBoxNotDisliked";
            this.checkBoxNotDisliked.Size = new System.Drawing.Size(96, 16);
            this.checkBoxNotDisliked.TabIndex = 76;
            this.checkBoxNotDisliked.Text = "Not Disliked";
            this.checkBoxNotDisliked.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisliked
            // 
            this.checkBoxDisliked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDisliked.AutoSize = true;
            this.checkBoxDisliked.Location = new System.Drawing.Point(855, 81);
            this.checkBoxDisliked.Name = "checkBoxDisliked";
            this.checkBoxDisliked.Size = new System.Drawing.Size(72, 16);
            this.checkBoxDisliked.TabIndex = 75;
            this.checkBoxDisliked.Text = "Disliked";
            this.checkBoxDisliked.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(945, 507);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 77;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(1026, 507);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 78;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1101, 536);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkBoxNotDisliked);
            this.Controls.Add(this.checkBoxDisliked);
            this.Controls.Add(this.checkBoxNotLiked);
            this.Controls.Add(this.checkBoxLiked);
            this.Controls.Add(this.checkBoxNotVisited);
            this.Controls.Add(this.checkBoxVisited);
            this.Controls.Add(this.checkBoxShuffle);
            this.Controls.Add(this.labelNotSet);
            this.Controls.Add(this.radioButtonNotSet);
            this.Controls.Add(this.checkBoxNotSet);
            this.Controls.Add(this.listBoxNotSet);
            this.Controls.Add(this.labelAndSet5);
            this.Controls.Add(this.radioButtonAndSet5);
            this.Controls.Add(this.checkBoxAndSet5);
            this.Controls.Add(this.listBoxAndSet5);
            this.Controls.Add(this.labelAndSet4);
            this.Controls.Add(this.radioButtonAndSet4);
            this.Controls.Add(this.checkBoxAndSet4);
            this.Controls.Add(this.listBoxAndSet4);
            this.Controls.Add(this.labelAndSet3);
            this.Controls.Add(this.radioButtonAndSet3);
            this.Controls.Add(this.checkBoxAndSet3);
            this.Controls.Add(this.listBoxAndSet3);
            this.Controls.Add(this.labelAndSet2);
            this.Controls.Add(this.radioButtonAndSet2);
            this.Controls.Add(this.checkBoxAndSet2);
            this.Controls.Add(this.listBoxAndSet2);
            this.Controls.Add(this.labelAndSet1);
            this.Controls.Add(this.radioButtonAndSet1);
            this.Controls.Add(this.checkBoxAndSet1);
            this.Controls.Add(this.listBoxAndSet1);
            this.Controls.Add(this.labelAndSet0);
            this.Controls.Add(this.radioButtonAndSet0);
            this.Controls.Add(this.checkBoxAndSet0);
            this.Controls.Add(this.listBoxAndSet0);
            this.Controls.Add(this.checkBoxArtistOnly);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxTags);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterForm_FormClosing);
            this.Shown += new System.EventHandler(this.FilterForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTags;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxArtistOnly;
        private System.Windows.Forms.Label labelAndSet0;
        private System.Windows.Forms.RadioButton radioButtonAndSet0;
        private System.Windows.Forms.CheckBox checkBoxAndSet0;
        private System.Windows.Forms.ListBox listBoxAndSet0;
        private System.Windows.Forms.Label labelAndSet1;
        private System.Windows.Forms.RadioButton radioButtonAndSet1;
        private System.Windows.Forms.CheckBox checkBoxAndSet1;
        private System.Windows.Forms.ListBox listBoxAndSet1;
        private System.Windows.Forms.Label labelAndSet2;
        private System.Windows.Forms.RadioButton radioButtonAndSet2;
        private System.Windows.Forms.CheckBox checkBoxAndSet2;
        private System.Windows.Forms.ListBox listBoxAndSet2;
        private System.Windows.Forms.Label labelAndSet3;
        private System.Windows.Forms.RadioButton radioButtonAndSet3;
        private System.Windows.Forms.CheckBox checkBoxAndSet3;
        private System.Windows.Forms.ListBox listBoxAndSet3;
        private System.Windows.Forms.Label labelAndSet4;
        private System.Windows.Forms.RadioButton radioButtonAndSet4;
        private System.Windows.Forms.CheckBox checkBoxAndSet4;
        private System.Windows.Forms.ListBox listBoxAndSet4;
        private System.Windows.Forms.Label labelAndSet5;
        private System.Windows.Forms.RadioButton radioButtonAndSet5;
        private System.Windows.Forms.CheckBox checkBoxAndSet5;
        private System.Windows.Forms.ListBox listBoxAndSet5;
        private System.Windows.Forms.Label labelNotSet;
        private System.Windows.Forms.RadioButton radioButtonNotSet;
        private System.Windows.Forms.CheckBox checkBoxNotSet;
        private System.Windows.Forms.ListBox listBoxNotSet;
        private System.Windows.Forms.CheckBox checkBoxShuffle;
        private System.Windows.Forms.CheckBox checkBoxVisited;
        private System.Windows.Forms.CheckBox checkBoxNotVisited;
        private System.Windows.Forms.CheckBox checkBoxNotLiked;
        private System.Windows.Forms.CheckBox checkBoxLiked;
        private System.Windows.Forms.CheckBox checkBoxNotDisliked;
        private System.Windows.Forms.CheckBox checkBoxDisliked;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}