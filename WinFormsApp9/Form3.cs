using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                receptionist[] receptionis = new receptionist[5];

                for (int i = 0; i < receptionis.Length; i++)
                {
                    receptionis[i] = new receptionist();
                    receptionis[i].Salary = "7000";
                }



                receptionis[0].name = textBox1.Text;
                receptionis[0].Id = textBox2.Text;
                receptionis[0].depaa = textBox3.Text;
                receptionis[0].Bonus = textBox4.Text;
                receptionis[0].setBonus(receptionis[0].Bonus);
                string filePath = "E:\\Receptioist.txt";
                string textToWrite = $"{receptionis[0].name}\n{receptionis[0].Id}\n{receptionis[0].depaa}\n{receptionis[0].getBonus()}";

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, append: true))
                    {
                        writer.WriteLine(textToWrite);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred while writing to the file: " + ex.Message);
                }

            }
            else if (checkBox2.Checked){ AssistantDr[] Ass = new AssistantDr[5];
            for (int i = 0; i < Ass.Length; i++)
            {
                Ass[i] = new AssistantDr();
                Ass[i].Salary = "9000";
            }

            Ass[0].name = textBox1.Text;
            Ass[0].Id = textBox2.Text;
            Ass[0].depaa = textBox3.Text;
            Ass[0].Bonus = textBox4.Text;
            Ass[0].setBonus(Ass[0].Bonus);

            string filePath = "E:\\AssistantDr.txt";
            string textToWrite = $"{Ass[0].name}\n{Ass[0].Id}\n{Ass[0].depaa}\n{Ass[0].getBonus()}";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine(textToWrite);
                }
                MessageBox.Show("Assistant Doctor data written successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while writing to the file: " + ex.Message);
            }
        }

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true; 
                checkBox2.Checked = false;


            }
            
                

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = true;
                checkBox1.Checked = false;
            }
        }
    }
}