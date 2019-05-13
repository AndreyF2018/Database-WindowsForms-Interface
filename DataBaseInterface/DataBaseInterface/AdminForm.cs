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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdmMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new MenuForm();
            frm.Show();

        }

        private void EditMenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new EditMenuForm();
            frm.Show();
        }

        private void SumDeliveriesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new SumOfDeliviresForm();
            frm.Show();
        }

        private void CompleteOrderBtn_Click(object sender, EventArgs e)
        {
            OrderIDtxt.Visible = true;
            OrderIDLabel.Visible = true;
            FulfillmentOrderBtn.Visible = true;
        }

        private void FulfillmentOrderBtn_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = W12-416-16; Initial Catalog = Restoran; Integrated Security = True";
            string procName = "Fulfillment_of_an_order";
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(procName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter execOrderID = new SqlParameter
                {
                    ParameterName = "@exec_orderID",
                    Value = OrderIDtxt.Text

                };
                command.Parameters.Add(execOrderID);
                command.ExecuteNonQuery();
            }
        }

        private void DismissalBtn_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = W12-416-16; Initial Catalog = Restoran; Integrated Security = True";
            string procName = "Dismissal_waiter";
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(procName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter oldestWaiter = new SqlParameter
                {
                    ParameterName = "@oldest_waiter",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output

                };
                command.Parameters.Add(oldestWaiter);
                command.ExecuteNonQuery();
                MessageBox.Show("Был уволен " + command.Parameters["@oldest_waiter"].Value.ToString() + "-летний официант.");
            }
        }

        private void WarehouseControlBtn_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = W12-416-16; Initial Catalog = Restoran; Integrated Security = True";
            string procName = "warehouse_control";
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(procName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                MessageBox.Show("Просроченные продукты были удалены со склада");
            }
        }
    }
}
