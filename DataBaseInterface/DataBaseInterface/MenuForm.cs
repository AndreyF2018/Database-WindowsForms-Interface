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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            
            string strConn = @"Data Source = W12-416-16; Initial Catalog = Restoran; Integrated Security = True";
            string sqlExpression = "select * from Dishes";

            using (SqlConnection conn = new SqlConnection(@strConn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, conn);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                }
                foreach (string[] s in data)
                {
                    MenuDgv.Rows.Add(s);
                }

                reader.Close();
                conn.Close();
            }
        }

    }
}
