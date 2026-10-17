namespace Lab02
{
    partial class Bai01
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
            panelMouseDown = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            rtbNoiDung = new RichTextBox();
            panelMouseDown.SuspendLayout();
            SuspendLayout();
            // 
            // panelMouseDown
            // 
            panelMouseDown.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c__1_;
            panelMouseDown.BackgroundImageLayout = ImageLayout.Stretch;
            panelMouseDown.Controls.Add(btnMaximize);
            panelMouseDown.Controls.Add(btnMinimize);
            panelMouseDown.Controls.Add(btnClose);
            panelMouseDown.Dock = DockStyle.Top;
            panelMouseDown.Location = new Point(0, 0);
            panelMouseDown.Name = "panelMouseDown";
            panelMouseDown.Size = new Size(859, 69);
            panelMouseDown.TabIndex = 0;
            panelMouseDown.MouseDown += panelMouseDown_MouseDown;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(737, 15);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(55, 41);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(676, 15);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(55, 41);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(801, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 41);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDocFile
            // 
            btnDocFile.Anchor = AnchorStyles.None;
            btnDocFile.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnDocFile.BackgroundImageLayout = ImageLayout.Stretch;
            btnDocFile.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDocFile.ForeColor = SystemColors.ButtonHighlight;
            btnDocFile.Location = new Point(27, 179);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(169, 54);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Anchor = AnchorStyles.None;
            btnGhiFile.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnGhiFile.BackgroundImageLayout = ImageLayout.Stretch;
            btnGhiFile.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGhiFile.ForeColor = SystemColors.ButtonHighlight;
            btnGhiFile.Location = new Point(27, 299);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(169, 57);
            btnGhiFile.TabIndex = 2;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Anchor = AnchorStyles.None;
            rtbNoiDung.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbNoiDung.Location = new Point(247, 144);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.Size = new Size(545, 260);
            rtbNoiDung.TabIndex = 3;
            rtbNoiDung.Text = "";
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_ti9b0lti9b0lti9b1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 477);
            Controls.Add(rtbNoiDung);
            Controls.Add(btnGhiFile);
            Controls.Add(btnDocFile);
            Controls.Add(panelMouseDown);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bai01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai01";
            panelMouseDown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMouseDown;
        private Button btnDocFile;
        private Button btnGhiFile;
        private RichTextBox rtbNoiDung;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnClose;
    }
}