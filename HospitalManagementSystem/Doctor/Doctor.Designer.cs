namespace Hospital_Management_System
{
    partial class Doctor
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
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            AddBtn = new Button();
            ResetBtn = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            HomeBtn = new Button();
            XBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Doctor;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1037, 143);
            label2.Name = "label2";
            label2.Size = new Size(216, 32);
            label2.TabIndex = 4;
            label2.Text = " License Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 143);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 5;
            label1.Text = "Doctor Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(506, 143);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 6;
            label3.Text = "Doctor Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 143);
            label4.Name = "label4";
            label4.Size = new Size(127, 32);
            label4.TabIndex = 7;
            label4.Text = "Doctor Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(754, 143);
            label5.Name = "label5";
            label5.Size = new Size(239, 32);
            label5.TabIndex = 8;
            label5.Text = "Year of Experience";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DeepSkyBlue;
            textBox1.Location = new Point(12, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.Location = new Point(242, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DeepSkyBlue;
            textBox3.Location = new Point(754, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DeepSkyBlue;
            textBox4.Location = new Point(1037, 202);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 31);
            textBox4.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DeepSkyBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(506, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 33);
            comboBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.DeepSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DeepSkyBlue;
            dataGridView1.Location = new Point(12, 268);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1229, 402);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(35, 702);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(115, 47);
            AddBtn.TabIndex = 15;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.Location = new Point(491, 702);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(115, 47);
            ResetBtn.TabIndex = 16;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(336, 702);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(115, 47);
            DeleteBtn.TabIndex = 17;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(186, 702);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 47);
            UpdateBtn.TabIndex = 18;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.FlatStyle = FlatStyle.Popup;
            HomeBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.Location = new Point(645, 702);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(115, 47);
            HomeBtn.TabIndex = 19;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // XBtn
            // 
            XBtn.FlatStyle = FlatStyle.Popup;
            XBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XBtn.Location = new Point(1204, 2);
            XBtn.Name = "XBtn";
            XBtn.Size = new Size(60, 47);
            XBtn.TabIndex = 20;
            XBtn.Text = "X";
            XBtn.UseVisualStyleBackColor = true;
            XBtn.Click += XBtn_Click;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1266, 783);
            Controls.Add(XBtn);
            Controls.Add(HomeBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(ResetBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor";
            Load += Doctor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button HomeBtn;
        private Button XBtn;
    }
}