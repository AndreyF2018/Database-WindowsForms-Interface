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
    public partial class DiscountMenuForm : Form
    {
        public DiscountMenuForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string strConn = @"Data Source = W12-416-16; Initial Catalog = Restoran; Integrated Security = True";
            string sqlExpression = "select Title, Price, Discount, Real_price from Discounts_view ";

            using (SqlConnection conn = new SqlConnection(@strConn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, conn);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
                foreach (string[] s in data)
                {
                    DiscountMenuDgv.Rows.Add(s);
                }

                reader.Close();
                conn.Close();
            }
        }
    }
}
