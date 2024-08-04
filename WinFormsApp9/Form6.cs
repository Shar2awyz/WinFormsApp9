using System;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Display All Employees")
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
            }
            else
               if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Remove Employee")
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                 }
            else
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Add")
                {
                    Form3 form = new Form3();
                    form.Show();
                    this.Hide();
                }
                else if (comboBox1.SelectedItem.ToString() == "Display All Employees" && checkBox2.Checked && checkBox1.Checked == false)
                {
                    Form7 form7 = new Form7();
                    form7.Show();
                    this.Hide();
                }
                else if (comboBox1.SelectedItem.ToString() == "Display All Employees" && checkBox1.Checked && checkBox2.Checked == false)
                {
                    Form8 form8 = new Form8();
                    form8.Show();
                    this.Hide();

                }
                else
                if (comboBox1.SelectedItem.ToString() == "Remove Employee" && checkBox1.Checked && checkBox2.Checked == false) {
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    Form9 form9 = new Form9();
                    form9.Show();
                    this.Hide();



                }
                else
                       if (checkBox2.Checked == true && checkBox1.Checked == true)
                    MessageBox.Show("Please Choose 1 Option");
            }
            else
            {
                MessageBox.Show("Please select an option from the combo box.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

            checkBox1.Visible = false;
            checkBox2.Visible = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
            }
            else
               if (checkBox1.Checked == false)
            {
                checkBox2.Checked = false;
                checkBox2.Enabled = true;
            }

        }

     //   private void checkBox2_CheckedChanged(object sender, EventArgs e)
      //  {

           

      //  }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
            }
            else
        if (checkBox2.Checked == false)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = true;
            }
        }
    }
}
