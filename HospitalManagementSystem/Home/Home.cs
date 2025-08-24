using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();

        }

        private void XBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {


            Doctor doctorForm = new Doctor();
            doctorForm.Show();
            this.Hide();

        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void DiagnosisBtn_Click(object sender, EventArgs e)
        {
            Diagnosis obj= new Diagnosis();
            obj.Show();
            this.Hide();
        }
    }
}
