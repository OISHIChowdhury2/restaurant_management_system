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
    public partial class Form3 : Form
    {
      SqlConnection conn =new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");

      SqlDataAdapter adapt;
        DataTable dt;
      //  SqlConnection conn = null;
       // SqlCommand cmd;
       
        int id = 0;

        

        public Form3()
        {
            InitializeComponent();
         
        }
        private void UserInfo_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            txtpass.Text = txttname.Text = textBox2.Text = textBox3.Text="";
           
        
        }
 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //string id = dataGridView1.Rows[e.RowIndex].Cells["dgvID"].Value.ToString();
            //this.LoadDepartment(id);

            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txttname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

       

        

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
        }

       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void selection()
        {
            if (txttname.Text != "")
            {
                txttname.Text = "";
            }
        }

        private void txttname_Enter(object sender, EventArgs e)
        {
            selection();
        }

        private void selection1()
        {
            if (txtpass.Text != "")
            {
                txtpass.Text = "";
            }
        }
       
   
        private void selection11()
        {
            if (txttname.Text == "")
            {
                txttname.Text = "Table_Name";
            }
        }
        private void txttname_Leave(object sender, EventArgs e)
        {
            selection11();
        }
        private void selection12()
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
            }
        }
       
       

        private void btnprofile_Click(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectoopDataSet1.feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.projectoopDataSet1.feedback);
            // TODO: This line of code loads data into the 'projectoopDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.projectoopDataSet.inventory);

        }

        private void btnlogout_MouseHover(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.Blue;
        }

        private void btnlogout_MouseLeave(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.Maroon;

        }

      
        //save
        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txttname.Text != null)
          {
             
                   // conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
                    conn.Open();
                    string query = "insert into Tabinfo(tbname,[pwd]) "
                        + "VALUES('" + txttname.Text + "','" + txtpass.Text + "')";
                    //string s = "Username is" + uname+".";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Succecfully add table");
                
                    conn.Close();
                    this.Initialize();
               
            }
            else
            {
                //btnadd.Enabled = false;
                MessageBox.Show("enter the values");

            }
        }
        //serch 
        private void btnsearchinfo_Click(object sender, EventArgs e)
        {
           // conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
            conn.Open();
            adapt = new SqlDataAdapter("select * from Tabinfo", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txtsearchinfo_TextChanged(object sender, EventArgs e)
        {
          //  conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
            conn.Open();
            adapt = new SqlDataAdapter("select * from Tabinfo where tbname like '" + txtsearchinfo.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        //delete

        public void disp()
        {
            
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tabinfo ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
        private void btndeletinfo_Click(object sender, EventArgs e)
        {
              string na = txttname.Text;
                string pwd = txtpass.Text;
                if (na != null)
                {

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Tabinfo where tbname='" + na + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    disp();
                    MessageBox.Show("Succecfully Delete ");
                    this.Initialize();
                }
                else
                {
                    MessageBox.Show("Selete the row");
                }
                
          
       }

      ////editing

        private void button1_Click(object sender, EventArgs e)
       {
            
            string w1 = txttname.Text;
            string w2 = txtpass.Text;

                conn.Open();    
                    SqlCommand cmd = conn.CreateCommand();
                   cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Tabinfo set tbname='"+ w1 +"' ,pwd='"+w2+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                   disp();
                    MessageBox.Show("Succecfully Update");
                    this.Initialize();
        }

        





        //Dont touch
        //inventory serch


        //add items 
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {


                try
                {
                  //  conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
                    conn.Open();
                    string query = "insert into inventory(items,avail) "
                        + "VALUES('" + textBox2.Text + "','" + textBox3.Text + "')";
                    //string s = "Username is" + uname+".";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Succecfully add items");
                    this.Initialize();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                return;
            }
        }


        //serching
        private void btnsearchitem_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchitem_TextChanged(object sender, EventArgs e)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
            conn.Open();
            adapt = new SqlDataAdapter("select * from inventory where items like '" + txtsearchitem.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        //delete

          public void disp1()
        {
            
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from inventory ";
            cmd.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt);
            dataGridView2.DataSource = dt2;
            conn.Close();

        }

          private void btndeletitem_Click(object sender, EventArgs e)
          {
              string me = textBox2.Text;
              
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from inventory where items='" + me + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            disp1();
            MessageBox.Show("Succecfully Delete ");
            this.Initialize();

          }



        //update

          private void button3_Click(object sender, EventArgs e)
          {

            if (textBox2.Text != "")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update inventory set items ='" + textBox2.Text + "' where avail ='" + textBox3.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                disp1();
                MessageBox.Show("Succecfully Update");
                this.Initialize();
            }
            else
            {
                return;
            }



          }

      
      

        private void button5_Click(object sender, EventArgs e)
        {
            orderlist os = new orderlist();
            os.Show();
        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void txtconfirm_TextChanged_1(object sender, EventArgs e)
        {

        }
	}
}





