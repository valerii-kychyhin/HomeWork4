using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numberInt = int.Parse(textBox1.Text);
                if (numberInt < 0)
                {
                    label3.Text = "Please enter a non-negative integer.";
                    return;
                }

                long factorial = 1; 
                for (int i = 1; i <= numberInt; i++)
                {
                    factorial *= i; 
                }

                label3.Text = factorial.ToString();
            }
            catch (FormatException)
            {
                label3.Text = "Please enter a valid integer.";
            }
            catch (OverflowException)
            {
                label3.Text = "Number too large!";
            }
        }

    }
}
