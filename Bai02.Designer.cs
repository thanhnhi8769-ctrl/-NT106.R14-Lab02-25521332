namespace Lab02
{
    partial class Bai02
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
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnRead = new Button();
            lblFileName = new Label();
            lblSize = new Label();
            lblURL = new Label();
            lblLineCount = new Label();
            lblWordCount = new Label();
            lblCharCount = new Label();
            txtFileName = new TextBox();
            txtSize = new TextBox();
            txtURL = new TextBox();
            txtLineCount = new TextBox();
            txtWordCount = new TextBox();
            txtCharCount = new TextBox();
            btnExit = new Button();
            rtbContent = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            panelMouseDown.SuspendLayout();
            SuspendLayout();
            // 
            // panelMouseDown
            // 
            panelMouseDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMouseDown.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            panelMouseDown.BackgroundImageLayout = ImageLayout.Stretch;
            panelMouseDown.Controls.Add(btnMinimize);
            panelMouseDown.Controls.Add(btnMaximize);
            panelMouseDown.Controls.Add(btnClose);
            panelMouseDown.Location = new Point(-29, 0);
            panelMouseDown.Name = "panelMouseDown";
            panelMouseDown.Size = new Size(1278, 51);
            panelMouseDown.TabIndex = 0;
            panelMouseDown.MouseDown += panelMouseDown_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ForeColor = SystemColors.ActiveCaptionText;
            btnMinimize.Location = new Point(1121, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(43, 34);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = SystemColors.ActiveCaptionText;
            btnMaximize.Location = new Point(1170, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(43, 34);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(1219, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRead
            // 
            btnRead.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnRead.BackgroundImageLayout = ImageLayout.Stretch;
            btnRead.Location = new Point(56, 77);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(428, 34);
            btnRead.TabIndex = 1;
            btnRead.Text = "Read from File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.BackColor = Color.Transparent;
            lblFileName.Location = new Point(56, 124);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(97, 22);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "File name";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.BackColor = Color.Transparent;
            lblSize.Location = new Point(56, 168);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(46, 22);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size";
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.BackColor = Color.Transparent;
            lblURL.Location = new Point(56, 214);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(46, 22);
            lblURL.TabIndex = 4;
            lblURL.Text = "URL";
            // 
            // lblLineCount
            // 
            lblLineCount.AutoSize = true;
            lblLineCount.BackColor = Color.Transparent;
            lblLineCount.Location = new Point(56, 257);
            lblLineCount.Name = "lblLineCount";
            lblLineCount.Size = new Size(105, 22);
            lblLineCount.TabIndex = 5;
            lblLineCount.Text = "Line count";
            // 
            // lblWordCount
            // 
            lblWordCount.AutoSize = true;
            lblWordCount.BackColor = Color.Transparent;
            lblWordCount.Location = new Point(56, 302);
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(125, 22);
            lblWordCount.TabIndex = 6;
            lblWordCount.Text = "Words count";
            // 
            // lblCharCount
            // 
            lblCharCount.AutoSize = true;
            lblCharCount.BackColor = Color.Transparent;
            lblCharCount.Location = new Point(56, 346);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(157, 22);
            lblCharCount.TabIndex = 7;
            lblCharCount.Text = "Character count";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(235, 121);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(659, 29);
            txtFileName.TabIndex = 8;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(235, 165);
            txtSize.Name = "txtSize";
            txtSize.ReadOnly = true;
            txtSize.Size = new Size(659, 29);
            txtSize.TabIndex = 9;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(235, 207);
            txtURL.Name = "txtURL";
            txtURL.ReadOnly = true;
            txtURL.Size = new Size(659, 29);
            txtURL.TabIndex = 10;
            // 
            // txtLineCount
            // 
            txtLineCount.Location = new Point(235, 250);
            txtLineCount.Name = "txtLineCount";
            txtLineCount.ReadOnly = true;
            txtLineCount.Size = new Size(659, 29);
            txtLineCount.TabIndex = 11;
            // 
            // txtWordCount
            // 
            txtWordCount.Location = new Point(235, 295);
            txtWordCount.Name = "txtWordCount";
            txtWordCount.ReadOnly = true;
            txtWordCount.Size = new Size(659, 29);
            txtWordCount.TabIndex = 12;
            // 
            // txtCharCount
            // 
            txtCharCount.Location = new Point(235, 339);
            txtCharCount.Name = "txtCharCount";
            txtCharCount.ReadOnly = true;
            txtCharCount.Size = new Size(659, 29);
            txtCharCount.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.Gemini_Generated_Image_ttuthrttuthrttut;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Location = new Point(56, 385);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(428, 34);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // rtbContent
            // 
            rtbContent.BackColor = Color.Black;
            rtbContent.ForeColor = SystemColors.Window;
            rtbContent.Location = new Point(948, 77);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(249, 316);
            rtbContent.TabIndex = 15;
            rtbContent.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Gif_ic370ric370ric37;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1245, 454);
            Controls.Add(rtbContent);
            Controls.Add(btnExit);
            Controls.Add(txtCharCount);
            Controls.Add(txtWordCount);
            Controls.Add(txtLineCount);
            Controls.Add(txtURL);
            Controls.Add(txtSize);
            Controls.Add(txtFileName);
            Controls.Add(lblCharCount);
            Controls.Add(lblWordCount);
            Controls.Add(lblLineCount);
            Controls.Add(lblURL);
            Controls.Add(lblSize);
            Controls.Add(lblFileName);
            Controls.Add(btnRead);
            Controls.Add(panelMouseDown);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bai02";
            Text = "Bai02";
            panelMouseDown.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMouseDown;
        private Button btnRead;
        private Label lblFileName;
        private Label lblSize;
        private Label lblURL;
        private Label lblLineCount;
        private Label lblWordCount;
        private Label lblCharCount;
        private TextBox txtFileName;
        private TextBox txtSize;
        private TextBox txtURL;
        private TextBox txtLineCount;
        private TextBox txtWordCount;
        private TextBox txtCharCount;
        private Button btnExit;
        private RichTextBox rtbContent;
        private OpenFileDialog openFileDialog1;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
    }
}