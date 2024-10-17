using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);
                if (number < 0)
                {
                    MessageBox.Show("Enter a non-negative number!");
                    return;
                }

                long factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                label2.Text = "Result: " + factorial.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a non-negative number!.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
