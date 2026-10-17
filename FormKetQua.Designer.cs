namespace Lab02
{
    partial class FormKetQua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKetQua));
            panelMouseDown = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            lblTieuDe = new Label();
            picKetQua = new PictureBox();
            btnQuayLai = new Button();
            btnDong = new Button();
            lblTenMonAn = new Label();
            lblNguoiDongGop = new Label();
            bg = new PictureBox();
            panelMouseDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKetQua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg).BeginInit();
            SuspendLayout();
            // 
            // panelMouseDown
            // 
            panelMouseDown.BackgroundImage = Properties.Resources.Gemini_Generated_Image_fh7sh0fh7sh0fh7s2;
            panelMouseDown.Controls.Add(btnMaximize);
            panelMouseDown.Controls.Add(btnMinimize);
            panelMouseDown.Controls.Add(btnClose);
            panelMouseDown.Controls.Add(lblTieuDe);
            panelMouseDown.Dock = DockStyle.Top;
            panelMouseDown.Location = new Point(0, 0);
            panelMouseDown.Name = "panelMouseDown";
            panelMouseDown.Size = new Size(800, 39);
            panelMouseDown.TabIndex = 0;
            panelMouseDown.MouseDown += panelMouseDown_MouseDown;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(680, -1);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(45, 34);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(629, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 34);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(731, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.BackColor = Color.Transparent;
            lblTieuDe.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = SystemColors.ButtonHighlight;
            lblTieuDe.Location = new Point(270, 10);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(275, 24);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "HÔM NAY BẠN SẼ ĂN MÓN";
            // 
            // picKetQua
            // 
            picKetQua.BorderStyle = BorderStyle.Fixed3D;
            picKetQua.Location = new Point(35, 186);
            picKetQua.Name = "picKetQua";
            picKetQua.Size = new Size(277, 152);
            picKetQua.SizeMode = PictureBoxSizeMode.StretchImage;
            picKetQua.TabIndex = 2;
            picKetQua.TabStop = false;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.FromArgb(0, 0, 64);
            btnQuayLai.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.ForeColor = SystemColors.ButtonHighlight;
            btnQuayLai.Location = new Point(54, 361);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(223, 34);
            btnQuayLai.TabIndex = 3;
            btnQuayLai.Text = "🎲 Quay Lại Lần Nữa";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(0, 0, 64);
            btnDong.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.ForeColor = SystemColors.ButtonHighlight;
            btnDong.Location = new Point(629, 392);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(112, 34);
            btnDong.TabIndex = 4;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // lblTenMonAn
            // 
            lblTenMonAn.AutoSize = true;
            lblTenMonAn.BackColor = Color.FromArgb(0, 0, 64);
            lblTenMonAn.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMonAn.ForeColor = Color.FromArgb(255, 192, 255);
            lblTenMonAn.Location = new Point(12, 98);
            lblTenMonAn.Name = "lblTenMonAn";
            lblTenMonAn.Size = new Size(226, 27);
            lblTenMonAn.TabIndex = 5;
            lblTenMonAn.Text = "Phở bò / Cơm tấm..";
            // 
            // lblNguoiDongGop
            // 
            lblNguoiDongGop.AutoSize = true;
            lblNguoiDongGop.BackColor = Color.FromArgb(0, 0, 64);
            lblNguoiDongGop.Font = new Font("Tahoma", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNguoiDongGop.ForeColor = Color.FromArgb(255, 192, 255);
            lblNguoiDongGop.Location = new Point(12, 146);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(132, 19);
            lblNguoiDongGop.TabIndex = 6;
            lblNguoiDongGop.Text = "Đóng góp bởi: ...";
            // 
            // bg
            // 
            bg.BackgroundImage = (Image)resources.GetObject("bg.BackgroundImage");
            bg.BackgroundImageLayout = ImageLayout.Stretch;
            bg.Dock = DockStyle.Fill;
            bg.Location = new Point(0, 0);
            bg.Name = "bg";
            bg.Size = new Size(800, 450);
            bg.SizeMode = PictureBoxSizeMode.StretchImage;
            bg.TabIndex = 7;
            bg.TabStop = false;
            // 
            // FormKetQua
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_fh7sh0fh7sh0fh7s1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNguoiDongGop);
            Controls.Add(lblTenMonAn);
            Controls.Add(btnDong);
            Controls.Add(btnQuayLai);
            Controls.Add(picKetQua);
            Controls.Add(panelMouseDown);
            Controls.Add(bg);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKetQua";
            Text = "FormKetQua";
            Load += FormKetQua_Load;
            panelMouseDown.ResumeLayout(false);
            panelMouseDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKetQua).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMouseDown;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnClose;
        private Label lblTieuDe;
        private PictureBox picKetQua;
        private Button btnQuayLai;
        private Button btnDong;
        private Label lblTenMonAn;
        private Label lblNguoiDongGop;
        private PictureBox bg;
    }
}