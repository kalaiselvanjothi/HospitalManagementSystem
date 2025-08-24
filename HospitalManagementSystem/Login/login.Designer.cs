namespace Hospital_Management_System
{
    partial class login
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Admin = new RichTextBox();
            label3 = new Label();
            Password = new RichTextBox();
            LoginBtn = new Button();
            ClearBtn = new Button();
            XBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 22);
            label1.Name = "label1";
            label1.Size = new Size(508, 32);
            label1.TabIndex = 0;
            label1.Text = "HOSPITAL  MANAGEMENT  SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hospital_logo;
            pictureBox1.Location = new Point(185, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 293);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 2;
            label2.Text = "Admin";
            label2.Click += label2_Click;
            // 
            // Admin
            // 
            Admin.BackColor = Color.DeepSkyBlue;
            Admin.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin.Location = new Point(185, 278);
            Admin.Name = "Admin";
            Admin.Size = new Size(439, 50);
            Admin.TabIndex = 3;
            Admin.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 381);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // Password
            // 
            Password.BackColor = Color.DeepSkyBlue;
            Password.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(185, 368);
            Password.Name = "Password";
            Password.Size = new Size(439, 50);
            Password.TabIndex = 5;
            Password.Text = "";
            Password.TextChanged += Password_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(185, 484);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(115, 47);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.FlatStyle = FlatStyle.Popup;
            ClearBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.Location = new Point(357, 484);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(115, 47);
            ClearBtn.TabIndex = 7;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // XBtn
            // 
            XBtn.FlatStyle = FlatStyle.Popup;
            XBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XBtn.Location = new Point(689, 1);
            XBtn.Name = "XBtn";
            XBtn.Size = new Size(60, 47);
            XBtn.TabIndex = 8;
            XBtn.Text = "X";
            XBtn.UseVisualStyleBackColor = true;
            XBtn.Click += XBtn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(750, 609);
            Controls.Add(XBtn);
            Controls.Add(ClearBtn);
            Controls.Add(LoginBtn);
            Controls.Add(Password);
            Controls.Add(label3);
            Controls.Add(Admin);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private RichTextBox Admin;
        private Label label3;
        private RichTextBox Password;
        private Button LoginBtn;
        private Button ClearBtn;
        private Button XBtn;
    }
}
