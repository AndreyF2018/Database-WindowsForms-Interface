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
    public partial class VisitorForm : Form
    {
        public VisitorForm()
        {
            InitializeComponent();
        }

        private void DisountMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new DiscountMenuForm();
            frm.Show();
        }

        private void ToOrderBtn_Click(object sender, EventArgs e)
        {
            TableIDtxt.Visible = true;
            TitleDishtxt.Visible = true;
            Quantitytxt.Visible = true;
            TableIDLabel.Visible = true;
            TitleDishLabel.Visible = true;
            QuantityLabel.Visible = true;
            EnterOrderBtn.Visible = true;
        }

        private void EnterOrderBtn_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = W12-416-16; Initial Catalog = Restoran; Integrated Security = True";
            string procName = "To_order";
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand(procName, connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter OrderedTableID = new SqlParameter
                {
                    ParameterName = "@ordered_table_id",
                    Value = 1

                };

                command1.Parameters.Add(OrderedTableID);

                SqlParameter orderedTitleDish = new SqlParameter
                {
                    ParameterName = "@ordered_title_dish",
                    Value = TitleDishtxt.Text

                };
                command1.Parameters.Add(orderedTitleDish);

                SqlParameter orderedQuantity = new SqlParameter
                {
                    ParameterName = "@ordered_quantity",
                    Value = Quantitytxt.Text,
                    SqlDbType = SqlDbType.Int

                };
                command1.Parameters.Add(orderedQuantity);


                string query = "select Price from Dishes Where title = " + "'" + TitleDishtxt.Text.ToString() + "'";
                SqlCommand command2 = new SqlCommand(query, connection);
                //int price = command2.ExecuteScalar()
               
                // string result = (int.Parse(command1.Parameters["@ordered_quantity"].Value.ToString()) * int.Parse(price)).ToString();
                //SumOrdertxt.Text = result;
                MessageBox.Show("Был сделан заказ блюда " + command1.Parameters["@ordered_title_dish"].Value.ToString() + " в количестве " + command1.Parameters["@ordered_quantity"].Value.ToString());

                //command1.ExecuteNonQuery();

                // MessageBox.Show("Был уволен " + command1.Parameters["@oldest_waiter"].Value.ToString() + "-летний официант.");
            }
        }
    }
}
