using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (Form1.users.ValidatePassword(txtLogin.Text,txtPassword.Text))
            {
                if(Form1.users.GetGrauUser(txtLogin.Text) == 0)
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    new Form3().Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("The Username or password you entered is incorrect, try again");
                txtLogin.Clear();
                txtPassword.Clear();
                txtLogin.Focus();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
            txtLogin.Focus();
        }

        private void bt_RegisterUser_Click(object sender, EventArgs e)
        {
            new RegisterUser().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
