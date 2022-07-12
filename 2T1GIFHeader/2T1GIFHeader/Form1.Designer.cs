namespace _2T1GIFHeader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GBInput = new System.Windows.Forms.GroupBox();
            this.TxtInputGIF = new System.Windows.Forms.TextBox();
            this.GBOutput = new System.Windows.Forms.GroupBox();
            this.TxtOutputFolder = new System.Windows.Forms.TextBox();
            this.GBProcess = new System.Windows.Forms.GroupBox();
            this.RBGIF = new System.Windows.Forms.RadioButton();
            this.RBPNG = new System.Windows.Forms.RadioButton();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.RBBMP = new System.Windows.Forms.RadioButton();
            this.GBInput.SuspendLayout();
            this.GBOutput.SuspendLayout();
            this.GBProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBInput
            // 
            this.GBInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBInput.Controls.Add(this.TxtInputGIF);
            this.GBInput.Location = new System.Drawing.Point(12, 0);
            this.GBInput.Name = "GBInput";
            this.GBInput.Size = new System.Drawing.Size(328, 47);
            this.GBInput.TabIndex = 0;
            this.GBInput.TabStop = false;
            this.GBInput.Text = "Choose input GIF";
            // 
            // TxtInputGIF
            // 
            this.TxtInputGIF.BackColor = System.Drawing.SystemColors.Window;
            this.TxtInputGIF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtInputGIF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtInputGIF.Location = new System.Drawing.Point(3, 19);
            this.TxtInputGIF.Name = "TxtInputGIF";
            this.TxtInputGIF.ReadOnly = true;
            this.TxtInputGIF.Size = new System.Drawing.Size(322, 23);
            this.TxtInputGIF.TabIndex = 0;
            this.TxtInputGIF.Click += new System.EventHandler(this.TxtInputGIF_Click);
            // 
            // GBOutput
            // 
            this.GBOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBOutput.Controls.Add(this.TxtOutputFolder);
            this.GBOutput.Location = new System.Drawing.Point(12, 53);
            this.GBOutput.Name = "GBOutput";
            this.GBOutput.Size = new System.Drawing.Size(328, 47);
            this.GBOutput.TabIndex = 0;
            this.GBOutput.TabStop = false;
            this.GBOutput.Text = "Choose output folder";
            // 
            // TxtOutputFolder
            // 
            this.TxtOutputFolder.BackColor = System.Drawing.SystemColors.Window;
            this.TxtOutputFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOutputFolder.Location = new System.Drawing.Point(3, 19);
            this.TxtOutputFolder.Name = "TxtOutputFolder";
            this.TxtOutputFolder.ReadOnly = true;
            this.TxtOutputFolder.Size = new System.Drawing.Size(322, 23);
            this.TxtOutputFolder.TabIndex = 1;
            this.TxtOutputFolder.Click += new System.EventHandler(this.TxtOutputFolder_Click);
            // 
            // GBProcess
            // 
            this.GBProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBProcess.Controls.Add(this.RBBMP);
            this.GBProcess.Controls.Add(this.RBGIF);
            this.GBProcess.Controls.Add(this.RBPNG);
            this.GBProcess.Controls.Add(this.BtnProcess);
            this.GBProcess.Location = new System.Drawing.Point(12, 106);
            this.GBProcess.Name = "GBProcess";
            this.GBProcess.Size = new System.Drawing.Size(328, 47);
            this.GBProcess.TabIndex = 0;
            this.GBProcess.TabStop = false;
            this.GBProcess.Text = "Process";
            // 
            // RBGIF
            // 
            this.RBGIF.AutoSize = true;
            this.RBGIF.Location = new System.Drawing.Point(61, 21);
            this.RBGIF.Name = "RBGIF";
            this.RBGIF.Size = new System.Drawing.Size(42, 19);
            this.RBGIF.TabIndex = 2;
            this.RBGIF.Text = "GIF";
            this.RBGIF.UseVisualStyleBackColor = true;
            // 
            // RBPNG
            // 
            this.RBPNG.AutoSize = true;
            this.RBPNG.Checked = true;
            this.RBPNG.Location = new System.Drawing.Point(6, 21);
            this.RBPNG.Name = "RBPNG";
            this.RBPNG.Size = new System.Drawing.Size(49, 19);
            this.RBPNG.TabIndex = 1;
            this.RBPNG.TabStop = true;
            this.RBPNG.Text = "PNG";
            this.RBPNG.UseVisualStyleBackColor = true;
            // 
            // BtnProcess
            // 
            this.BtnProcess.Location = new System.Drawing.Point(165, 19);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(160, 23);
            this.BtnProcess.TabIndex = 0;
            this.BtnProcess.Text = "Split GIF Into Frames";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // RBBMP
            // 
            this.RBBMP.AutoSize = true;
            this.RBBMP.Location = new System.Drawing.Point(109, 21);
            this.RBBMP.Name = "RBBMP";
            this.RBBMP.Size = new System.Drawing.Size(50, 19);
            this.RBBMP.TabIndex = 3;
            this.RBBMP.Text = "BMP";
            this.RBBMP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 164);
            this.Controls.Add(this.GBOutput);
            this.Controls.Add(this.GBProcess);
            this.Controls.Add(this.GBInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "2T1 GIF Header";
            this.GBInput.ResumeLayout(false);
            this.GBInput.PerformLayout();
            this.GBOutput.ResumeLayout(false);
            this.GBOutput.PerformLayout();
            this.GBProcess.ResumeLayout(false);
            this.GBProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GBInput;
        private TextBox TxtInputGIF;
        private GroupBox GBOutput;
        private GroupBox GBProcess;
        private TextBox TxtOutputFolder;
        private Button BtnProcess;
        private RadioButton RBGIF;
        private RadioButton RBPNG;
        private RadioButton RBBMP;
    }
}