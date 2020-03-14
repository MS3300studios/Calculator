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
            if (textBoxA.Text == "" || textBoxB.Text == "")
            {
                LabelResult.Visible = true;
                LabelResult.Text = "Please enter value A and value B";
            }
            else
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                LabelResult.Visible = true;
                LabelResult.Text = $"{a + b}";
            }        
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        //multiplication
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == "" || textBoxB.Text == "")
            {
                LabelResult.Visible = true;
                LabelResult.Text = "Please enter value A and value B";                
            }
            else
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                LabelResult.Visible = true;
                LabelResult.Text = $"{a * b}";
            }

        }
        //subtraction
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == "" || textBoxB.Text == "")
            {
                LabelResult.Visible = true;
                LabelResult.Text = "Please enter value A and value B";
            }
            else
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                LabelResult.Visible = true;
                LabelResult.Text = $"{a - b}";
            }
        }
        //division
        private void buttondivide_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == "" || textBoxB.Text == "")
            {
                LabelResult.Visible = true;
                LabelResult.Text = "Please enter value A and value B";
            }
            else
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
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
        }
        //Root
        private void buttonRoot_Click(object sender, EventArgs e)
        {
            if (textBoxAdvanced.Text == "")
            {
                labelResultAdvanced.Visible = true;
                labelResultAdvanced.Text = "Please enter the value.";
            }
            else
            {               
                int a = int.Parse(textBoxAdvanced.Text);                
                labelResultAdvanced.Visible = true;
                labelResultAdvanced.Text = $"{Math.Sqrt(a)}";
            }
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
