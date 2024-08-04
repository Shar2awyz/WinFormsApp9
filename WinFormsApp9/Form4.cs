
using Namespace9;
using System.Security.Cryptography.X509Certificates;
using WinFormsApp9;



namespace WinFormsApp9
{


    internal partial class Form4 : Form
    {
        string l;
        string j;
        string m;
        string n;

        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        internal string f;
        internal void button1_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\sx.txt";
            string textToWrite = textBox1.Text;

            try
            {

          
               

                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine(textToWrite);
                    writer.WriteLine(textBox2.Text);
                    writer.WriteLine(textBox3.Text);
                    writer.WriteLine(textBox4.Text);

                }



            }
            catch (Exception ex)
            {



            }

             
           



            MessageBox.Show("Patient added.");

        }



        internal void lsetter()
        {


            l = textBox1.Text;




        }
        internal string lgetter()
        {

            return l;
        }
        internal void jsetter()
        {
            j = textBox2.Text;

        }
        internal string jgetter()
        {
            return j;

        }
        internal void msetter()
        {
            m = textBox3.Text;


        }
        internal string mgetter()
        {

            return m;

        }
        internal void nsetter()
        {
            string n = textBox4.Text;
        }
        internal string ngetter()
        {

            return n;


        }
        internal string igetter()
        {
            string id = textBox2.Text;
            return id;
        }

        internal string kgetter()
        {

            string f = textBox4.Text;
            return f;


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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fort = new Form1();
            fort.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 fort = new Form5();
            fort.Show();    
            this.Hide();    
        }
    }

}
