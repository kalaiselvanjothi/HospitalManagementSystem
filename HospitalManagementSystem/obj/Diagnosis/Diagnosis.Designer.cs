namespace Hospital_Management_System
{
    partial class Diagnosis
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
            pictureBox5 = new PictureBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            HomeBtn = new Button();
            dataGridView3 = new DataGridView();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Diagnosis;
            pictureBox5.Location = new Point(1, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 97);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(163, 32);
            label4.TabIndex = 9;
            label4.Text = "Diagnosis Id";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DeepSkyBlue;
            textBox1.Location = new Point(227, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 31);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 200);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 12;
            label1.Text = "Patient Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 257);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 13;
            label2.Text = "Patient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 312);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 14;
            label3.Text = "Symptoms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 372);
            label5.Name = "label5";
            label5.Size = new Size(193, 32);
            label5.TabIndex = 15;
            label5.Text = "Diagnostic Test";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 427);
            label6.Name = "label6";
            label6.Size = new Size(135, 32);
            label6.TabIndex = 16;
            label6.Text = "Medicines";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DeepSkyBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 33);
            comboBox1.TabIndex = 21;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.Location = new Point(227, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 31);
            textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DeepSkyBlue;
            textBox3.Location = new Point(227, 315);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 31);
            textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DeepSkyBlue;
            textBox4.Location = new Point(227, 375);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 31);
            textBox4.TabIndex = 25;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(22, 487);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(115, 47);
            AddBtn.TabIndex = 26;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(161, 487);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 47);
            UpdateBtn.TabIndex = 27;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(303, 487);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(115, 47);
            DeleteBtn.TabIndex = 28;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.Location = new Point(440, 487);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(115, 47);
            ResetBtn.TabIndex = 29;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.FlatStyle = FlatStyle.Popup;
            HomeBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.Location = new Point(581, 487);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(115, 47);
            HomeBtn.TabIndex = 30;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.BackgroundColor = Color.DeepSkyBlue;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.GridColor = Color.DeepSkyBlue;
            dataGridView3.Location = new Point(22, 551);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(1179, 371);
            dataGridView3.TabIndex = 31;
            dataGridView3.DoubleClick += dataGridView3_DoubleClick;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DeepSkyBlue;
            textBox5.Location = new Point(227, 427);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 31);
            textBox5.TabIndex = 32;
            // 
            // Diagnosis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1244, 944);
            Controls.Add(textBox5);
            Controls.Add(dataGridView3);
            Controls.Add(HomeBtn);
            Controls.Add(ResetBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diagnosis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diagnosis";
            Load += Diagnosis_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ResetBtn;
        private Button HomeBtn;
        private DataGridView dataGridView3;
        private TextBox textBox5;
    }
}