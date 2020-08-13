using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Web.Script.Serialization;

namespace logInSignUpDesktop
{
    public partial class Form1 : Form
    {
        public string emailLogIn, passLogIn;
        string apiUrl = "";
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals("Email"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Email";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Email" || txtPassword.Text == "Password")
            {
                DialogResult res = MessageBox.Show("Please Enter a Valid Email/Password!", "Invalid Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                logInInformation();
                this.Hide();
                userProfile f3 = new userProfile();
                f3.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm f2 = new signUpForm();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void logInInformation()
        {
            emailLogIn = txtUsername.Text;
            passLogIn = txtPassword.Text;
            //Console.WriteLine(emailLogIn);
         
        }
    }
}
