using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

             
             string query = "select * from login where username='" + txtuname.Text + "'and pwd=" + txtpass.Text + ";";
            DataTable dt = DataAccess.Data(query);

            
            if (dt.Rows.Count == 1)
            {
                if (txtuname.Text == "rishat")
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else if (txtuname.Text == "oishi")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else if (txtuname.Text == "arnob")
                {
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                }
               
            }
            
            else
            {
                MessageBox.Show("Invelid");
            }
               
            }
        

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }
        private void selectname()
        {
            if (txtuname.Text != "")
            {
                txtuname.Text = "";
            }
        }

        private void txtuname_Enter(object sender, EventArgs e)
        {
            selectname();

        }
        private void selectpass()
        {
            if (txtpass.Text != "")
            {
                txtpass.Text = "";
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            selectpass();
        }
        private void selectname1()
        {
            if (txtuname.Text == "")
            {
                txtuname.Text = "Username";
            }
        }

        private void txtuname_Leave(object sender, EventArgs e)
        {
            selectname1();
        }
        private void selectpass1()
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            selectpass1();
        }
    }
}


