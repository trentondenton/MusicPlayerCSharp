namespace CEIS209_DENTON_CourseProject
{
    partial class mainForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.showAllSongsButton = new System.Windows.Forms.Button();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.songListLabel = new System.Windows.Forms.Label();
            this.songList = new System.Windows.Forms.ListBox();
            this.findSongButton = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(32, 369);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(209, 60);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titleLabel.Location = new System.Drawing.Point(29, 59);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 16);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(92, 59);
            this.titleText.Margin = new System.Windows.Forms.Padding(4);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(146, 22);
            this.titleText.TabIndex = 3;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(92, 122);
            this.artistText.Margin = new System.Windows.Forms.Padding(4);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(146, 22);
            this.artistText.TabIndex = 5;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.artistLabel.Location = new System.Drawing.Point(26, 122);
            this.artistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(39, 16);
            this.artistLabel.TabIndex = 4;
            this.artistLabel.Text = "Artist:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.genreLabel.Location = new System.Drawing.Point(18, 189);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(47, 16);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genre:";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(92, 246);
            this.yearText.Margin = new System.Windows.Forms.Padding(4);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(146, 22);
            this.yearText.TabIndex = 9;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.yearLabel.Location = new System.Drawing.Point(23, 246);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(39, 16);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year:";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(92, 308);
            this.urlText.Margin = new System.Windows.Forms.Padding(4);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(146, 22);
            this.urlText.TabIndex = 11;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.urlLabel.Location = new System.Drawing.Point(28, 308);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(37, 16);
            this.urlLabel.TabIndex = 10;
            this.urlLabel.Text = "URL:";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(297, 267);
            this.outputText.Margin = new System.Windows.Forms.Padding(4);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(376, 292);
            this.outputText.TabIndex = 12;
            // 
            // showAllSongsButton
            // 
            this.showAllSongsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showAllSongsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showAllSongsButton.Location = new System.Drawing.Point(32, 437);
            this.showAllSongsButton.Margin = new System.Windows.Forms.Padding(4);
            this.showAllSongsButton.Name = "showAllSongsButton";
            this.showAllSongsButton.Size = new System.Drawing.Size(209, 60);
            this.showAllSongsButton.TabIndex = 13;
            this.showAllSongsButton.Text = "Show All Songs";
            this.showAllSongsButton.UseVisualStyleBackColor = false;
            this.showAllSongsButton.Click += new System.EventHandler(this.showAllSongsButton_Click);
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.detailsLabel.Location = new System.Drawing.Point(294, 247);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(49, 16);
            this.detailsLabel.TabIndex = 15;
            this.detailsLabel.Text = "Details";
            // 
            // songListLabel
            // 
            this.songListLabel.AutoSize = true;
            this.songListLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.songListLabel.Location = new System.Drawing.Point(294, 66);
            this.songListLabel.Name = "songListLabel";
            this.songListLabel.Size = new System.Drawing.Size(62, 16);
            this.songListLabel.TabIndex = 16;
            this.songListLabel.Text = "Song List";
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 16;
            this.songList.Location = new System.Drawing.Point(297, 89);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(376, 116);
            this.songList.TabIndex = 17;
            // 
            // findSongButton
            // 
            this.findSongButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.findSongButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findSongButton.Location = new System.Drawing.Point(34, 500);
            this.findSongButton.Name = "findSongButton";
            this.findSongButton.Size = new System.Drawing.Size(204, 59);
            this.findSongButton.TabIndex = 18;
            this.findSongButton.Text = "Find Song";
            this.findSongButton.UseVisualStyleBackColor = false;
            this.findSongButton.Click += new System.EventHandler(this.findSongButton_Click);
            // 
            // clearFormButton
            // 
            this.clearFormButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearFormButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearFormButton.Location = new System.Drawing.Point(34, 565);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(204, 54);
            this.clearFormButton.TabIndex = 19;
            this.clearFormButton.Text = "Clear Song";
            this.clearFormButton.UseVisualStyleBackColor = false;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Rap",
            "Country",
            "Instrumental",
            "Classical"});
            this.genreComboBox.Location = new System.Drawing.Point(92, 186);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(146, 24);
            this.genreComboBox.TabIndex = 20;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 631);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.findSongButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.songListLabel);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.showAllSongsButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Music Video Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button showAllSongsButton;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label songListLabel;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button findSongButton;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.ComboBox genreComboBox;
    }
}

