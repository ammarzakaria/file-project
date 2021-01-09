﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string c;
        double x;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + b.Text;
            if (textBox1.Text == "." && b.Text == ".")
                textBox1.Text = "0.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + " " + c;
            textBox1.Clear();
          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (c)
                {
                case "+":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x + y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x - y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "*":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x * y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x / y).ToString();
                        label1.Text = "";
                    }
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    {
                        e.Handled = true;
                        button3.PerformClick();
                    }break;
                case '-':
                    {
                        e.Handled = true;
                        button16.PerformClick();
                    }
                    break;
                case '*':
                    {
                        e.Handled = true;
                        button17.PerformClick();
                    }
                    break;
                case '/':
                    {
                        e.Handled = true;
                        button18.PerformClick();
                    }
                    break;
                case (char)Keys.Enter:
                    {
                        button19.PerformClick();
                    }break;
                case (char)Keys.Back:
                
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("enter num only");
                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
