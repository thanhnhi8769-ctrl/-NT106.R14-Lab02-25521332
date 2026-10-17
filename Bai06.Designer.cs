namespace Lab02
{
    partial class Bai06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai06));
            bg = new PictureBox();
            btnClose = new Button();
            btnMinimize = new Button();
            btnMaximize = new Button();
            pictureMouseDown = new PictureBox();
            btnThem = new Button();
            lvDanhSachMonAn = new ListView();
            label2 = new Label();
            btnXoa = new Button();
            btnThoat = new Button();
            btnTimMonNgauNhien = new Button();
            ((System.ComponentModel.ISupportInitialize)bg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureMouseDown).BeginInit();
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
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(740, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(632, 1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(48, 34);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(686, 1);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(48, 34);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // pictureMouseDown
            // 
            pictureMouseDown.BackgroundImage = (Image)resources.GetObject("pictureMouseDown.BackgroundImage");
            pictureMouseDown.Dock = DockStyle.Top;
            pictureMouseDown.Location = new Point(0, 0);
            pictureMouseDown.Name = "pictureMouseDown";
            pictureMouseDown.Size = new Size(800, 37);
            pictureMouseDown.TabIndex = 4;
            pictureMouseDown.TabStop = false;
            pictureMouseDown.MouseDown += pictureMouseDown_MouseDown;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 192, 255);
            btnThem.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(650, 72);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 53);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lvDanhSachMonAn
            // 
            lvDanhSachMonAn.BackColor = Color.FromArgb(192, 192, 255);
            lvDanhSachMonAn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvDanhSachMonAn.Location = new Point(129, 254);
            lvDanhSachMonAn.Name = "lvDanhSachMonAn";
            lvDanhSachMonAn.Size = new Size(551, 156);
            lvDanhSachMonAn.TabIndex = 7;
            lvDanhSachMonAn.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(243, 3);
            label2.Name = "label2";
            label2.Size = new Size(328, 29);
            label2.TabIndex = 8;
            label2.Text = "Danh sách món ăn hiện tại";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 192, 255);
            btnXoa.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(650, 131);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 53);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 192, 255);
            btnThoat.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(650, 190);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 53);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimMonNgauNhien
            // 
            btnTimMonNgauNhien.BackColor = Color.FromArgb(192, 192, 255);
            btnTimMonNgauNhien.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimMonNgauNhien.ForeColor = SystemColors.ButtonHighlight;
            btnTimMonNgauNhien.Location = new Point(34, 66);
            btnTimMonNgauNhien.Name = "btnTimMonNgauNhien";
            btnTimMonNgauNhien.Size = new Size(112, 182);
            btnTimMonNgauNhien.TabIndex = 11;
            btnTimMonNgauNhien.Text = "     🎲       TÌM MÓN ĂN NGẪU NHIÊN";
            btnTimMonNgauNhien.UseVisualStyleBackColor = false;
            btnTimMonNgauNhien.Click += btnTimMonNgauNhien_Click;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_h65hohh65hohh65h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTimMonNgauNhien);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(label2);
            Controls.Add(lvDanhSachMonAn);
            Controls.Add(btnThem);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(pictureMouseDown);
            Controls.Add(bg);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bai06";
            Text = "Bai06";
            Load += Bai06_Load;
            ((System.ComponentModel.ISupportInitialize)bg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureMouseDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private PictureBox pictureMouseDown;
        private Button btnThem;
        private ListView lvDanhSachMonAn;
        private Label label2;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnTimMonNgauNhien;
    }
}