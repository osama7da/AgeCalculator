using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int birthYear))
            {
                // Calculate age
                int currentYear = DateTime.Now.Year;
                int age = currentYear - birthYear;

                // Display result
                label3.Text = $"Your age is: {age}";
            }
            else
            {
                // Show error message
                MessageBox.Show("Please enter a valid year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
