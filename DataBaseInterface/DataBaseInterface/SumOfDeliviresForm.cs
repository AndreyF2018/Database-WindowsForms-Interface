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
    public partial class SumOfDeliviresForm : Form
    {
        public SumOfDeliviresForm()
        {
            InitializeComponent();
        }

        private void SumOfDeliveriesBtn_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = W12-416-16; Initial Catalog = Restoran; Integrated Security = True";
            string procName = "Delivery_amount";
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(procName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                
                SqlParameter firstDate = new SqlParameter
                {
                    ParameterName = "@first_date", 
                    Value = FirstDatetxt.Text

                };
                command.Parameters.Add(firstDate);
                SqlParameter secondDate = new SqlParameter
                {
                    ParameterName = "@second_date",
                    Value = SecondDatetxt.Text

                };
                command.Parameters.Add(secondDate);
                SqlParameter sum = new SqlParameter
                {
                    ParameterName = "@sum",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output

                };
                command.Parameters.Add(sum);
                command.ExecuteNonQuery();            
                SumOfDeliveirestxt.Text = command.Parameters["@sum"].Value.ToString();
            }
        }
    }
}
