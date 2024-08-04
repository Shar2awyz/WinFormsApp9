using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("E:\\AssistantDr.txt");
            textBox1.Text = sr.ReadLine();
            textBox2.Text = sr.ReadLine();
            textBox3.Text = sr.ReadLine();
            textBox4.Text = sr.ReadLine();
            textBox5.Text = sr.ReadLine();
            textBox6.Text = sr.ReadLine();
            textBox7.Text = sr.ReadLine();
            textBox8.Text = sr.ReadLine();
            textBox9.Text = sr.ReadLine();
            textBox10.Text = sr.ReadLine();
            textBox11.Text = sr.ReadLine();
            textBox12.Text = sr.ReadLine();
            textBox13.Text = sr.ReadLine();
            textBox14.Text = sr.ReadLine();
            textBox15.Text = sr.ReadLine();
            textBox16.Text = sr.ReadLine();
            textBox17.Text = sr.ReadLine();
            textBox18.Text = sr.ReadLine();
            textBox19.Text = sr.ReadLine();
            textBox20.Text = sr.ReadLine();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to delete all Assistants data?",
       "Confirmation",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {
                string filePath = "E:\\AssistantDr.txt";

                try
                {
                   
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                      
                    }

                 
                    MessageBox.Show("Offloaded Successfully");
                }
                catch (Exception ex)
                {
                 
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
