using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectoop
{
    public partial class orderlist : Form
    {

       // SqlDataAdapter adapt;
        //DataTable dt;
        SqlConnection conn = null;
        SqlCommand cmd;
        int selectedRow;

        public orderlist()
        {
            InitializeComponent();
        }

        private void orderlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectoopDataSet3.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.projectoopDataSet3.order);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                selectedRow = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(selectedRow);
                conn.Open();
              //  String name = txtsearchinfo.Text.ToString();
             //   String qry = "delete from Tabinfo where tbname='" + name + "'";
              //  SqlCommand sc = new SqlCommand(qry, conn);
                
                    MessageBox.Show(" Deleted Successfully : ");
             
                //button1_Click(sender, e);
                //show();
                //con.Close();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }
        }
    }
}
