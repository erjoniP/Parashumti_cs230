using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parashumti_Small_Programs_Showcase
{
    public partial class FBMI : Form
    {
        public FBMI()
        {
            InitializeComponent();
            btnClose.Click += btnClose_Click;
            btnCalculate.Click += btnCalculate_Click;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rtStatus_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int weight = int.Parse(txtWeight.Text);
                int heigh = int.Parse(txtHeight.Text);

                double height = Convert.ToDouble(txtHeight.Text);
                height = height * 0.0254;
                double mass = Convert.ToDouble(txtWeight.Text);
                mass = mass / 2.205;
                double bmi = mass / (height * height);
                rtBmi.Text = bmi.ToString("F2");

                if (bmi < 18.5)
                {
                    rtStatus.Text = "Underweight";
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    rtStatus.Text = "Normal weight";
                }
                else if (bmi >= 25.0 && bmi <= 29.9)
                {
                    rtStatus.Text = "Overweight";
                }
                else
                {
                    rtStatus.Text = "Obese";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The mass and height must be numbers.");
            }

        }
    }
}
