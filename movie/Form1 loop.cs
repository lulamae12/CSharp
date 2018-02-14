using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// this is a form.
/// this program asks the user to pick movie and then input their age and then it checks to see if they are abl to see the movie based on its rating
/// </summary>
namespace movie
{
    public partial class Form1 : Form
    {
        public int age;
        public Form1()
        
        {  
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            /// this part of the program converts the nubered list to a integer called age
        {
            int age = Convert.ToInt32((int)numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// this part of the program use a loop to constantly check that the age is still the same and then checks the selected movie and outputs accordingly.
            /// int age is used twice to update loops.
            int age = Convert.ToInt32((int)numericUpDown1.Value);
            while (age >= 17 && list.SelectedItem is "Logan")
                if (true)
                {
                    MessageBox.Show("You can see this movie.");
                    break;
                }
            while (age >= 13 && list.SelectedItem is "Wonder Woman" || age >= 13 && list.SelectedItem is "Interstellar" || age >= 13 && list.SelectedItem is "Back to the future")
                if (true)
                {
                    MessageBox.Show("You can see this movie.");
                    break;
                }
            while (age >= 0 && list.SelectedItem is "The Lion King")
                if (true)
                { 
                    MessageBox.Show("You can see this movie.");
                    break;
                }
            /// below part for restriction
            while (age < 17 && list.SelectedItem is "Logan")
                if (true)
                {
                    MessageBox.Show("You cannot see this movie.");
                    break;
                }
            while (age < 13 && list.SelectedItem is "Wonder Woman" || age < 13 && list.SelectedItem is "Interstellar" || age < 13 && list.SelectedItem is "Back to the future")
                if (true)
                {
                    MessageBox.Show("You cannot see this movie.");
                    break;
                }
        }

       
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
