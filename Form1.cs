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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "1111" && txtUserPassword.Text == "1111")
            {
                this.Hide();
                new RegistrationForm().Show();
            }
            else
            {
                MessageBox.Show("Incorrect login or password!");
                txtUserName.Clear();
                txtUserPassword.Clear();
                txtUserName.Focus();
            }
        }
    }
}
