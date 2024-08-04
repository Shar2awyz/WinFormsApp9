using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp9;

namespace WinFormsApp9
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string password = "22100";
            Form1 form = new Form1();

         

            string p = textBox1.Text;
            if (p == password)
            {

                Form2 form2 = new Form2();

                // Show Form2
                form2.Show();
           this.Hide();
               
            }
            else
                if (p == "23100")
            {
                Form6 form6 = new Form6();

                // Show Form6
                form6.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please Enter Right Password");
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
