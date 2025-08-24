namespace Hospital_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Admin.Text = " ";
            Password.Text = " ";
        }

        private void XBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Admin.Text == " " && Password.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Admin.Text == "Admin" && Password.Text == "Password")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show(" Please Enter Your Correct Username And Password ");
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
