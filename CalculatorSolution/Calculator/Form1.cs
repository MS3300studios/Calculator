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

        //BUTTONS:

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
        //OTHERS:

        //Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxAdvanced.Clear();
            textBoxA.BackColor = Color.White;
            textBoxB.BackColor = Color.White;
            textBoxAdvanced.BackColor = Color.White;
            LabelResult.Visible = false;
            labelResultAdvanced.Visible = false;            
        }
        //history
        private void buttonHistory_Click(object sender, EventArgs e)
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the Calculator!");
            Application.Exit();
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mikołaj Strusiński\nGitHub: https://github.com/MS3300studios \nCopyright 2020 Mikołaj Strusiński");
        }

        //INPUT CONTROL:
        
        //textBoxAdvanced
        private void textBoxAdvanced_TextChanged(object sender, EventArgs e)
        {
            double score = 0;
            if (double.TryParse(textBoxAdvanced.Text, out score)) //out oznacza tutaj że ma wywalić ten wynik poza nawias do int score
            {
                textBoxAdvanced.BackColor = Color.LightGreen;
                buttonRoot.Enabled = true;
            }
            else
            {
                textBoxAdvanced.BackColor = Color.PaleVioletRed;
                buttonRoot.Enabled = false;
            }
        }
        //textBoxA
        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            double score = 0;
            if (double.TryParse(textBoxA.Text, out score)) //out oznacza tutaj że ma wywalić ten wynik poza nawias do int score
            {
                textBoxA.BackColor = Color.LightGreen;
                buttonMinus.Enabled = true;
                button2.Enabled = true; //multiply button
                buttonPlus.Enabled = true;
                buttondivide.Enabled = true;
                if (textBoxB.Text == "") 
                {                    
                    buttonMinus.Enabled = false;
                    button2.Enabled = false; //multiply button
                    buttonPlus.Enabled = false;
                    buttondivide.Enabled = false;
                }                
            }
            else
            {
                textBoxA.BackColor = Color.PaleVioletRed;
                buttonMinus.Enabled = false;
                button2.Enabled = false; //multiply button
                buttonPlus.Enabled = false;
                buttondivide.Enabled = false;
            }
        }
        //textBoxB
        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            double score = 0;
            if (double.TryParse(textBoxB.Text, out score)) //out oznacza tutaj że ma wywalić ten wynik poza nawias do int score
            {
                textBoxB.BackColor = Color.LightGreen;
                buttonMinus.Enabled = true;
                button2.Enabled = true; //multiply button
                buttonPlus.Enabled = true;
                buttondivide.Enabled = true;
            }
            else
            {
                textBoxB.BackColor = Color.PaleVioletRed;
                buttonMinus.Enabled = false;
                button2.Enabled = false; //multiply button
                buttonPlus.Enabled = false;
                buttondivide.Enabled = false;
            }
        }

        //NOT NEEDED:
        //Root_broken
        private void buttonRoot_Click(object sender, EventArgs e)
        {        
        }
        //ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

    }
}
