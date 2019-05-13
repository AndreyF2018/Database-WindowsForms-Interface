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
    public partial class EditMenuForm : Form
    {
        public EditMenuForm()
        {
            InitializeComponent();
        }

        private void EditMenuBtn_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = W12-416-16; Initial Catalog = Restoran; Integrated Security = True";
            string query1 = "select max(DishID) from Dishes";
            using (SqlConnection conn = new SqlConnection(@strConn))
            {
                conn.Open();
                SqlCommand command1 = new SqlCommand(query1, conn);
                if (int.Parse(DishIDtxt.Text) <= int.Parse(command1.ExecuteScalar().ToString()))
                {

                    string query2 = "update Dishes set Price = " + PriceDishtxt.Text + ", Title = " + "'"+TitleDishtxt.Text + "'" + " where DishID = "+ DishIDtxt.Text;
                    //MessageBox.Show(query2);
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    command2.ExecuteNonQuery();
                }
                 if (int.Parse(DishIDtxt.Text) > int.Parse(command1.ExecuteScalar().ToString()))
                 {
                     string query2 = "insert into Dishes (Title, Price) values " + "(" + "'"+TitleDishtxt.Text + "'" + ", "  + PriceDishtxt.Text + ")";
                     //MessageBox.Show(query2);
                     SqlCommand command2 = new SqlCommand(query2, conn);
                     command2.ExecuteNonQuery();
                 }
            }
                

               // SqlDataReader reader = command.ExecuteReader();
              
        }




    }
}
