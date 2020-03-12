using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            LabelResult.Visible = true;
            LabelResult.Text = $"{a+b}";
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        //multiplication
        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            LabelResult.Visible = true;
            LabelResult.Text = $"{a * b}";

        }
        //subtraction
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            LabelResult.Visible = true;
            LabelResult.Text = $"{a - b}";            
        }
        //division
        private void buttondivide_Click(object sender, EventArgs e)
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
        }
    }
}
