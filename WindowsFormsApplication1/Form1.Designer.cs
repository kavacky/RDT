namespace RDT
{
    partial class frmMain
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
            this.dlgSelectFiles = new System.Windows.Forms.OpenFileDialog();
            this.btnSingle = new System.Windows.Forms.Button();
            this.progressSingle = new System.Windows.Forms.ProgressBar();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.rdTypePixel = new System.Windows.Forms.RadioButton();
            this.rdTypeLinesVertical = new System.Windows.Forms.RadioButton();
            this.rdTypeLinesHorizontal = new System.Windows.Forms.RadioButton();
            this.rdTypeBlock = new System.Windows.Forms.RadioButton();
            this.txtBlockWidth = new System.Windows.Forms.TextBox();
            this.txtBlockHeight = new System.Windows.Forms.TextBox();
            this.dlgSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSequence = new System.Windows.Forms.Button();
            this.txtFramesBefore = new System.Windows.Forms.TextBox();
            this.txtFramesAfter = new System.Windows.Forms.TextBox();
            this.progressSequence = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // dlgSelectFiles
            // 
            this.dlgSelectFiles.FileName = "openFileDialog1";
            this.dlgSelectFiles.Multiselect = true;
            // 
            // btnSingle
            // 
            this.btnSingle.Location = new System.Drawing.Point(566, 125);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(100, 38);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "button1";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // progressSingle
            // 
            this.progressSingle.Location = new System.Drawing.Point(491, 200);
            this.progressSingle.Name = "progressSingle";
            this.progressSingle.Size = new System.Drawing.Size(362, 34);
            this.progressSingle.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(21, 29);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(429, 402);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "";
            // 
            // rdTypePixel
            // 
            this.rdTypePixel.AutoSize = true;
            this.rdTypePixel.Location = new System.Drawing.Point(528, 309);
            this.rdTypePixel.Name = "rdTypePixel";
            this.rdTypePixel.Size = new System.Drawing.Size(46, 17);
            this.rdTypePixel.TabIndex = 3;
            this.rdTypePixel.Text = "pixel";
            this.rdTypePixel.UseVisualStyleBackColor = true;
            // 
            // rdTypeLinesVertical
            // 
            this.rdTypeLinesVertical.AutoSize = true;
            this.rdTypeLinesVertical.Location = new System.Drawing.Point(525, 348);
            this.rdTypeLinesVertical.Name = "rdTypeLinesVertical";
            this.rdTypeLinesVertical.Size = new System.Drawing.Size(45, 17);
            this.rdTypeLinesVertical.TabIndex = 4;
            this.rdTypeLinesVertical.Text = "lvert";
            this.rdTypeLinesVertical.UseVisualStyleBackColor = true;
            // 
            // rdTypeLinesHorizontal
            // 
            this.rdTypeLinesHorizontal.AutoSize = true;
            this.rdTypeLinesHorizontal.Location = new System.Drawing.Point(525, 394);
            this.rdTypeLinesHorizontal.Name = "rdTypeLinesHorizontal";
            this.rdTypeLinesHorizontal.Size = new System.Drawing.Size(42, 17);
            this.rdTypeLinesHorizontal.TabIndex = 5;
            this.rdTypeLinesHorizontal.Text = "lhor";
            this.rdTypeLinesHorizontal.UseVisualStyleBackColor = true;
            // 
            // rdTypeBlock
            // 
            this.rdTypeBlock.AutoSize = true;
            this.rdTypeBlock.Checked = true;
            this.rdTypeBlock.Location = new System.Drawing.Point(524, 439);
            this.rdTypeBlock.Name = "rdTypeBlock";
            this.rdTypeBlock.Size = new System.Drawing.Size(51, 17);
            this.rdTypeBlock.TabIndex = 6;
            this.rdTypeBlock.TabStop = true;
            this.rdTypeBlock.Text = "block";
            this.rdTypeBlock.UseVisualStyleBackColor = true;
            // 
            // txtBlockWidth
            // 
            this.txtBlockWidth.Location = new System.Drawing.Point(502, 496);
            this.txtBlockWidth.Name = "txtBlockWidth";
            this.txtBlockWidth.Size = new System.Drawing.Size(41, 20);
            this.txtBlockWidth.TabIndex = 7;
            this.txtBlockWidth.Text = "56";
            // 
            // txtBlockHeight
            // 
            this.txtBlockHeight.Location = new System.Drawing.Point(565, 494);
            this.txtBlockHeight.Name = "txtBlockHeight";
            this.txtBlockHeight.Size = new System.Drawing.Size(69, 20);
            this.txtBlockHeight.TabIndex = 8;
            this.txtBlockHeight.Text = "56";
            // 
            // dlgSelectFolder
            // 
            this.dlgSelectFolder.ShowNewFolderButton = false;
            // 
            // btnSequence
            // 
            this.btnSequence.Location = new System.Drawing.Point(740, 41);
            this.btnSequence.Name = "btnSequence";
            this.btnSequence.Size = new System.Drawing.Size(67, 37);
            this.btnSequence.TabIndex = 9;
            this.btnSequence.Text = "button2";
            this.btnSequence.UseVisualStyleBackColor = true;
            this.btnSequence.Click += new System.EventHandler(this.btnSequence_Click);
            // 
            // txtFramesBefore
            // 
            this.txtFramesBefore.Location = new System.Drawing.Point(723, 82);
            this.txtFramesBefore.Name = "txtFramesBefore";
            this.txtFramesBefore.Size = new System.Drawing.Size(46, 20);
            this.txtFramesBefore.TabIndex = 10;
            this.txtFramesBefore.Text = "3";
            // 
            // txtFramesAfter
            // 
            this.txtFramesAfter.Location = new System.Drawing.Point(789, 84);
            this.txtFramesAfter.Name = "txtFramesAfter";
            this.txtFramesAfter.Size = new System.Drawing.Size(48, 20);
            this.txtFramesAfter.TabIndex = 11;
            this.txtFramesAfter.Text = "3";
            // 
            // progressSequence
            // 
            this.progressSequence.Location = new System.Drawing.Point(707, 108);
            this.progressSequence.Name = "progressSequence";
            this.progressSequence.Size = new System.Drawing.Size(343, 31);
            this.progressSequence.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 577);
            this.Controls.Add(this.progressSequence);
            this.Controls.Add(this.txtFramesAfter);
            this.Controls.Add(this.txtFramesBefore);
            this.Controls.Add(this.btnSequence);
            this.Controls.Add(this.txtBlockHeight);
            this.Controls.Add(this.txtBlockWidth);
            this.Controls.Add(this.rdTypeBlock);
            this.Controls.Add(this.rdTypeLinesHorizontal);
            this.Controls.Add(this.rdTypeLinesVertical);
            this.Controls.Add(this.rdTypePixel);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.progressSingle);
            this.Controls.Add(this.btnSingle);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgSelectFiles;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.ProgressBar progressSingle;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.RadioButton rdTypePixel;
        private System.Windows.Forms.RadioButton rdTypeLinesVertical;
        private System.Windows.Forms.RadioButton rdTypeLinesHorizontal;
        private System.Windows.Forms.RadioButton rdTypeBlock;
        private System.Windows.Forms.TextBox txtBlockWidth;
        private System.Windows.Forms.TextBox txtBlockHeight;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectFolder;
        private System.Windows.Forms.Button btnSequence;
        private System.Windows.Forms.TextBox txtFramesBefore;
        private System.Windows.Forms.TextBox txtFramesAfter;
        private System.Windows.Forms.ProgressBar progressSequence;
    }
}

