namespace ScriptPad
{
    partial class AddEditMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditMovie));
            label1 = new Label();
            label2 = new Label();
            BtnSave = new Button();
            TxtTitle = new TextBox();
            TxtImagePath = new TextBox();
            label3 = new Label();
            DtpReleaseDate = new DateTimePicker();
            ratingNumeric = new NumericUpDown();
            ratingLabel = new Label();
            pictureBox1 = new PictureBox();
            NoteBox = new TextBox();
            NoteLabel = new Label();
            BrowseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ratingNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 2;
            label2.Text = "Image Path:";
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.CornflowerBlue;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = SystemColors.ControlLightLight;
            BtnSave.Location = new Point(106, 505);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(97, 33);
            BtnSave.TabIndex = 8;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtTitle
            // 
            TxtTitle.BorderStyle = BorderStyle.None;
            TxtTitle.Location = new Point(29, 62);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(237, 25);
            TxtTitle.TabIndex = 9;
            // 
            // TxtImagePath
            // 
            TxtImagePath.BorderStyle = BorderStyle.None;
            TxtImagePath.Location = new Point(29, 145);
            TxtImagePath.Name = "TxtImagePath";
            TxtImagePath.Size = new Size(200, 25);
            TxtImagePath.TabIndex = 10;
            TxtImagePath.TextChanged += TxtImagePath_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 421);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 5;
            label3.Text = "Release Date:";
            // 
            // DtpReleaseDate
            // 
            DtpReleaseDate.Format = DateTimePickerFormat.Short;
            DtpReleaseDate.Location = new Point(26, 447);
            DtpReleaseDate.Name = "DtpReleaseDate";
            DtpReleaseDate.RightToLeft = RightToLeft.No;
            DtpReleaseDate.Size = new Size(122, 32);
            DtpReleaseDate.TabIndex = 11;
            // 
            // ratingNumeric
            // 
            ratingNumeric.BorderStyle = BorderStyle.None;
            ratingNumeric.Location = new Point(190, 449);
            ratingNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ratingNumeric.Name = "ratingNumeric";
            ratingNumeric.Size = new Size(62, 28);
            ratingNumeric.TabIndex = 13;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ratingLabel.Location = new Point(184, 423);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(68, 23);
            ratingLabel.TabIndex = 14;
            ratingLabel.Text = "Rating:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 449);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // NoteBox
            // 
            NoteBox.BorderStyle = BorderStyle.None;
            NoteBox.Location = new Point(26, 223);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.ScrollBars = ScrollBars.Vertical;
            NoteBox.Size = new Size(265, 168);
            NoteBox.TabIndex = 16;
            // 
            // NoteLabel
            // 
            NoteLabel.AutoSize = true;
            NoteLabel.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteLabel.Location = new Point(26, 197);
            NoteLabel.Name = "NoteLabel";
            NoteLabel.Size = new Size(54, 23);
            NoteLabel.TabIndex = 17;
            NoteLabel.Text = "Note:";
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = Color.FromArgb(255, 192, 128);
            BrowseButton.FlatAppearance.BorderSize = 0;
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Font = new Font("Yu Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrowseButton.Location = new Point(235, 145);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(76, 25);
            BrowseButton.TabIndex = 18;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 573);
            Controls.Add(BrowseButton);
            Controls.Add(NoteLabel);
            Controls.Add(NoteBox);
            Controls.Add(pictureBox1);
            Controls.Add(ratingLabel);
            Controls.Add(ratingNumeric);
            Controls.Add(DtpReleaseDate);
            Controls.Add(TxtImagePath);
            Controls.Add(TxtTitle);
            Controls.Add(BtnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Info";
            Load += AddEditMovie_Load;
            ((System.ComponentModel.ISupportInitialize)ratingNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtImagePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpReleaseDate;
        private NumericUpDown ratingNumeric;
        private Label ratingLabel;
        private PictureBox pictureBox1;
        private TextBox NoteBox;
        private Label NoteLabel;
        private Button BrowseButton;
    }
}