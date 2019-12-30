using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_button_test
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }
        int loop;

        public string input;

        private void button1_Click(object sender, EventArgs e)
        {
        
                if (Int32.TryParse(this.textBox1.Text, out int input))
                {
                    loop = input;
                }
                else
                {
                    MessageBox.Show("Du måste skriva in med siffror.");
                }



                //this.listBox1.Items.Add(sum.ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
