namespace Lab02
{
    partial class FormNhapLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapLieu));
            bg = new PictureBox();
            picHinhAnhMonAn = new PictureBox();
            cboNguoiDongGop = new ComboBox();
            lblMaMon = new Label();
            txtIDMA = new TextBox();
            pictureBoxMouseDown = new PictureBox();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            lblTenMon = new Label();
            lblNguoiDongGop = new Label();
            tabMonAn = new TabControl();
            tabPage1 = new TabPage();
            btnLuuMonAn = new Button();
            btnChonAnh = new Button();
            txtTenMonAn = new TextBox();
            tabNguoiDung = new TabPage();
            btnLuuNguoiDung = new Button();
            lblIDNCC = new Label();
            cboQuyenHan = new ComboBox();
            txtIDNCC = new TextBox();
            lblQuyenHan = new Label();
            txtHoVaTen = new TextBox();
            lblHoVaTen = new Label();
            ((System.ComponentModel.ISupportInitialize)bg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnhMonAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMouseDown).BeginInit();
            tabMonAn.SuspendLayout();
            tabPage1.SuspendLayout();
            tabNguoiDung.SuspendLayout();
            SuspendLayout();
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
            bg.TabIndex = 0;
            bg.TabStop = false;
            // 
            // picHinhAnhMonAn
            // 
            picHinhAnhMonAn.Location = new Point(456, 12);
            picHinhAnhMonAn.Name = "picHinhAnhMonAn";
            picHinhAnhMonAn.Size = new Size(187, 179);
            picHinhAnhMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnhMonAn.TabIndex = 1;
            picHinhAnhMonAn.TabStop = false;
            // 
            // cboNguoiDongGop
            // 
            cboNguoiDongGop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNguoiDongGop.FormattingEnabled = true;
            cboNguoiDongGop.Location = new Point(189, 112);
            cboNguoiDongGop.Name = "cboNguoiDongGop";
            cboNguoiDongGop.Size = new Size(251, 30);
            cboNguoiDongGop.TabIndex = 3;
            // 
            // lblMaMon
            // 
            lblMaMon.AutoSize = true;
            lblMaMon.BackColor = Color.Transparent;
            lblMaMon.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaMon.ForeColor = Color.LightSkyBlue;
            lblMaMon.Location = new Point(6, 12);
            lblMaMon.Name = "lblMaMon";
            lblMaMon.Size = new Size(129, 24);
            lblMaMon.TabIndex = 4;
            lblMaMon.Text = "Mã Món Ăn:";
            // 
            // txtIDMA
            // 
            txtIDMA.Location = new Point(189, 12);
            txtIDMA.Name = "txtIDMA";
            txtIDMA.Size = new Size(251, 29);
            txtIDMA.TabIndex = 5;
            // 
            // pictureBoxMouseDown
            // 
            pictureBoxMouseDown.BackgroundImage = Properties.Resources.Gemini_Generated_Image_fh7sh0fh7sh0fh7s;
            pictureBoxMouseDown.Dock = DockStyle.Top;
            pictureBoxMouseDown.Location = new Point(0, 0);
            pictureBoxMouseDown.Name = "pictureBoxMouseDown";
            pictureBoxMouseDown.Size = new Size(800, 46);
            pictureBoxMouseDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMouseDown.TabIndex = 6;
            pictureBoxMouseDown.TabStop = false;
            pictureBoxMouseDown.MouseDown += pictureBoxMouseDown_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(741, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 34);
            btnClose.TabIndex = 7;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(688, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(47, 34);
            btnMaximize.TabIndex = 8;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(635, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(47, 34);
            btnMinimize.TabIndex = 9;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblTenMon
            // 
            lblTenMon.AutoSize = true;
            lblTenMon.BackColor = Color.Transparent;
            lblTenMon.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMon.ForeColor = Color.LightSkyBlue;
            lblTenMon.Location = new Point(6, 61);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Size = new Size(136, 24);
            lblTenMon.TabIndex = 10;
            lblTenMon.Text = "Tên Món Ăn:";
            // 
            // lblNguoiDongGop
            // 
            lblNguoiDongGop.AutoSize = true;
            lblNguoiDongGop.BackColor = Color.Transparent;
            lblNguoiDongGop.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNguoiDongGop.ForeColor = Color.LightSkyBlue;
            lblNguoiDongGop.Location = new Point(6, 112);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(182, 24);
            lblNguoiDongGop.TabIndex = 11;
            lblNguoiDongGop.Text = "Người Đóng Góp:";
            // 
            // tabMonAn
            // 
            tabMonAn.Controls.Add(tabPage1);
            tabMonAn.Controls.Add(tabNguoiDung);
            tabMonAn.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabMonAn.Location = new Point(78, 86);
            tabMonAn.Name = "tabMonAn";
            tabMonAn.SelectedIndex = 0;
            tabMonAn.Size = new Size(657, 239);
            tabMonAn.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(0, 0, 64);
            tabPage1.Controls.Add(btnLuuMonAn);
            tabPage1.Controls.Add(btnChonAnh);
            tabPage1.Controls.Add(txtTenMonAn);
            tabPage1.Controls.Add(lblMaMon);
            tabPage1.Controls.Add(lblTenMon);
            tabPage1.Controls.Add(picHinhAnhMonAn);
            tabPage1.Controls.Add(lblNguoiDongGop);
            tabPage1.Controls.Add(cboNguoiDongGop);
            tabPage1.Controls.Add(txtIDMA);
            tabPage1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.MidnightBlue;
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(649, 202);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Món Ăn";
            // 
            // btnLuuMonAn
            // 
            btnLuuMonAn.Font = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuMonAn.ForeColor = Color.FromArgb(0, 0, 64);
            btnLuuMonAn.Location = new Point(317, 157);
            btnLuuMonAn.Name = "btnLuuMonAn";
            btnLuuMonAn.Size = new Size(112, 34);
            btnLuuMonAn.TabIndex = 15;
            btnLuuMonAn.Text = "LƯU MÓN ĂN";
            btnLuuMonAn.UseVisualStyleBackColor = true;
            btnLuuMonAn.Click += btnLuuMonAn_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChonAnh.ForeColor = Color.FromArgb(0, 0, 64);
            btnChonAnh.Location = new Point(189, 157);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(112, 34);
            btnChonAnh.TabIndex = 14;
            btnChonAnh.Text = "Chọn ảnh...";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Location = new Point(189, 58);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(251, 29);
            txtTenMonAn.TabIndex = 12;
            // 
            // tabNguoiDung
            // 
            tabNguoiDung.Controls.Add(btnLuuNguoiDung);
            tabNguoiDung.Controls.Add(lblIDNCC);
            tabNguoiDung.Controls.Add(cboQuyenHan);
            tabNguoiDung.Controls.Add(txtIDNCC);
            tabNguoiDung.Controls.Add(lblQuyenHan);
            tabNguoiDung.Controls.Add(txtHoVaTen);
            tabNguoiDung.Controls.Add(lblHoVaTen);
            tabNguoiDung.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabNguoiDung.ForeColor = Color.FromArgb(192, 192, 255);
            tabNguoiDung.Location = new Point(4, 34);
            tabNguoiDung.Name = "tabNguoiDung";
            tabNguoiDung.Padding = new Padding(3);
            tabNguoiDung.Size = new Size(649, 201);
            tabNguoiDung.TabIndex = 1;
            tabNguoiDung.Text = "Người Dùng";
            tabNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btnLuuNguoiDung
            // 
            btnLuuNguoiDung.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuNguoiDung.ForeColor = Color.FromArgb(0, 0, 64);
            btnLuuNguoiDung.Location = new Point(476, 102);
            btnLuuNguoiDung.Name = "btnLuuNguoiDung";
            btnLuuNguoiDung.Size = new Size(167, 34);
            btnLuuNguoiDung.TabIndex = 16;
            btnLuuNguoiDung.Text = "LƯU NGƯỜI DÙNG";
            btnLuuNguoiDung.UseVisualStyleBackColor = true;
            btnLuuNguoiDung.Click += btnLuuNguoiDung_Click;
            // 
            // lblIDNCC
            // 
            lblIDNCC.AutoSize = true;
            lblIDNCC.BackColor = Color.Transparent;
            lblIDNCC.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDNCC.ForeColor = Color.FromArgb(0, 0, 64);
            lblIDNCC.Location = new Point(6, 12);
            lblIDNCC.Name = "lblIDNCC";
            lblIDNCC.Size = new Size(157, 22);
            lblIDNCC.TabIndex = 16;
            lblIDNCC.Text = "Mã Người Dùng:";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.BackColor = Color.FromArgb(192, 192, 255);
            cboQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(169, 102);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(211, 30);
            cboQuyenHan.TabIndex = 16;
            // 
            // txtIDNCC
            // 
            txtIDNCC.BackColor = Color.FromArgb(0, 0, 64);
            txtIDNCC.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIDNCC.ForeColor = SystemColors.Window;
            txtIDNCC.Location = new Point(169, 12);
            txtIDNCC.Name = "txtIDNCC";
            txtIDNCC.Size = new Size(302, 29);
            txtIDNCC.TabIndex = 16;
            // 
            // lblQuyenHan
            // 
            lblQuyenHan.AutoSize = true;
            lblQuyenHan.BackColor = Color.Transparent;
            lblQuyenHan.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuyenHan.ForeColor = Color.FromArgb(0, 0, 64);
            lblQuyenHan.Location = new Point(6, 102);
            lblQuyenHan.Name = "lblQuyenHan";
            lblQuyenHan.Size = new Size(118, 22);
            lblQuyenHan.TabIndex = 18;
            lblQuyenHan.Text = "Quyền Hạn:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BackColor = Color.FromArgb(0, 0, 64);
            txtHoVaTen.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHoVaTen.ForeColor = SystemColors.Window;
            txtHoVaTen.Location = new Point(169, 59);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(302, 29);
            txtHoVaTen.TabIndex = 19;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.BackColor = Color.Transparent;
            lblHoVaTen.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoVaTen.ForeColor = Color.FromArgb(0, 0, 64);
            lblHoVaTen.Location = new Point(6, 49);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(107, 22);
            lblHoVaTen.TabIndex = 17;
            lblHoVaTen.Text = "Họ và Tên:";
            // 
            // FormNhapLieu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tabMonAn);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            Controls.Add(pictureBoxMouseDown);
            Controls.Add(bg);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNhapLieu";
            Text = "FormNhapLieu";
            Load += FormNhapLieu_Load;
            ((System.ComponentModel.ISupportInitialize)bg).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnhMonAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMouseDown).EndInit();
            tabMonAn.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabNguoiDung.ResumeLayout(false);
            tabNguoiDung.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bg;
        private PictureBox picHinhAnhMonAn;
        private ComboBox cboNguoiDongGop;
        private Label lblMaMon;
        private TextBox txtIDMA;
        private PictureBox pictureBoxMouseDown;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Label lblTenMon;
        private Label lblNguoiDongGop;
        private TabControl tabMonAn;
        private TabPage tabPage1;
        private TabPage tabNguoiDung;
        private TextBox txtTenMonAn;
        private Button btnLuuMonAn;
        private Button btnChonAnh;
        private Label lblIDNCC;
        private Label lblQuyenHan;
        private Label lblHoVaTen;
        private ComboBox cboQuyenHan;
        private TextBox txtHoVaTen;
        private TextBox txtIDNCC;
        private Button btnLuuNguoiDung;
    }
}