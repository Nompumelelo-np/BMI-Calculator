using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weight;
            double Height;
            double BMI;

            Weight = double.Parse(textBox1.Text);
            Height = double.Parse(textBox2.Text);

            BMI = Weight / Math.Pow(Height, 2) ;

            textBox3.Text = BMI.ToString();


            if (BMI < 18.5)
            {
                textBox4.Text = "You are underweight";
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                textBox4.Text = "Your weight is normal";
            }
            else if (BMI < 24.9)
            {
                textBox4.Text = "You are overweight";
            }

            Console.ReadLine();



        }
    }
}
