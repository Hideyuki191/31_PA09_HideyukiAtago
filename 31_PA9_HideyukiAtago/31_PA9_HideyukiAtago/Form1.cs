using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    namespace _31_PA9_HideyukiAtago
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                textBox2.Clear();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                {
                        if (radioButton2.Checked)
                        {
                            try
                            {
                                decimal amount = System.Convert.ToDecimal(textBox1.Text);
                                decimal converted_amount = amount * 0.74M;
                                textBox2.Text = "$" + converted_amount.ToString();
                            }
                            catch (FormatException)
                            {
                                textBox1.Clear();
                                textBox2.Clear();
                                label4.Text = "Invalid Input. Try again";
                            }
                        }

                        else if (radioButton1.Checked)
                        {
                            try
                            {
                                decimal amount = System.Convert.ToDecimal(textBox1.Text);
                                decimal converted_amount = amount * 81.97M;
                                textBox2.Text = "¥" + converted_amount.ToString();
                            }
                            catch (FormatException)
                            {
                                textBox1.Clear();
                                textBox2.Clear();
                                label4.Text = "Invalid Input. Try again";
                            }
                        }

                        else if (radioButton3.Checked)
                        {
                        try
                        {
                            decimal amount = System.Convert.ToDecimal(textBox1.Text);
                            decimal converted_amount = amount * 3.07M;
                            textBox2.Text = "RM" + converted_amount.ToString();
                        }
                        catch (FormatException)
                        {
                            textBox1.Clear();
                            textBox2.Clear();
                            label4.Text = "Invalid Input. Try again";
                        }
                    }
                }
            }
        }
    }
