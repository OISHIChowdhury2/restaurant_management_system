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
    public partial class Form5 : Form
    {

        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection conn = null;
       // SqlCommand cmd;
        int selectedRow;

        public Form5()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            txtboxMName.Text=txtboxMAccID.Text= textBox2.Text = c1.Text = txtboxMPhone.Text= txtboxMAdd.Text=textBox1.Text="";

        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

          private void txtboxTableDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


         public void disp5()
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
       
      
        private void btnSDDelete_Click(object sender, EventArgs e)
        {
          string nae = txtboxMName.Text;
             
                if (nae != null)
                {

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from regmg where name='" + nae + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    disp5();
                    MessageBox.Show("Succecfully Delete ");
                    this.Initialize();
                }
                else
                {
                    MessageBox.Show("Selete the row");
                }
        }

        
        private void btnSDSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void txtboxShowDetailsSearch_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        private void btnSDEdit_Click(object sender, EventArgs e)
        {
              
             string name = Convert.ToString(txtboxMName.Text);
                string id = Convert.ToString(txtboxMAccID.Text);
                string dob = Convert.ToString(textBox2.Text);
                string gender1 = Convert.ToString(c1.Text);
                string phone1 =Convert.ToString( txtboxMPhone.Text);
                string address1 = Convert.ToString(txtboxMAdd.Text);
                string joint = Convert.ToString(textBox1.Text);
              conn.Open();
              SqlCommand cmd = conn.CreateCommand();
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = "update regmg set name ='" + name + "',acid ='" + id + "',dob ='" + dob + "',gender ='" + gender1 + "',phone ='" + phone1 + "',address ='" + address1 + "'where joitdt ='" + joint + "' ";
              cmd.ExecuteNonQuery();
              conn.Close();
              disp5();
              MessageBox.Show("Succecfully Update");
              this.Initialize();
              

        }

        

        private void txtboxTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMRegister_Click(object sender, EventArgs e)
        {
           
            if (txtboxMName.Text != null)
            {
                string name = Convert.ToString(txtboxMName.Text);
                string id = Convert.ToString(txtboxMAccID.Text);
                string dob = Convert.ToString(textBox2.Text);
                string gender = Convert.ToString(c1.Text);
                string phone =Convert.ToString( txtboxMPhone.Text);
                string address = Convert.ToString(txtboxMAdd.Text);
                string joint = Convert.ToString(textBox1.Text);
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
                    conn.Open();
                    string query = "insert into regmg(name,acid,dob,gender,phone,address,joitdt) "
                        + "VALUES('" + name + "','" + id + "','" + dob + "','" + gender + "','" + phone + "','" + address + "','" + joint + "')";
                  
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Succecfully add Maneger");
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

        public void BackInForm() {
            txtboxMName.Text = ""; txtboxMAccID.Text = ""; textBox2.Text = ""; c1.Text="";
            txtboxMPhone.Text = ""; txtboxMAdd.Text = ""; textBox1.Text = "";
        }

        private void lblUname_Click(object sender, EventArgs e)
        {

        }

        private void txtboxShowDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectoopDataSet3.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.projectoopDataSet3.order);
            // TODO: This line of code loads data into the 'projectoopDataSet1.regmg' table. You can move, or remove it, as needed.
            this.regmgTableAdapter.Fill(this.projectoopDataSet1.regmg);

        }

        private void lblManagerRegForm_Click(object sender, EventArgs e)
        {

        }

      
       

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load_2(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectoopDataSet5.regmg' table. You can move, or remove it, as needed.
            this.regmgTableAdapter1.Fill(this.projectoopDataSet5.regmg);
            // TODO: This line of code loads data into the 'projectoopDataSet4.total' table. You can move, or remove it, as needed.
            this.totalTableAdapter.Fill(this.projectoopDataSet4.total);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

      








    }
}

    

