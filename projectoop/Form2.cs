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
    public partial class Form2 : Form
    {
        SqlConnection conn = null;

       // SqlDataAdapter adapt;
       // DataTable dt;
       // SqlConnection conn = null;
       // SqlCommand cmd;
      //  int selectedRow;
      //  private string id="";

        

        //Totalbutton
        private void button3_Click(object sender, EventArgs e)
        {
            double fer, bur, piz, san, dess,fer2, bur2, piz2, san2, dess2, tecf2, piz3, san3, dess3, tecf3;
            double tax;
            tax = 0.45;

            fer = 50; fer2 = 20; bur = 120; bur2 = 150; piz = 150; piz2 = 200; piz3 = 250;  san = 180; san2 = 60; san3 = 70; dess = 40; dess2 = 120; dess3 = 150;
            tecf2 = 10; tecf3 = 20;


            double frice = Convert.ToDouble(f1.Value);
            double frice2 = Convert.ToDouble(f2.Value);

            double burger = Convert.ToDouble(f3.Value);
            double burger2 = Convert.ToDouble(f4.Value);


            double pizza = Convert.ToDouble(f5.Value);
            double pizza2 = Convert.ToDouble(f6.Value);
            double pizza3 = Convert.ToDouble(f7.Value);


            double sand = Convert.ToDouble(f8.Value);
            double sand2 = Convert.ToDouble(f9.Value);
            double sand3 = Convert.ToDouble(f10.Value);

            double dessert = Convert.ToDouble(f11.Value);
            double dessert2 = Convert.ToDouble(f12.Value);
            double dessert3 = Convert.ToDouble(f13.Value);

           
            double teacof2 = Convert.ToDouble(f15.Value);
            double teacof3 = Convert.ToDouble(f16.Value);
           



            amount OR = new amount(frice, burger, pizza, sand, dessert, frice2, burger2, pizza2, sand2, dessert2, teacof2,pizza3, sand3, dessert3, teacof3);

            double foodCosts = ((frice * fer) + (frice2 * fer2) + (burger * bur) + (burger2 * bur2) +  + (pizza * piz) + (pizza2 * piz2) + (pizza3 * piz3) +  + (sand * san) + (sand2 * san2) + (sand3 * san3) +
                (dessert * dess) + (dessert2 * dess2) + (dessert3 * dess3));

            textBox2.Text = Convert.ToString(foodCosts);

            double drinksCost1 =  (teacof2 * tecf2) + (teacof3 * tecf3);

            textBox1.Text = Convert.ToString(drinksCost1);



            textBox3.Text = Convert.ToString(((foodCosts + drinksCost1) * tax) / 100);
            double totalAftTax = Convert.ToDouble(textBox3.Text);
            textBox5.Text = Convert.ToString(foodCosts + drinksCost1 + totalAftTax);
            textBox1.Text = String.Format("{0}", (drinksCost1));
            textBox2.Text = String.Format("{0}", (foodCosts));
            textBox4.Text = String.Format("{0}", (foodCosts + drinksCost1));
            textBox3.Text = String.Format("{0}", totalAftTax);
            textBox5.Text = String.Format("{0}", (foodCosts + drinksCost1 + totalAftTax));
        }

        


        //Reset button
        private void Initialize()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "0";

            l1.Text = l3.Text = l5.Text = l8.Text = l11.Text = l14.Text = l15.Text = l2.Text = l4.Text = "0 ";
            l6.Text = l9.Text = l12.Text = l7.Text = l10.Text = l13.Text = l16.Text =" 0";

           

            chefries.Checked = checkBox1.Checked = checkBox2.Checked = chepizza.Checked = checkBox4.Checked = checkBox5.Checked = checkBox6.Checked = false;
            checkBox8.Checked = checkBox9.Checked = checkBox10.Checked = chesand.Checked = chedes.Checked =  false;

            print.Clear();


            //this.Form3 = Form3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Initialize();
        }




        //printbox


        private void button5_Click(object sender, EventArgs e)
        {
            this.printbutton();
        }

        private void printbutton()
        {
            if (textBox5.Text != "0")
            {
                print.Enabled = true;
            }
            else
            {
                print.Enabled = false;
                print.Clear();
            }

            print.Clear();

            print.AppendText("\t\t" + "Hungry Buddy " + Environment.NewLine);
            print.AppendText("\t\t" + "Order From Table 1 " + Environment.NewLine);
            print.AppendText("------------------------------------" + Environment.NewLine);
            print.AppendText("              Quantity             Price     " + Environment.NewLine);

            print.AppendText("Fried Chicken  \t\t" + f1.Value + "\t" + l1.Text +Environment.NewLine);
            print.AppendText("France Fry     \t" + f2.Value + "\t" + l2.Text+ Environment.NewLine);
            print.AppendText("Beef Burger    \t" + f3.Value + "\t" + l3.Text + Environment.NewLine);
            print.AppendText("Chicken Burger\t" + f4.Value + "\t" + l4.Text + Environment.NewLine);
            print.AppendText("Cheese Pizza  \t\t" + f5.Value + "\t" + l5.Text + Environment.NewLine);
            print.AppendText("Beef Pizza    \t\t" + f6.Value + "\t" + l6.Text + Environment.NewLine);
            print.AppendText("Chicken Pizza  \t" + f7.Value + "\t" + l7.Text + Environment.NewLine);
            print.AppendText("Sub Sandwich   \t" + f8.Value + "\t" + l8.Text + Environment.NewLine);
            print.AppendText("Smoki Sandwich \t" + f9.Value + "\t" + l9.Text + Environment.NewLine);
            print.AppendText("Cheese Sandwich \t" + f10.Value + "\t" + l10.Text + Environment.NewLine);
            print.AppendText("Misty          \t\t" + f11.Value + "\t" + l11.Text + Environment.NewLine);
            print.AppendText("Chocolate Cake \t" + f12.Value + "\t" + l12.Text + Environment.NewLine);
            print.AppendText("Ice Cream      \t\t" + f13.Value + "\t" + l13.Text + Environment.NewLine);
           // print.AppendText("Coca Cola      \t\t" + f14.Value + "\t" + l14.Text + Environment.NewLine);
            print.AppendText("Tea            \t\t" + f15.Value + "\t" + l15.Text + Environment.NewLine);
            print.AppendText("Coffee         \t\t" + f16.Value + "\t" + l16.Text + Environment.NewLine);
            
            print.AppendText("---------------------------------------" + Environment.NewLine);
            print.AppendText("Vat         \t\t  " + textBox3.Text + Environment.NewLine);
            print.AppendText("Sub Total   \t\t " + textBox4.Text + Environment.NewLine);
            print.AppendText("Total     \t\t   " + textBox5.Text + Environment.NewLine);
            print.AppendText("---------------------------------------" + Environment.NewLine);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(print.Text, new Font("Microsoft YaHei UI", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            print.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            print.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            print.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            print.Paste();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";


            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(print.Text);
            }
        }

        //Exit

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            MessageBox.Show("Thank you for order .. Enjoy the food.");
               
        }




        public Form2()
        {
            InitializeComponent();
            f1.Maximum = 30;
            f1.Minimum = 0;
            f2.Maximum = 30;
            f3.Maximum = 30;
            f4.Maximum = 30;
            f5.Maximum = 30;
            f6.Maximum = 30;
            f7.Maximum = 30;
            f8.Maximum = 30;
            f9.Maximum = 30;
            f10.Maximum = 30;
            f12.Maximum = 30;
            f13.Maximum = 30;
            //f14.Maximum = 30;
            f15.Maximum = 30;
            f16.Maximum = 30;
            f11.Maximum = 30;
           
            f2.Minimum = 0;
            f3.Minimum = 0;
            f4.Minimum = 0;
            f5.Minimum = 0;
            f6.Minimum = 0;
            f7.Minimum = 0;
            f8.Minimum = 0;
            f9.Minimum = 0;
            f10.Minimum = 0;
            f12.Minimum = 0;
            f13.Minimum = 0;
            //f14.Minimum = 0;
            f15.Minimum = 0;
            f16.Minimum = 0;
  
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "0";

            l1.Text = l3.Text = l5.Text = l8.Text = l11.Text = l14.Text = l15.Text = l2.Text = l4.Text = " ";
            l6.Text = l9.Text = l12.Text = l7.Text = l10.Text = l13.Text = l16.Text = label26.Text  = " ";

            f5.Value = f6.Value = f7.Value = f8.Value = 0;
            f9.Value = f10.Value = f11.Value = f12.Value = f4.Value = f3.Value = f2.Value =  f1.Value=0;
            f13.Value =  f15.Value = f16.Value  = f15.Value = f16.Value = 0;

            chefries.Checked = checkBox1.Checked = checkBox2.Checked  = chepizza.Checked = checkBox4.Checked = checkBox5.Checked = checkBox6.Checked = false;
            checkBox8.Checked = checkBox9.Checked = checkBox10.Checked = chesand.Checked = chedes.Checked =  false;

            print.Clear();


        }

        private void chefries_CheckedChanged(object sender, EventArgs e)
        {
            int quantity1 = (int)f1.Value;
            int total = quantity1 * 50;

            if (chefries.Checked == true)
            {
                f1.Enabled = true;
              
            }
            else
            {
                f1.Enabled = false;

            }
            l1.Text = total.ToString();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int quantity2 = (int)f2.Value;
            int tota2 = quantity2 * 20;
            l2.Text = tota2.ToString();
            if (checkBox1.Checked == true)
            {
                f2.Enabled = true;
            }
            else
            {
                f2.Enabled = false;

            }

          
        }


        private void cheburger_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f3.Value;
            int tota3 = quantity * 120;
            if (cheburger.Checked == true)
            {
                f3.Enabled = true;
            }
            else
            {
                f3.Enabled = false;

            }

            l3.Text = tota3.ToString();
            
        }


        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f4.Value;
            int tota4 = quantity * 150;
            if (checkBox2.Checked == true)
            {
                f4.Enabled = true;
            }
            else
            {
                f4.Enabled = false;

            }

            l4.Text = tota4.ToString();
           
        }

        
        private void chepizza_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f5.Value;
            int tota5= quantity * 150;
            if (chepizza.Checked == true)
            {
                f5.Enabled = true;
            }
            else
            {
                f5.Enabled = false;

            }

            l5.Text = tota5.ToString();
           
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f6.Value;
            int tota6 = quantity * 200;
            if (checkBox5.Checked == true)
            {
                f6.Enabled = true;
            }
            else
            {
                f6.Enabled = false;

            }

            l6.Text = tota6.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f7.Value;
            int total7 = quantity * 250;
            if (checkBox6.Checked == true)
            {
                f7.Enabled = true;
            }
            else
            {
                f7.Enabled = false;

            }

            l7.Text = total7.ToString();
        
        }

        private void chesand_CheckedChanged(object sender, EventArgs e)
        {
             int quantity = (int)f8.Value;
            int total8 = quantity * 180;
            if (chesand.Checked == true)
            {
                f8.Enabled = true;
            }
            else
            {
                f8.Enabled = false;

            }

            l8.Text = total8.ToString();
        }
         
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
             int quantity = (int)f9.Value;
            int total9 = quantity * 60;
            if (checkBox8.Checked == true)
            {
                f9.Enabled = true;
            }
            else
            {
                f9.Enabled = false;

            }

            l9.Text = total9.ToString();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f10.Value;
            int total10 = quantity * 70;
            if (checkBox9.Checked == true)
            {
                f10.Enabled = true;
            }
            else
            {
                f10.Enabled = false;

            }

            l10.Text = total10.ToString();
        }


        private void chedes_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f11.Value;
            int total11 = quantity * 40;
            if (chedes.Checked == true)
            {
                f11.Enabled = true;
            }
            else
            {
                f11.Enabled = false;

            }

            l11.Text = total11.ToString();
           
           
        }
      
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f12.Value;
            int total12 = quantity * 120;
            if (checkBox4.Checked == true)
            {
                f12.Enabled = true;
            }
            else
            {
                f12.Enabled = false;

            }

            l12.Text = total12.ToString();
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        { int quantity = (int)f13.Value;
            int total13 = quantity * 150;
            if (checkBox10.Checked == true)
            {
                f13.Enabled = true;
            }
            else
            {
                f13.Enabled = false;

            }

            l13.Text = total13.ToString();
         

        }


       

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f15.Value;
            int total15 = quantity * 10;
            if (checkBox11.Checked == true)
            {
                f15.Enabled = true;
            }
            else
            {
                f15.Enabled = false;

            }

            l15.Text = total15.ToString();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = (int)f16.Value;
            int total16 = quantity * 20;
            if (checkBox12.Checked == true)
            {
                f16.Enabled = true;
            }
            else
            {
                f16.Enabled = false;

            }

            l16.Text = total16.ToString();
           
        }

    
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void printPreviewDialog1_Load(object sender, EventArgs e) { }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            feedback fo= new feedback();
            fo.Show();
            this.Hide();
            this.Initialize();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        

        private void f1_ValueChanged(object sender, EventArgs e){}
        private void f4_ValueChanged(object sender, EventArgs e){}
        private void f5_ValueChanged(object sender, EventArgs e){}
        private void f6_ValueChanged(object sender, EventArgs e){}     
        private void f7_ValueChanged(object sender, EventArgs e){}
        private void f8_ValueChanged(object sender, EventArgs e){}
        private void f9_ValueChanged(object sender, EventArgs e){}
        private void f10_ValueChanged(object sender, EventArgs e){}
        private void f11_ValueChanged(object sender, EventArgs e){}
        private void f12_ValueChanged(object sender, EventArgs e){}
        private void f13_ValueChanged(object sender, EventArgs e) {}
        private void f14_ValueChanged(object sender, EventArgs e){}
        private void f15_ValueChanged(object sender, EventArgs e){}
        private void f2_ValueChanged(object sender, EventArgs e){}
        private void f3_ValueChanged(object sender, EventArgs e){}
        private void groupBox6_Enter(object sender, EventArgs e){}
        private void f16_ValueChanged(object sender, EventArgs e) {}
        }
    
}

