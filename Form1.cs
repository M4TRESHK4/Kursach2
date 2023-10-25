using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "1111" && txtUserPassword.Text == "1111")
            {
                this.Hide();
                new MainMenu().Show();
            }
            else
            {
                MessageBox.Show("Incorrect login or password!");
                txtUserName.Clear();
                txtUserPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void createAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrationForm().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void clearFieldsLogLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserName.Clear();
            txtUserPassword.Clear();
            txtUserName.Focus();
        }
    }
}
