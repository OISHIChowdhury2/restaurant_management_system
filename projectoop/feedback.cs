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
    public partial class feedback : Form

    {
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection conn = null;
        SqlCommand cmd;  
        public feedback()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null)
            {
                string comment = richTextBox1.Text;
                string email = textBox1.Text;


                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
                    conn.Open();
                    string query = "insert into feedback(comment,email) "
                        + "VALUES('" + comment + "','" + email + "')";
                    //string s = "Username is" + uname+".";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thanks for give feedback ");
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
        private void Initialize()
        {
            richTextBox1.Text = textBox1.Text = "";
            this.Hide();
            Form2 f1 = new Form2();
            f1.Show();
        }
    }
}
