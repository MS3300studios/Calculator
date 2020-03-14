using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibrary;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       


        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
           
        }
        //addition
        private void buttonPlus_Click(object sender, EventArgs e)
        {

            try
            {
                double d = double.Parse(textBoxA.Text);
                double c = double.Parse(textBoxB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input! Reload the calculator and try again! For instructions, open ReadMe.txt in the programme files.");
                Application.Exit();
            }                                   
                               
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            LabelResult.Visible = true;
            LabelResult.Text = $"{a + b}";
                
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }


        //multiplication
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBoxA.Text);
                double c = double.Parse(textBoxB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input! Reload the calculator and try again! For instructions, open ReadMe.txt in the programme files.");
                Application.Exit();
            }

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            LabelResult.Visible = true;
            LabelResult.Text = $"{a * b}";
        }
        //subtraction
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBoxA.Text);
                double c = double.Parse(textBoxB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input! Reload the calculator and try again! For instructions, open ReadMe.txt in the programme files.");
                Application.Exit();
            }

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            LabelResult.Visible = true;
            LabelResult.Text = $"{a - b}";

        }
        //division
        private void buttondivide_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBoxA.Text);
                double c = double.Parse(textBoxB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input! Reload the calculator and try again! For instructions, open ReadMe.txt in the programme files.");
                Application.Exit();
            }


            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            if (b <= 0)
            {
                LabelResult.Visible = true;
                LabelResult.Text = "You cannot divide by 0! Press Clear and try again.";
            }
            else
            {
                LabelResult.Visible = true;
                LabelResult.Text = $"{a / b}";
            }

        }
        //Root_broken
        private void buttonRoot_Click(object sender, EventArgs e)
        {
            if (textBoxAdvanced.Text == "")
            {
                labelResultAdvanced.Visible = true;
                labelResultAdvanced.Text = "Please enter the value.";
            }
            else
            {                   
                double a = Convert.ToDouble(textBoxAdvanced.Text);
                labelResultAdvanced.Visible = true;
                labelResultAdvanced.Text = $"{Math.Sqrt(a)}";
            }
        }
        //Root_correct
        private void buttonRoot_Click_1(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBoxAdvanced.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input! Reload the calculator and try again! For instructions, open ReadMe.txt in the programme files.");
                Application.Exit();
            }

            double a = Convert.ToDouble(textBoxAdvanced.Text);
            labelResultAdvanced.Visible = true;
            labelResultAdvanced.Text = $"{Math.Sqrt(a)}";

        }
        //Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxAdvanced.Clear();
            LabelResult.Visible = false;
            labelResultAdvanced.Visible = false;
        }

        //history
        private void buttonHistory_Click(object sender, EventArgs e)
        {

        }
        //ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //ComboBox Option Select Button
        private void buttonSelectCalc_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Basic calculator")
            {
                groupBoxAdvanced.Visible = false;
                groupBoxMain.Visible = true;
            }
            else if(comboBox1.SelectedItem == "Advanced calculator")
            {
                groupBoxMain.Visible = false;
                groupBoxAdvanced.Visible = true;
            }
        }      
    }
}
