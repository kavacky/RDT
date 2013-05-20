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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dlgSelectFiles = new System.Windows.Forms.OpenFileDialog();
            this.btnSingle = new System.Windows.Forms.Button();
            this.progressSingle = new System.Windows.Forms.ProgressBar();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.dlgSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSequence = new System.Windows.Forms.Button();
            this.progressSequence = new System.Windows.Forms.ProgressBar();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rdTypePixel = new System.Windows.Forms.RadioButton();
            this.rdTypeLinesVertical = new System.Windows.Forms.RadioButton();
            this.rdTypeLinesHorizontal = new System.Windows.Forms.RadioButton();
            this.rdTypeBlock = new System.Windows.Forms.RadioButton();
            this.txtBlockWidth = new System.Windows.Forms.TextBox();
            this.txtBlockHeight = new System.Windows.Forms.TextBox();
            this.lblBlockSize = new System.Windows.Forms.Label();
            this.grpSequence = new System.Windows.Forms.GroupBox();
            this.lblSequenceFramesAfter = new System.Windows.Forms.Label();
            this.lblSequenceFramesBefore = new System.Windows.Forms.Label();
            this.txtFramesAfter = new System.Windows.Forms.TextBox();
            this.txtFramesBefore = new System.Windows.Forms.TextBox();
            this.lblTotalProgress = new System.Windows.Forms.Label();
            this.lblFrameProgress = new System.Windows.Forms.Label();
            this.grpType.SuspendLayout();
            this.grpSequence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgSelectFiles
            // 
            this.dlgSelectFiles.FileName = "openFileDialog1";
            this.dlgSelectFiles.Multiselect = true;
            // 
            // btnSingle
            // 
            this.btnSingle.Location = new System.Drawing.Point(12, 12);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(100, 38);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "Single";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // progressSingle
            // 
            this.progressSingle.Location = new System.Drawing.Point(12, 327);
            this.progressSingle.Name = "progressSingle";
            this.progressSingle.Size = new System.Drawing.Size(253, 34);
            this.progressSingle.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(271, 12);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(468, 349);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "";
            // 
            // dlgSelectFolder
            // 
            this.dlgSelectFolder.ShowNewFolderButton = false;
            // 
            // btnSequence
            // 
            this.btnSequence.Location = new System.Drawing.Point(12, 56);
            this.btnSequence.Name = "btnSequence";
            this.btnSequence.Size = new System.Drawing.Size(100, 37);
            this.btnSequence.TabIndex = 9;
            this.btnSequence.Text = "Sequence";
            this.btnSequence.UseVisualStyleBackColor = true;
            this.btnSequence.Click += new System.EventHandler(this.btnSequence_Click);
            // 
            // progressSequence
            // 
            this.progressSequence.Location = new System.Drawing.Point(12, 268);
            this.progressSequence.Name = "progressSequence";
            this.progressSequence.Size = new System.Drawing.Size(253, 31);
            this.progressSequence.TabIndex = 12;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.lblBlockSize);
            this.grpType.Controls.Add(this.txtBlockHeight);
            this.grpType.Controls.Add(this.txtBlockWidth);
            this.grpType.Controls.Add(this.rdTypeBlock);
            this.grpType.Controls.Add(this.rdTypeLinesHorizontal);
            this.grpType.Controls.Add(this.rdTypeLinesVertical);
            this.grpType.Controls.Add(this.rdTypePixel);
            this.grpType.Location = new System.Drawing.Point(12, 122);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(253, 116);
            this.grpType.TabIndex = 15;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type";
            // 
            // rdTypePixel
            // 
            this.rdTypePixel.AutoSize = true;
            this.rdTypePixel.Location = new System.Drawing.Point(21, 19);
            this.rdTypePixel.Name = "rdTypePixel";
            this.rdTypePixel.Size = new System.Drawing.Size(52, 17);
            this.rdTypePixel.TabIndex = 4;
            this.rdTypePixel.Text = "Pixels";
            this.rdTypePixel.UseVisualStyleBackColor = true;
            // 
            // rdTypeLinesVertical
            // 
            this.rdTypeLinesVertical.AutoSize = true;
            this.rdTypeLinesVertical.Location = new System.Drawing.Point(21, 42);
            this.rdTypeLinesVertical.Name = "rdTypeLinesVertical";
            this.rdTypeLinesVertical.Size = new System.Drawing.Size(87, 17);
            this.rdTypeLinesVertical.TabIndex = 5;
            this.rdTypeLinesVertical.Text = "Lines vertical";
            this.rdTypeLinesVertical.UseVisualStyleBackColor = true;
            // 
            // rdTypeLinesHorizontal
            // 
            this.rdTypeLinesHorizontal.AutoSize = true;
            this.rdTypeLinesHorizontal.Location = new System.Drawing.Point(21, 65);
            this.rdTypeLinesHorizontal.Name = "rdTypeLinesHorizontal";
            this.rdTypeLinesHorizontal.Size = new System.Drawing.Size(98, 17);
            this.rdTypeLinesHorizontal.TabIndex = 6;
            this.rdTypeLinesHorizontal.Text = "Lines horizontal";
            this.rdTypeLinesHorizontal.UseVisualStyleBackColor = true;
            // 
            // rdTypeBlock
            // 
            this.rdTypeBlock.AutoSize = true;
            this.rdTypeBlock.Checked = true;
            this.rdTypeBlock.Location = new System.Drawing.Point(21, 88);
            this.rdTypeBlock.Name = "rdTypeBlock";
            this.rdTypeBlock.Size = new System.Drawing.Size(57, 17);
            this.rdTypeBlock.TabIndex = 7;
            this.rdTypeBlock.TabStop = true;
            this.rdTypeBlock.Text = "Blocks";
            this.rdTypeBlock.UseVisualStyleBackColor = true;
            // 
            // txtBlockWidth
            // 
            this.txtBlockWidth.Location = new System.Drawing.Point(84, 85);
            this.txtBlockWidth.Name = "txtBlockWidth";
            this.txtBlockWidth.Size = new System.Drawing.Size(35, 20);
            this.txtBlockWidth.TabIndex = 8;
            this.txtBlockWidth.Text = "56";
            // 
            // txtBlockHeight
            // 
            this.txtBlockHeight.Location = new System.Drawing.Point(143, 85);
            this.txtBlockHeight.Name = "txtBlockHeight";
            this.txtBlockHeight.Size = new System.Drawing.Size(35, 20);
            this.txtBlockHeight.TabIndex = 9;
            this.txtBlockHeight.Text = "56";
            // 
            // lblBlockSize
            // 
            this.lblBlockSize.AutoSize = true;
            this.lblBlockSize.Location = new System.Drawing.Point(125, 88);
            this.lblBlockSize.Name = "lblBlockSize";
            this.lblBlockSize.Size = new System.Drawing.Size(12, 13);
            this.lblBlockSize.TabIndex = 10;
            this.lblBlockSize.Text = "x";
            // 
            // grpSequence
            // 
            this.grpSequence.Controls.Add(this.lblSequenceFramesAfter);
            this.grpSequence.Controls.Add(this.lblSequenceFramesBefore);
            this.grpSequence.Controls.Add(this.txtFramesAfter);
            this.grpSequence.Controls.Add(this.txtFramesBefore);
            this.grpSequence.Location = new System.Drawing.Point(118, 56);
            this.grpSequence.Name = "grpSequence";
            this.grpSequence.Size = new System.Drawing.Size(147, 60);
            this.grpSequence.TabIndex = 16;
            this.grpSequence.TabStop = false;
            this.grpSequence.Text = "Sequence";
            // 
            // lblSequenceFramesAfter
            // 
            this.lblSequenceFramesAfter.AutoSize = true;
            this.lblSequenceFramesAfter.Location = new System.Drawing.Point(27, 38);
            this.lblSequenceFramesAfter.Name = "lblSequenceFramesAfter";
            this.lblSequenceFramesAfter.Size = new System.Drawing.Size(68, 13);
            this.lblSequenceFramesAfter.TabIndex = 18;
            this.lblSequenceFramesAfter.Text = "Frames after:";
            // 
            // lblSequenceFramesBefore
            // 
            this.lblSequenceFramesBefore.AutoSize = true;
            this.lblSequenceFramesBefore.Location = new System.Drawing.Point(18, 16);
            this.lblSequenceFramesBefore.Name = "lblSequenceFramesBefore";
            this.lblSequenceFramesBefore.Size = new System.Drawing.Size(77, 13);
            this.lblSequenceFramesBefore.TabIndex = 17;
            this.lblSequenceFramesBefore.Text = "Frames before:";
            // 
            // txtFramesAfter
            // 
            this.txtFramesAfter.Location = new System.Drawing.Point(101, 31);
            this.txtFramesAfter.Name = "txtFramesAfter";
            this.txtFramesAfter.Size = new System.Drawing.Size(35, 20);
            this.txtFramesAfter.TabIndex = 16;
            this.txtFramesAfter.Text = "3";
            // 
            // txtFramesBefore
            // 
            this.txtFramesBefore.Location = new System.Drawing.Point(101, 9);
            this.txtFramesBefore.Name = "txtFramesBefore";
            this.txtFramesBefore.Size = new System.Drawing.Size(35, 20);
            this.txtFramesBefore.TabIndex = 15;
            this.txtFramesBefore.Text = "3";
            // 
            // lblTotalProgress
            // 
            this.lblTotalProgress.AutoSize = true;
            this.lblTotalProgress.Location = new System.Drawing.Point(9, 252);
            this.lblTotalProgress.Name = "lblTotalProgress";
            this.lblTotalProgress.Size = new System.Drawing.Size(77, 13);
            this.lblTotalProgress.TabIndex = 17;
            this.lblTotalProgress.Text = "Total progress:";
            // 
            // lblFrameProgress
            // 
            this.lblFrameProgress.AutoSize = true;
            this.lblFrameProgress.Location = new System.Drawing.Point(9, 311);
            this.lblFrameProgress.Name = "lblFrameProgress";
            this.lblFrameProgress.Size = new System.Drawing.Size(82, 13);
            this.lblFrameProgress.TabIndex = 18;
            this.lblFrameProgress.Text = "Frame progress:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 372);
            this.Controls.Add(this.lblFrameProgress);
            this.Controls.Add(this.lblTotalProgress);
            this.Controls.Add(this.grpSequence);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.progressSequence);
            this.Controls.Add(this.btnSequence);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.progressSingle);
            this.Controls.Add(this.btnSingle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDT";
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpSequence.ResumeLayout(false);
            this.grpSequence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgSelectFiles;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.ProgressBar progressSingle;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectFolder;
        private System.Windows.Forms.Button btnSequence;
        private System.Windows.Forms.ProgressBar progressSequence;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.Label lblBlockSize;
        private System.Windows.Forms.TextBox txtBlockHeight;
        private System.Windows.Forms.TextBox txtBlockWidth;
        private System.Windows.Forms.RadioButton rdTypeBlock;
        private System.Windows.Forms.RadioButton rdTypeLinesHorizontal;
        private System.Windows.Forms.RadioButton rdTypeLinesVertical;
        private System.Windows.Forms.RadioButton rdTypePixel;
        private System.Windows.Forms.GroupBox grpSequence;
        private System.Windows.Forms.Label lblSequenceFramesAfter;
        private System.Windows.Forms.Label lblSequenceFramesBefore;
        private System.Windows.Forms.TextBox txtFramesAfter;
        private System.Windows.Forms.TextBox txtFramesBefore;
        private System.Windows.Forms.Label lblTotalProgress;
        private System.Windows.Forms.Label lblFrameProgress;
    }
}

