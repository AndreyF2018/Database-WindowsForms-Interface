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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            
            Form new_frm = new AdminLoginForm();
            new_frm.Show();
            
            

        }

        private void VisitorBtn_Click(object sender, EventArgs e)
        {
            Form frm = new VisitorForm();
            frm.Show();
        }
    }
}
