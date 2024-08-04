using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Add Patient")
            {
                Form4 form4 = new Form4();

                // Show Form2
                form4.Show();
                this.Hide();

            }
            else

               if (comboBox1.SelectedItem.ToString() == "Display All Patient")
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();

            }
            else
             if (comboBox1.SelectedItem.ToString() == "Offload Patients List")
            {
                string filePath = "D:\\sx.txt";
                string textToWrite = null;
                try
                {

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        filePath.DefaultIfEmpty();
                        MessageBox.Show("Offloaded Successfully");

                    }




                }
                catch (Exception ex)
                {



                }


            }
            //Remove Patient
            else
                  
                MessageBox.Show("لسه معملتهاش يا حبيبي");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            

        }
    }
}
