namespace Lab02
{
    partial class Bai03
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
            panelMouseDown = new FlowLayoutPanel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            rtbRead = new RichTextBox();
            btnRead = new Button();
            rtbCal = new RichTextBox();
            btnCal = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // panelMouseDown
            // 
            panelMouseDown.BackgroundImage = Properties.Resources.Gemini_Generated_Image_bk0hbvbk0hbvbk0h;
            panelMouseDown.BackgroundImageLayout = ImageLayout.Stretch;
            panelMouseDown.Dock = DockStyle.Top;
            panelMouseDown.Location = new Point(0, 0);
            panelMouseDown.Name = "panelMouseDown";
            panelMouseDown.Size = new Size(884, 43);
            panelMouseDown.TabIndex = 0;
            panelMouseDown.MouseDown += panelMouseDown_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(838, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(786, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(46, 34);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(734, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(46, 34);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // rtbRead
            // 
            rtbRead.BackColor = SystemColors.InactiveCaptionText;
            rtbRead.Font = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbRead.ForeColor = SystemColors.Menu;
            rtbRead.Location = new Point(257, 162);
            rtbRead.Name = "rtbRead";
            rtbRead.Size = new Size(167, 124);
            rtbRead.TabIndex = 3;
            rtbRead.Text = "";
            // 
            // btnRead
            // 
            btnRead.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnRead.BackgroundImageLayout = ImageLayout.Stretch;
            btnRead.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.ForeColor = SystemColors.ButtonHighlight;
            btnRead.Location = new Point(257, 312);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(102, 33);
            btnRead.TabIndex = 4;
            btnRead.Text = "Đọc ";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // rtbCal
            // 
            rtbCal.BackColor = SystemColors.InactiveCaptionText;
            rtbCal.Font = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbCal.ForeColor = SystemColors.Window;
            rtbCal.Location = new Point(422, 162);
            rtbCal.Name = "rtbCal";
            rtbCal.Size = new Size(207, 124);
            rtbCal.TabIndex = 5;
            rtbCal.Text = "";
            // 
            // btnCal
            // 
            btnCal.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnCal.BackgroundImageLayout = ImageLayout.Stretch;
            btnCal.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCal.ForeColor = SystemColors.ButtonHighlight;
            btnCal.Location = new Point(394, 312);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(102, 33);
            btnCal.TabIndex = 6;
            btnCal.Text = "Tính";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(527, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 33);
            btnSave.TabIndex = 7;
            btnSave.Text = "Ghi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_c9uxjjc9uxjjc9ux;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 450);
            Controls.Add(btnSave);
            Controls.Add(btnCal);
            Controls.Add(rtbCal);
            Controls.Add(btnRead);
            Controls.Add(rtbRead);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            Controls.Add(panelMouseDown);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bai03";
            Text = "Bai03";
            Load += Bai03_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelMouseDown;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private RichTextBox rtbRead;
        private Button btnRead;
        private RichTextBox rtbCal;
        private Button btnCal;
        private Button btnSave;
    }
}