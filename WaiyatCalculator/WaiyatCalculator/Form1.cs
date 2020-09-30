using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaiyatCalculator
{
    public partial class WaiyatCalculator : Form
    {
        string operation = "";
        double value = 0;
        public WaiyatCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "1";
        }

        private void label2_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "2";
        }

        private void label3_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "3";
        }

        private void label4_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "4";
        }

        private void label5_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "5";
        }

        private void label6_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "6";
        }

        private void label7_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "7";
        }

        private void label8_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "8";
        }

        private void label9_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "9";
        }

        private void label0_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "0";
        }

        private void labeldot_click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + ".";
        }

        

        private void labelplus_click(object sender, EventArgs e)
        {
            operation = "+";
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            operation = "-";
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
        }

        private void buttontime_Click(object sender, EventArgs e)
        {
            operation = "*";
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
         
            operation = "/";
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            
        }
        private void buttonpower_Click(object sender, EventArgs e)
        {
            operation = "^";
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
        }

        private void buttonsqrt_Click(object sender, EventArgs e)
        {
          
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            textBoxResult.Text = Math.Sqrt(value).ToString();
        }

        private void labelequal_click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBoxResult.Text = (value + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (value - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (value * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (value / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "^":
                    textBoxResult.Text = Math.Pow(value, Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    textBoxResult.Text = "error you need to put a number first";
                    break;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
        }

        private void buttonpercent_Click(object sender, EventArgs e)
        {
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            textBoxResult.Text = (value/100).ToString();
        }

        private void buttonsin_Click(object sender, EventArgs e)
        {
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            textBoxResult.Text = Math.Sin(value).ToString();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            textBoxResult.Text = Math.Tan(value).ToString();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            textBoxResult.Text = Math.Cos(value).ToString();
        }

        private void buttonLog10_Click(object sender, EventArgs e)
        {
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            textBoxResult.Text = Math.Log10(value).ToString();
        }

        private void buttonLog2_Click(object sender, EventArgs e)
        {
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            textBoxResult.Text = Math.Log(value).ToString();
        }

        private void buttonroot3_Click(object sender, EventArgs e)
        {
            value = Double.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            textBoxResult.Text = Math.Ceiling(Math.Pow(value, (double)1 / 3)).ToString();
        }
    }
}
