﻿using System;
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
        double a, b;
        int count;
        string k;
        double otvet;

        public Form1()
        {
            
            InitializeComponent();
        }

        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Button1_Click(object sender, EventArgs e) // "+"
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            count = 1;
        }

        private void Button2_Click(object sender, EventArgs e)// "-"
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            count = 2;
        }

        private void Button4_Click(object sender, EventArgs e) // "*"
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = "";
            count = 3;

        }

        private void Button3_Click(object sender, EventArgs e) // "/"
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = "";
            count = 4;

        }

        private void Button17_Click(object sender, EventArgs e)  // ","
        {
            textBox1.Text += ",";
        }

        private void Button15_Click(object sender, EventArgs e) // BACK
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Button16_Click(object sender, EventArgs e)  //result
        {
            double SecondNumber;
            double Result;
            string res;

            SecondNumber = Convert.ToDouble(textBox1.Text);
            
            if (count == 1)
            {
                Result = a + SecondNumber;
                res = Convert.ToString(Result);
                textBox1.Text = res;
            }
            if (count == 2)
            {
                Result = a - SecondNumber;
                res = Convert.ToString(Result);
                textBox1.Text = res;
                
            }
            if (count == 3)
            {
                Result = (a * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                a = Result;
            }
            if (count == 4)
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (a / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    a = Result;
                }
            }

        }

        private void Button18_Click(object sender, EventArgs e) // Clear All
        {
            textBox1.Text = "";
        }
    }
    
}
