﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0.0, b = 0.0, c = 0.0;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                if (a == b)
                    textBox3.Text = Convert.ToString(a);
                else if (a > b)
                {
                    c = a;
                    int i = 1;
                    while (c % b != 0)
                        c = a * i++;
                }
                else
                {
                    c = b;
                    int i = 1;
                    while (c % a != 0)
                        c = b * i++;
                }
                textBox3.Text = Convert.ToString(c);
            }
            catch
            {
                textBox3.Text = ("非法输入");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0.0, b = 0.0, c = 0.0;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                if (a == b)
                    textBox3.Text = Convert.ToString(a);
                else if (a > b)
                {
                    c = b;
                    int i = 1;
                    do
                    {
                        c = b / i++;
                    } while (a % c != 0);
                }
                else
                {
                    c = a;
                    int i = 1;
                    do
                    {
                        c = a / i++;
                    } while (b % c != 0);
                }
                textBox3.Text = Convert.ToString(c);
            }
            catch
            {
                textBox3.Text = ("非法输入");
            }
        }
    }
}
