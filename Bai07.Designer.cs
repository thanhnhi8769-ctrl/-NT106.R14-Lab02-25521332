namespace Lab02
{
    partial class Bai07
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai07));
            button1 = new Button();
            splitContainer1 = new SplitContainer();
            tvFolderBrowser = new TreeView();
            imageListIcons = new ImageList(components);
            lblTitle = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            rtbFileContent = new RichTextBox();
            picFileContent = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelbotton = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFileContent).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(800, 450);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvFolderBrowser);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.Gemini_Generated_Gif_hzxrr9hzxrr9hzxr1;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(panelbotton);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Panel2.Controls.Add(btnMinimize);
            splitContainer1.Panel2.Controls.Add(btnMaximize);
            splitContainer1.Panel2.Controls.Add(btnClose);
            splitContainer1.Panel2.Controls.Add(rtbFileContent);
            splitContainer1.Panel2.Controls.Add(picFileContent);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 3;
            // 
            // tvFolderBrowser
            // 
            tvFolderBrowser.BackColor = Color.Black;
            tvFolderBrowser.Dock = DockStyle.Fill;
            tvFolderBrowser.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tvFolderBrowser.ForeColor = SystemColors.Menu;
            tvFolderBrowser.ImageIndex = 0;
            tvFolderBrowser.ImageList = imageListIcons;
            tvFolderBrowser.Location = new Point(0, 0);
            tvFolderBrowser.Name = "tvFolderBrowser";
            tvFolderBrowser.SelectedImageIndex = 0;
            tvFolderBrowser.Size = new Size(266, 450);
            tvFolderBrowser.TabIndex = 4;
            tvFolderBrowser.AfterSelect += tvFolderBrowser_AfterSelect;
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = ColorDepth.Depth4Bit;
            imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
            imageListIcons.TransparentColor = Color.Transparent;
            imageListIcons.Images.SetKeyName(0, "Gemini_Generated_Image_a4qxuea4qxuea4qx.png");
            imageListIcons.Images.SetKeyName(1, "Gemini_Generated_Image_a4qxuea4qxuea4qx (1).png");
            imageListIcons.Images.SetKeyName(2, "Gemini_Generated_Image_a4qxuea4qxuea4qx (2).png");
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(73, 64);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "File Content";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(371, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 35);
            btnMinimize.TabIndex = 5;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(422, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(45, 35);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(473, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 35);
            btnClose.TabIndex = 3;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // rtbFileContent
            // 
            rtbFileContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbFileContent.Location = new Point(113, 97);
            rtbFileContent.Name = "rtbFileContent";
            rtbFileContent.Size = new Size(289, 261);
            rtbFileContent.TabIndex = 2;
            rtbFileContent.Text = "";
            rtbFileContent.Visible = false;
            // 
            // picFileContent
            // 
            picFileContent.Location = new Point(113, 97);
            picFileContent.Name = "picFileContent";
            picFileContent.Size = new Size(314, 261);
            picFileContent.SizeMode = PictureBoxSizeMode.Zoom;
            picFileContent.TabIndex = 1;
            picFileContent.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.Gemini_Generated_Image_ttuthrttuthrttut1;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(530, 61);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.MouseDown += flowLayoutPanel1_MouseDown;
            // 
            // panelbotton
            // 
            panelbotton.BackgroundImage = Properties.Resources.Gemini_Generated_Image_ttuthrttuthrttut;
            panelbotton.BackgroundImageLayout = ImageLayout.Stretch;
            panelbotton.Dock = DockStyle.Bottom;
            panelbotton.Location = new Point(0, 403);
            panelbotton.Name = "panelbotton";
            panelbotton.Size = new Size(530, 47);
            panelbotton.TabIndex = 7;
            // 
            // Bai07
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bai07";
            Text = "Bai07";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFileContent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private SplitContainer splitContainer1;
        private TreeView tvFolderBrowser;
        private Label lblTitle;
        private RichTextBox rtbFileContent;
        private PictureBox picFileContent;
        private ImageList imageListIcons;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelbotton;
    }
}