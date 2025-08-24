namespace Hospital_Management_System
{
    partial class Home
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
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            DoctorBtn = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            PatientBtn = new Button();
            DiagnosisBtn = new Button();
            LogoutBtn = new Button();
            XBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Home1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Doctor;
            pictureBox3.Location = new Point(329, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Patient;
            pictureBox2.Location = new Point(329, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // DoctorBtn
            // 
            DoctorBtn.FlatStyle = FlatStyle.Popup;
            DoctorBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorBtn.Location = new Point(590, 96);
            DoctorBtn.Name = "DoctorBtn";
            DoctorBtn.Size = new Size(200, 61);
            DoctorBtn.TabIndex = 4;
            DoctorBtn.Text = "Doctor";
            DoctorBtn.UseVisualStyleBackColor = true;
            DoctorBtn.Click += DoctorBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logout;
            pictureBox4.Location = new Point(329, 540);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 97);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Diagnosis;
            pictureBox5.Location = new Point(329, 386);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 97);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // PatientBtn
            // 
            PatientBtn.FlatStyle = FlatStyle.Popup;
            PatientBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientBtn.Location = new Point(590, 257);
            PatientBtn.Name = "PatientBtn";
            PatientBtn.Size = new Size(200, 61);
            PatientBtn.TabIndex = 7;
            PatientBtn.Text = "Patient";
            PatientBtn.UseVisualStyleBackColor = true;
            PatientBtn.Click += PatientBtn_Click;
            // 
            // DiagnosisBtn
            // 
            DiagnosisBtn.FlatStyle = FlatStyle.Popup;
            DiagnosisBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiagnosisBtn.Location = new Point(590, 411);
            DiagnosisBtn.Name = "DiagnosisBtn";
            DiagnosisBtn.Size = new Size(200, 61);
            DiagnosisBtn.TabIndex = 8;
            DiagnosisBtn.Text = "Diagnosis";
            DiagnosisBtn.UseVisualStyleBackColor = true;
            DiagnosisBtn.Click += DiagnosisBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.FlatStyle = FlatStyle.Popup;
            LogoutBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.Location = new Point(590, 566);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(200, 61);
            LogoutBtn.TabIndex = 9;
            LogoutBtn.Text = "Log out";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // XBtn
            // 
            XBtn.FlatStyle = FlatStyle.Popup;
            XBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XBtn.Location = new Point(1117, 2);
            XBtn.Name = "XBtn";
            XBtn.Size = new Size(60, 47);
            XBtn.TabIndex = 10;
            XBtn.Text = "X";
            XBtn.UseVisualStyleBackColor = true;
            XBtn.Click += XBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1107, 736);
            Controls.Add(XBtn);
            Controls.Add(LogoutBtn);
            Controls.Add(DiagnosisBtn);
            Controls.Add(PatientBtn);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(DoctorBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button DoctorBtn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button PatientBtn;
        private Button DiagnosisBtn;
        private Button LogoutBtn;
        private Button XBtn;
    }
}