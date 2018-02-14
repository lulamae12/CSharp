using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie
{
    public partial class Form1 : Form
    {
        public int age = 0;
        public Form1()
        
        {  
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int age = Convert.ToInt32((int)numericUpDown1.Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (list.SelectedItem is "Logan")
                if (age >= 17)
                {
                    MessageBox.Show("You can see this movie.");
                    
                }
                else
                {
                 MessageBox.Show("you cannot see this movie");
                 
                }

            if (list.SelectedItem is "Wonder Woman")
                if (age >= 13)
                {
                MessageBox.Show("You can see this movie.");
                
                }
                else
                {
                MessageBox.Show("you cannot see this movie");
                
                }
            if (list.SelectedItem is "Back to the future")
                if (age >=6 )
                {
                MessageBox.Show("You can see this movie.");
                
                }
                else
                {
                MessageBox.Show("you cannot see this movie");
                
                }
            
            if (list.SelectedItem is "Interstellar")
                if (age >= 13)
                {
                MessageBox.Show("You can see this movie.");
                
                }
                else
                {
                MessageBox.Show("you cannot see this movie");
                
                }
            if (list.SelectedItem is "The Lion King")
                if (age >= 0)
                {

                MessageBox.Show("You can see this movie.");
                
                }
                else
                {
                MessageBox.Show("you cannot see this movie");
                
                }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
