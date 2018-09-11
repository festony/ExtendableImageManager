namespace ExtendableImageManager.UI
{
    partial class FetcherForm
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
            this.textBoxUrls = new System.Windows.Forms.TextBox();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonFetch = new System.Windows.Forms.Button();
            this.numericUpDownFetchBatchSize = new System.Windows.Forms.NumericUpDown();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxNotFetched = new System.Windows.Forms.TextBox();
            this.comboBoxFetcher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFetchBatchSize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUrls
            // 
            this.textBoxUrls.Location = new System.Drawing.Point(13, 13);
            this.textBoxUrls.Multiline = true;
            this.textBoxUrls.Name = "textBoxUrls";
            this.textBoxUrls.Size = new System.Drawing.Size(876, 274);
            this.textBoxUrls.TabIndex = 0;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Location = new System.Drawing.Point(13, 294);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(117, 23);
            this.buttonAnalyze.TabIndex = 1;
            this.buttonAnalyze.Text = "Analyze urls";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // buttonFetch
            // 
            this.buttonFetch.Location = new System.Drawing.Point(136, 294);
            this.buttonFetch.Name = "buttonFetch";
            this.buttonFetch.Size = new System.Drawing.Size(117, 23);
            this.buttonFetch.TabIndex = 2;
            this.buttonFetch.Text = "Fetch";
            this.buttonFetch.UseVisualStyleBackColor = true;
            this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
            // 
            // numericUpDownFetchBatchSize
            // 
            this.numericUpDownFetchBatchSize.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownFetchBatchSize.Location = new System.Drawing.Point(259, 296);
            this.numericUpDownFetchBatchSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFetchBatchSize.Name = "numericUpDownFetchBatchSize";
            this.numericUpDownFetchBatchSize.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownFetchBatchSize.TabIndex = 3;
            this.numericUpDownFetchBatchSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(56, 368);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 21);
            this.textBoxTotal.TabIndex = 4;
            // 
            // textBoxNotFetched
            // 
            this.textBoxNotFetched.Location = new System.Drawing.Point(162, 368);
            this.textBoxNotFetched.Name = "textBoxNotFetched";
            this.textBoxNotFetched.Size = new System.Drawing.Size(100, 21);
            this.textBoxNotFetched.TabIndex = 5;
            // 
            // comboBoxFetcher
            // 
            this.comboBoxFetcher.FormattingEnabled = true;
            this.comboBoxFetcher.Location = new System.Drawing.Point(603, 293);
            this.comboBoxFetcher.Name = "comboBoxFetcher";
            this.comboBoxFetcher.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFetcher.TabIndex = 6;
            // 
            // FetcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 505);
            this.Controls.Add(this.comboBoxFetcher);
            this.Controls.Add(this.textBoxNotFetched);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.numericUpDownFetchBatchSize);
            this.Controls.Add(this.buttonFetch);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.textBoxUrls);
            this.Name = "FetcherForm";
            this.Text = "FetcherForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FetcherForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFetchBatchSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrls;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Button buttonFetch;
        private System.Windows.Forms.NumericUpDown numericUpDownFetchBatchSize;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxNotFetched;
        private System.Windows.Forms.ComboBox comboBoxFetcher;
    }
}