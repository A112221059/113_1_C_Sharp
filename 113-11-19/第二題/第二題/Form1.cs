using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第二題
{
    public partial class Form1 : Form
    {
       
            const double BANANA = 115;
            const double APPLE = 80;
            const double ORANGE = 90;
            const double PEAR = 120;

            Boolean bananaClicked = false;
            Boolean appleClicked = false;
            Boolean orangeClicked = false;
            Boolean pearClicked = false;

            private double total = 0;
            public Form1()
            {
                InitializeComponent();
           
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        if (bananaClicked)
           {
              
            total -= BANANA;
            bananaClicked = false;
            }
            else
            {
                
                total += BANANA;
                bananaClicked = true;
            }
            UpdateTotalCalories();

        
    }

        private void pictureBox2_Click(object sender, EventArgs e)
            {
            if (appleClicked)
            {
                
                total -= APPLE;
                appleClicked = false;
            }
            else
            {
              
                total += APPLE;
                appleClicked = true;
            }
            UpdateTotalCalories();
        }

            private void pictureBox3_Click(object sender, EventArgs e)
            {
            if (orangeClicked)
            {
                
                total -= ORANGE;
                orangeClicked = false;
            }
            else
            {
              
                total += ORANGE;
                orangeClicked = true;
            }
            UpdateTotalCalories();


        }

            private void pictureBox4_Click(object sender, EventArgs e)
            {
            if (pearClicked)
            {
                
                total -= PEAR;
                pearClicked = false;
            }
            else
            {
               
                total += PEAR;
                pearClicked = true;
            }
            UpdateTotalCalories();


        }

            private void button1_Click(object sender, EventArgs e)
            {
            
                total = 0;
                bananaClicked = false;
                appleClicked = false;
                orangeClicked = false;
                pearClicked = false;

                
                pictureBox1.BackColor = DefaultBackColor;
                pictureBox2.BackColor = DefaultBackColor;
                pictureBox3.BackColor = DefaultBackColor;
                pictureBox4.BackColor = DefaultBackColor;

                
                UpdateTotalCalories();
            }
            private void button2_Click(object sender, EventArgs e)
            {
            this.Close();
            }

             private void UpdateTotalCalories()
             {
             label1.Text = $"Total Calories: {total}";

        }
    }
}
