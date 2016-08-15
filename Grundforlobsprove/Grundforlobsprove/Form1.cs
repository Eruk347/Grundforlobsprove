using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grundforlobsprove
{
    public partial class Form1 : Form
    {
        int slash = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                if (x > 255)
                    textBox1.Text = "" + 255;
                if (textBox1.Text.Length > 2)
                    textBox2.Focus();
            }
            catch (Exception)
            {
                textBox1.Text = "";
                //throw;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox2.Text);
                if (x > 255)
                    textBox2.Text = "" + 255;
                if (textBox2.Text.Length > 2)
                    textBox3.Focus();

            }
            catch (Exception)
            {
                textBox2.Text = "";
                //throw;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox3.Text);
                if (x > 255)
                    textBox3.Text = "" + 255;
                if (textBox3.Text.Length > 2)
                    textBox4.Focus();

            }
            catch (Exception)
            {
                textBox3.Text = "";
                //throw;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox4.Text);
                if (x > 255)
                    textBox4.Text = "" + 255;
                if (textBox4.Text.Length > 2)
                    textBox5.Focus();

            }
            catch (Exception)
            {
                textBox4.Text = "";
                //throw;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text.Length > 2)
                {
                    int x = Convert.ToInt32(textBox6.Text);
                    if (x > 255)
                        textBox6.Text = "" + 255;
                    else
                    {
                        switch (x)
                        {
                            case 254:
                                textBox9.Text = "15";
                                break;
                            case 252:
                                textBox9.Text = "14";
                                break;
                            case 248:
                                textBox9.Text = "13";
                                break;
                            case 240:
                                textBox9.Text = "12";
                                break;
                            case 224:
                                textBox9.Text = "11";
                                break;
                            case 192:
                                textBox9.Text = "10";
                                break;
                            case 128:
                                textBox9.Text = "9";
                                break;
                            default:
                                textBox9.Text = "16";
                                break;
                        }
                        textBox7.Text = "0";
                        textBox8.Text = "0";
                    }
                    if (textBox6.Text.Length > 2&& slash==0)
                        textBox7.Focus();
                    //textBox9.Enabled = false;
                }

            }
            catch (Exception)
            {
                textBox6.Text = "";
                //throw;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox7.Text);
                if (x > 255)
                    textBox7.Text = "" + 255;
                else
                {
                    switch (x)
                    {
                        case 254:
                            textBox9.Text = "23";
                            break;
                        case 252:
                            textBox9.Text = "22";
                            break;
                        case 248:
                            textBox9.Text = "21";
                            break;
                        case 240:
                            textBox9.Text = "20";
                            break;
                        case 224:
                            textBox9.Text = "19";
                            break;
                        case 192:
                            textBox9.Text = "18";
                            break;
                        case 128:
                            textBox9.Text = "17";
                            break;
                        case 0:
                            break;
                        default:
                            textBox9.Text = "24";
                            break;
                    }
                    textBox8.Text = "0";
                }
                if (textBox7.Text.Length > 2 && slash == 0)
                    textBox8.Focus();
                //textBox9.Enabled = false;
            }
            catch (Exception)
            {
                textBox7.Text = "";
                //throw;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox8.Text);
                if (x > 255)
                    textBox8.Text = "" + 255;
                else
                {
                    switch (x)
                    {
                        case 252:
                            textBox9.Text = "30";
                            break;
                        case 248:
                            textBox9.Text = "29";
                            break;
                        case 240:
                            textBox9.Text = "28";
                            break;
                        case 224:
                            textBox9.Text = "27";
                            break;
                        case 192:
                            textBox9.Text = "26";
                            break;
                        case 128:
                            textBox9.Text = "25";
                            break;

                        default:
                            //textBox9.Text = "24";
                            break;
                    }
                }
                if (textBox8.Text.Length > 2 && slash == 0)
                    button1.Focus();
                //textBox9.Enabled = false;


            }
            catch (Exception)
            {
                textBox8.Text = "";
                //throw;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)// slash notation
        {
            slash = 1;
            try
            {
                int x = Convert.ToInt32(textBox9.Text);
                if (x > 30)
                    textBox9.Text = "" + 30;
                if(x>24)
                {
                    textBox6.Text="255";
                    textBox7.Text = "255";
                    int sub = x - 24;
                    double mask = 0 ;
                    for (int i = 0; i < sub; i++)
                    {
                         mask+=Math.Pow(2, 7 - i);
                    }
                    textBox8.Text = ""+mask;
                }
                
            }
            catch (Exception)
            {
                textBox9.Text = "";
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ip = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text) };
            int[] sub = { Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text) };
            int[] ip_sub=new int[4];
            for (int i = 0; i < 4; i++)
            {
                ip_sub[i] = ip[i] & sub[i];
            }
            textBox10.Text = "" + ip_sub[0]+"."+ ip_sub[1] + "." + ip_sub[2] + "." + ip_sub[3];
        }
    }
}
