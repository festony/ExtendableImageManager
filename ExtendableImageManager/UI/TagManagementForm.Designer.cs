namespace ExtendableImageManager.UI
{
    partial class TagManagementForm
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
            this.listBoxValidTags = new System.Windows.Forms.ListBox();
            this.listBoxIgnoredTags = new System.Windows.Forms.ListBox();
            this.buttonLeftToRight = new System.Windows.Forms.Button();
            this.buttonRightToLeft = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxValidTags
            // 
            this.listBoxValidTags.FormattingEnabled = true;
            this.listBoxValidTags.ItemHeight = 12;
            this.listBoxValidTags.Location = new System.Drawing.Point(12, 12);
            this.listBoxValidTags.Name = "listBoxValidTags";
            this.listBoxValidTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxValidTags.Size = new System.Drawing.Size(232, 508);
            this.listBoxValidTags.TabIndex = 1;
            // 
            // listBoxIgnoredTags
            // 
            this.listBoxIgnoredTags.FormattingEnabled = true;
            this.listBoxIgnoredTags.ItemHeight = 12;
            this.listBoxIgnoredTags.Location = new System.Drawing.Point(379, 12);
            this.listBoxIgnoredTags.Name = "listBoxIgnoredTags";
            this.listBoxIgnoredTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxIgnoredTags.Size = new System.Drawing.Size(232, 508);
            this.listBoxIgnoredTags.TabIndex = 2;
            // 
            // buttonLeftToRight
            // 
            this.buttonLeftToRight.Location = new System.Drawing.Point(275, 118);
            this.buttonLeftToRight.Name = "buttonLeftToRight";
            this.buttonLeftToRight.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftToRight.TabIndex = 3;
            this.buttonLeftToRight.Text = "->";
            this.buttonLeftToRight.UseVisualStyleBackColor = true;
            this.buttonLeftToRight.Click += new System.EventHandler(this.buttonLeftToRight_Click);
            // 
            // buttonRightToLeft
            // 
            this.buttonRightToLeft.Location = new System.Drawing.Point(275, 253);
            this.buttonRightToLeft.Name = "buttonRightToLeft";
            this.buttonRightToLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonRightToLeft.TabIndex = 4;
            this.buttonRightToLeft.Text = "<-";
            this.buttonRightToLeft.UseVisualStyleBackColor = true;
            this.buttonRightToLeft.Click += new System.EventHandler(this.buttonRightToLeft_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(261, 12);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 21);
            this.textBoxFilter.TabIndex = 5;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // TagManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 533);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonRightToLeft);
            this.Controls.Add(this.buttonLeftToRight);
            this.Controls.Add(this.listBoxIgnoredTags);
            this.Controls.Add(this.listBoxValidTags);
            this.Name = "TagManagementForm";
            this.Text = "TagManagementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagManagementForm_FormClosing);
            this.Shown += new System.EventHandler(this.TagManagementForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxValidTags;
        private System.Windows.Forms.ListBox listBoxIgnoredTags;
        private System.Windows.Forms.Button buttonLeftToRight;
        private System.Windows.Forms.Button buttonRightToLeft;
        private System.Windows.Forms.TextBox textBoxFilter;
    }
}