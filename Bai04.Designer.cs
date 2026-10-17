namespace Lab02
{
    partial class Bai04
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
            btnWriteFile = new Button();
            txtName = new TextBox();
            txtID = new TextBox();
            txtPhone = new TextBox();
            txtCourse1 = new TextBox();
            txtCourse2 = new TextBox();
            txtCourse3 = new TextBox();
            txtAverage = new TextBox();
            btnReadFile = new Button();
            btnAdd = new Button();
            btnBack = new Button();
            btnNext = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNameRead = new TextBox();
            txtIDRead = new TextBox();
            txtPhoneRead = new TextBox();
            txtCourse1Read = new TextBox();
            txtCourse2Read = new TextBox();
            txtCourse3Read = new TextBox();
            txtAverageRead = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            rtbDisplay = new RichTextBox();
            lblPageIndicator = new Label();
            panelMouseDown.SuspendLayout();
            SuspendLayout();
            // 
            // panelMouseDown
            // 
            panelMouseDown.BackgroundImage = Properties.Resources.Gemini_Generated_Image_ti9b0lti9b0lti9b;
            panelMouseDown.BackgroundImageLayout = ImageLayout.Stretch;
            panelMouseDown.Controls.Add(btnMinimize);
            panelMouseDown.Controls.Add(btnMaximize);
            panelMouseDown.Controls.Add(btnClose);
            panelMouseDown.Dock = DockStyle.Top;
            panelMouseDown.Location = new Point(0, 0);
            panelMouseDown.Name = "panelMouseDown";
            panelMouseDown.Size = new Size(1177, 37);
            panelMouseDown.TabIndex = 0;
            panelMouseDown.MouseDown += panelMouseDown_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(1039, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(42, 34);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(1087, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(42, 34);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(1135, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnWriteFile.BackgroundImageLayout = ImageLayout.Stretch;
            btnWriteFile.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWriteFile.ForeColor = SystemColors.ButtonHighlight;
            btnWriteFile.Location = new Point(150, 45);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(199, 40);
            btnWriteFile.TabIndex = 1;
            btnWriteFile.Text = "Write to a File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 99);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 31);
            txtName.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(21, 151);
            txtID.Name = "txtID";
            txtID.Size = new Size(278, 31);
            txtID.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(21, 203);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 31);
            txtPhone.TabIndex = 4;
            // 
            // txtCourse1
            // 
            txtCourse1.Location = new Point(21, 251);
            txtCourse1.Name = "txtCourse1";
            txtCourse1.Size = new Size(278, 31);
            txtCourse1.TabIndex = 5;
            // 
            // txtCourse2
            // 
            txtCourse2.Location = new Point(21, 300);
            txtCourse2.Name = "txtCourse2";
            txtCourse2.Size = new Size(278, 31);
            txtCourse2.TabIndex = 6;
            // 
            // txtCourse3
            // 
            txtCourse3.Location = new Point(21, 349);
            txtCourse3.Name = "txtCourse3";
            txtCourse3.Size = new Size(278, 31);
            txtCourse3.TabIndex = 7;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(21, 401);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(278, 31);
            txtAverage.TabIndex = 8;
            // 
            // btnReadFile
            // 
            btnReadFile.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnReadFile.BackgroundImageLayout = ImageLayout.Stretch;
            btnReadFile.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadFile.ForeColor = SystemColors.ButtonHighlight;
            btnReadFile.Location = new Point(805, 45);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(295, 40);
            btnReadFile.TabIndex = 9;
            btnReadFile.Text = "Button to read a File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(190, 447);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 50);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(805, 447);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(122, 50);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = Properties.Resources.Gemini_Generated_Image_4r3c3x4r3c3x4r3c;
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(994, 447);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(122, 50);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(365, 106);
            label1.Name = "label1";
            label1.Size = new Size(68, 24);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(365, 154);
            label2.Name = "label2";
            label2.Size = new Size(35, 24);
            label2.TabIndex = 14;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(365, 210);
            label3.Name = "label3";
            label3.Size = new Size(73, 24);
            label3.TabIndex = 15;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(365, 258);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 16;
            label4.Text = "Course 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(365, 307);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 17;
            label5.Text = "Course 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(365, 356);
            label6.Name = "label6";
            label6.Size = new Size(98, 24);
            label6.TabIndex = 18;
            label6.Text = "Course 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(365, 408);
            label7.Name = "label7";
            label7.Size = new Size(94, 24);
            label7.TabIndex = 19;
            label7.Text = "Average";
            // 
            // txtNameRead
            // 
            txtNameRead.Location = new Point(854, 106);
            txtNameRead.Name = "txtNameRead";
            txtNameRead.ReadOnly = true;
            txtNameRead.Size = new Size(150, 31);
            txtNameRead.TabIndex = 20;
            // 
            // txtIDRead
            // 
            txtIDRead.Location = new Point(854, 154);
            txtIDRead.Name = "txtIDRead";
            txtIDRead.ReadOnly = true;
            txtIDRead.Size = new Size(150, 31);
            txtIDRead.TabIndex = 21;
            // 
            // txtPhoneRead
            // 
            txtPhoneRead.Location = new Point(854, 203);
            txtPhoneRead.Name = "txtPhoneRead";
            txtPhoneRead.ReadOnly = true;
            txtPhoneRead.Size = new Size(150, 31);
            txtPhoneRead.TabIndex = 22;
            // 
            // txtCourse1Read
            // 
            txtCourse1Read.Location = new Point(854, 251);
            txtCourse1Read.Name = "txtCourse1Read";
            txtCourse1Read.ReadOnly = true;
            txtCourse1Read.Size = new Size(150, 31);
            txtCourse1Read.TabIndex = 23;
            // 
            // txtCourse2Read
            // 
            txtCourse2Read.Location = new Point(854, 300);
            txtCourse2Read.Name = "txtCourse2Read";
            txtCourse2Read.ReadOnly = true;
            txtCourse2Read.Size = new Size(150, 31);
            txtCourse2Read.TabIndex = 24;
            // 
            // txtCourse3Read
            // 
            txtCourse3Read.Location = new Point(854, 353);
            txtCourse3Read.Name = "txtCourse3Read";
            txtCourse3Read.ReadOnly = true;
            txtCourse3Read.Size = new Size(150, 31);
            txtCourse3Read.TabIndex = 25;
            // 
            // txtAverageRead
            // 
            txtAverageRead.Location = new Point(854, 401);
            txtAverageRead.Name = "txtAverageRead";
            txtAverageRead.ReadOnly = true;
            txtAverageRead.Size = new Size(150, 31);
            txtAverageRead.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(1048, 113);
            label8.Name = "label8";
            label8.Size = new Size(68, 24);
            label8.TabIndex = 27;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(1048, 157);
            label9.Name = "label9";
            label9.Size = new Size(35, 24);
            label9.TabIndex = 28;
            label9.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(1048, 206);
            label10.Name = "label10";
            label10.Size = new Size(73, 24);
            label10.TabIndex = 29;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(1048, 258);
            label11.Name = "label11";
            label11.Size = new Size(98, 24);
            label11.TabIndex = 30;
            label11.Text = "Course 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(1048, 307);
            label12.Name = "label12";
            label12.Size = new Size(98, 24);
            label12.TabIndex = 31;
            label12.Text = "Course 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(1048, 360);
            label13.Name = "label13";
            label13.Size = new Size(98, 24);
            label13.TabIndex = 32;
            label13.Text = "Course 3";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(1052, 408);
            label14.Name = "label14";
            label14.Size = new Size(94, 24);
            label14.TabIndex = 33;
            label14.Text = "Average";
            // 
            // rtbDisplay
            // 
            rtbDisplay.BackColor = SystemColors.InactiveCaptionText;
            rtbDisplay.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbDisplay.ForeColor = SystemColors.InactiveBorder;
            rtbDisplay.Location = new Point(513, 99);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.Size = new Size(313, 333);
            rtbDisplay.TabIndex = 34;
            rtbDisplay.Text = "";
            // 
            // lblPageIndicator
            // 
            lblPageIndicator.AutoSize = true;
            lblPageIndicator.BackColor = Color.Transparent;
            lblPageIndicator.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageIndicator.ForeColor = SystemColors.ButtonHighlight;
            lblPageIndicator.Location = new Point(949, 459);
            lblPageIndicator.Name = "lblPageIndicator";
            lblPageIndicator.Size = new Size(23, 24);
            lblPageIndicator.TabIndex = 35;
            lblPageIndicator.Text = "1";
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_bk0hbvbk0hbvbk0h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1177, 509);
            Controls.Add(lblPageIndicator);
            Controls.Add(rtbDisplay);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtAverageRead);
            Controls.Add(txtCourse3Read);
            Controls.Add(txtCourse2Read);
            Controls.Add(txtCourse1Read);
            Controls.Add(txtPhoneRead);
            Controls.Add(txtIDRead);
            Controls.Add(txtNameRead);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(btnReadFile);
            Controls.Add(txtAverage);
            Controls.Add(txtCourse3);
            Controls.Add(txtCourse2);
            Controls.Add(txtCourse1);
            Controls.Add(txtPhone);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(btnWriteFile);
            Controls.Add(panelMouseDown);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bai04";
            Text = "Bai04";
            panelMouseDown.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMouseDown;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Button btnWriteFile;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtPhone;
        private TextBox txtCourse1;
        private TextBox txtCourse2;
        private TextBox txtCourse3;
        private TextBox txtAverage;
        private Button btnReadFile;
        private Button btnAdd;
        private Button btnBack;
        private Button btnNext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNameRead;
        private TextBox txtIDRead;
        private TextBox txtPhoneRead;
        private TextBox txtCourse1Read;
        private TextBox txtCourse2Read;
        private TextBox txtCourse3Read;
        private TextBox txtAverageRead;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private RichTextBox rtbDisplay;
        private Label lblPageIndicator;
    }
}