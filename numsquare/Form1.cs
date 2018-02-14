using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numsquare
{
    public partial class Form1 : Form
    {
        class squarelist
        {
            public static List<double> squares = new List<double>();

            
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (NumBox.Text.All(char.IsDigit))
            {
            }

            else
            {
                MessageBox.Show("please enter a valid number.");
            }
        
        }

        private void NumBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                int num = Convert.ToInt32(NumBox.Text);       
                double squared = Math.Pow(num, 2);
                numsList.Items.Add(squared.ToString());
                squarelist.squares.Add(squared);
                MessageBox.Show(squared.ToString());
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = numsList.Items.Cast<int>().Sum();

            MessageBox.Show(d.ToString() + "\n" + (d / numsList.Items.Count).ToString());
        }
    }
}
