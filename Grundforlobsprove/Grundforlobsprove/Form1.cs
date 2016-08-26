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
        Int16 slash = 0;
        public Form1()
        {
            InitializeComponent();
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private int maskToSlash(int x, int slashNote)
        {
            string slashBit = decToBit(x);
            for (int i = 0; i < slashBit.Length; i++)
            {
                if (slashBit.Substring(i, 1) == "1")
                    slashNote++;
            }
            return slashNote;
        }

        private int bitToDec(string input)
        {
            int[] binary = { 128, 64, 32, 16, 8, 4, 2, 1 };
            int[] deci = new int[8];
            for (int i = 0; i < input.Length; i++)
            {
                deci[i] = Convert.ToInt32(input.Substring(i, 1));
                deci[i] = deci[i] & binary[i];
            }
            return deci.Sum();
        }

        private string decToBit(int x)
        {
            string final = "";

            if (x - 128 >= 0)
            {
                final += "1";
                x -= 128;
            }
            else final += "0";

            if (x - 64 >= 0)
            {
                final += "1";
                x -= 64;
            }
            else final += "0";
            if (x - 32 >= 0)
            {
                final += "1";
                x -= 32;
            }
            else final += "0";
            if (x - 16 >= 0)
            {
                final += "1";
                x -= 16;
            }
            else final += "0";
            if (x - 8 >= 0)
            {
                final += "1";
                x -= 8;
            }
            else final += "0";
            if (x - 4 >= 0)
            {
                final += "1";
                x -= 4;
            }
            else final += "0";
            if (x - 2 >= 0)
            {
                final += "1";
                x -= 2;
            }
            else final += "0";
            if (x - 1 >= 0)
            {
                final += "1";
                x -= 1;
            }
            else final += "0";
            return final;
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
                if (slash != 1)
                {
                    slash = 2;
                    if (textBox6.Text.Length > 2)
                    {
                        int x = Convert.ToInt32(textBox6.Text);
                        if (x > 255)
                            textBox6.Text = "" + 255;
                        else
                        {
                            textBox9.Text = "" + maskToSlash(x, 8);
                            textBox7.Text = "0";
                            textBox8.Text = "0";
                        }
                        if (textBox6.Text.Length > 2)
                            textBox7.Focus();
                    }
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
                if (slash != 1)
                {
                    slash = 2;
                    int x = Convert.ToInt32(textBox7.Text);
                    if (x > 255)
                        textBox7.Text = "" + 255;
                    else
                    {
                        textBox9.Text = "" + maskToSlash(x, 16);
                        textBox8.Text = "0";
                    }
                    if (textBox7.Text.Length > 2)
                        textBox8.Focus();
                }
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
                if (slash != 1)
                {
                    slash = 2;
                    int x = Convert.ToInt32(textBox8.Text);
                    if (x > 255)
                        textBox8.Text = "" + 255;
                    else if (Convert.ToInt32(textBox7.Text) > 254)
                    {
                        textBox9.Text = "" + maskToSlash(x, 24);
                    }
                    if (textBox8.Text.Length > 2)
                        button1.Focus();
                }
            }
            catch (Exception)
            {
                textBox8.Text = "";
                //throw;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)// slash notation
        {
            try
            {
                if (slash != 2)
                {
                    slash = 1;
                    int x = Convert.ToInt32(textBox9.Text);
                    if (x > 30)
                        textBox9.Text = "" + 30;
                    else if (x > 24)
                    {
                        textBox6.Text = "255";
                        textBox7.Text = "255";
                        int sub = x - 24;
                        double mask = 0;
                        for (int i = 0; i < sub; i++)
                        {
                            mask += Math.Pow(2, 7 - i);
                        }
                        textBox8.Text = "" + mask;
                    }
                    else if (x > 16)
                    {
                        textBox6.Text = "255";
                        int sub = x - 16;
                        double mask = 0;
                        for (int i = 0; i < sub; i++)
                        {
                            mask += Math.Pow(2, 7 - i);
                        }
                        textBox7.Text = "" + mask;
                        textBox8.Text = "0";
                    }
                    else
                    {
                        int sub = x - 8;
                        double mask = 0;
                        for (int i = 0; i < sub; i++)
                        {
                            mask += Math.Pow(2, 7 - i);
                        }
                        textBox6.Text = "" + mask;
                        textBox7.Text = "0";
                        textBox8.Text = "0";
                    }
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
            try
            {
                slash = 0;
                int[] ip = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text) };
                int[] sub = { Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text) };
                int[] ip_sub = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    ip_sub[i] = ip[i] & sub[i];
                }
                label6.Text = "" + ip_sub[0] + "." + ip_sub[1] + "." + ip_sub[2] + "." + ip_sub[3];
                label8.Text = "" + textBox5.Text + "." + textBox6.Text + "." + textBox7.Text + "." + textBox8.Text;
                label9.Text = "";

                int hostBits = 0;
                string[] subBit = new string[4];
                subBit[0] = "11111111";
                for (int i = 1; i < sub.Length; i++)
                {
                    subBit[i] = decToBit(sub[i]);
                    for (int j = 0; j < subBit[i].Length; j++)
                    {
                        if (Convert.ToInt32(subBit[i].Substring(j, 1)) == 0)
                        {
                            hostBits++;
                        }
                    }
                }

                if(sub[1]<255)
                {
                    label7.Text = "" + ip_sub[0] + "."+ip_sub[1]+".255.255";
                }
                else if(sub[2]<255)
                {
                    label7.Text = "" + ip_sub[0] + "." + ip_sub[1]+"."+ip_sub[2] + ".255";
                }
                else
                    label7.Text = "" + ip_sub[0] + "." + ip_sub[1] + "." + ip_sub[2] + "." + (ip_sub[3] + Math.Pow(2, hostBits) - 1);

                label9.Text = "" + (Math.Pow(2, hostBits) - 2);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            slash = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }
    }
}
