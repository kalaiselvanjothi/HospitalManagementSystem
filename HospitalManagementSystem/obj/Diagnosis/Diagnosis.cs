using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
            DisplayDiagnosis();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kalai\OneDrive\Documents\Hospital_Management_System.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDiagnosis()
        {
            try
            {
                Con.Open();
                string Query = "Select * FROM Diagnosis";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        void DisplayPatientId()
        {
            string sql = "Select*From Patient";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "PId";
                comboBox1.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Please fill in all the required fields");
                }
                else
                {

                    Con.Open();


                    string Query = "UPDATE Diagnosis SET PatientName=@PatientName, PatientId=@PatientId,Symtoms=@Symptoms,DiagnosticTest=@DiagnosticTest,Medicines=@Medicines WHERE DId=@DId";

                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.Parameters.AddWithValue("@DId", textBox1.Text);
                    cmd.Parameters.AddWithValue("@PatientName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@PatientId", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", textBox3.Text);
                    cmd.Parameters.AddWithValue("@DiagnosticTest", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Medicines", textBox5.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the provided Diagnosis ID");
                    }
                    DisplayDiagnosis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || comboBox1.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string Query = "INSERT INTO Diagnosis VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    DisplayDiagnosis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                textBox5.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            DisplayPatientId();
        }
        string pname;
        private void DisplayPatientName()
        {

            {
                try
                {
                    Con.Open();
                    string ss = "Select * From Patient where PId = " + comboBox1.SelectedValue.ToString();
                    SqlCommand cmd = new SqlCommand(ss, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        pname = dr["PName"].ToString();
                        textBox2.Text = pname;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplayPatientName();
        }
    }

}
