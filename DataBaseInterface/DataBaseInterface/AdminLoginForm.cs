using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseInterface
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            //CheckPass(PassTextBox.Text);
        }

        private bool IsCorrectPass(string inputPass)
        {
            if (inputPass == "mypassword")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PassTextBox.PasswordChar = '*';
            bool checkpass = IsCorrectPass(PassTextBox.Text);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (checkpass)
                {
                    this.Close();
                    Form frm = new AdminForm();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool checkpass = IsCorrectPass(PassTextBox.Text);
            if (checkpass)
            {
                this.Close();
                Form frm = new AdminForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }

        }

    }
}
