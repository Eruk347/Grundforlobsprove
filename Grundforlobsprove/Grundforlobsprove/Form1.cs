using System;
using System.Linq;
using System.Windows.Forms;

/**************************************************************
        *A function 
        *
        *Inputs:
        *    
        *
        *Output:
        *    
        *************************************************************/

namespace Grundforlobsprove
{
    public partial class Form1 : Form
    {
        Int16 slash = 0;
        public Form1()
        {
            InitializeComponent();

            //The information labels are made empty to hide them
            netAddShow.Text = "";
            broadAddShow.Text = "";
            subMaskShow.Text = "";
            useAddShow.Text = "";
        }

        /**************************************************************
        *A function to determine how many bits are being "borrowed
        *from the host bits, to use as network bits
        *
        *Inputs:
        *    X: A 32 bit integer, that is the netmask value of the bits
        *       that will be used for subnetting
        *    slashNote: A 32 bit integer, the default number of bits
        *        used for the netmask (8, 16 or 24)
        *
        *Output:
        *    slashNote: A 32 bit integer, a recalculated version of the
        *        input with the same name, to fit the slashnotation 
        *        with the subnetmask, that has been entered.
        *************************************************************/
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

        /**************************************************************
        *A function to convert a binary number to decimal.
        *
        *Inputs:
        *   input: A string 
        *    
        *
        *Output:
        *    
        *************************************************************/
        private int bitToDec(string input)
        {
            int[] binary = new int[input.Length];
            int start = 0;
            int[] deci = new int[8];
            for (int i = input.Length-1; i>-1; i--)
            {
                start = (int)Math.Pow(2, i);
                deci[i] = Convert.ToInt32(input.Substring(7-i, 1));
                if (deci[i] == 1)
                    deci[i] = start;
            }
            return deci.Sum();
        }

        private string decToBit(int x)
        {
            int y = 0;
            int bin = 1;
            while (x>bin)
            {
                bin = bin * 2;
                y++;
            }
            bin =bin/2;
            string final = "";

            while(y>0)
            {
                if (x - bin >= 0)
                {
                    final += "1";
                    x -= bin;
                }
                else
                    final += "0";
                bin = bin / 2;
                y--;
            }
            return final;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(ipAd01.Text);
                if (x > 255)
                    ipAd01.Text = "" + 255;
                if (ipAd01.Text.Length > 2)
                    ipAd02.Focus();
            }
            catch (Exception)
            {
                ipAd01.Text = "";
                //throw;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(ipAd02.Text);
                if (x > 255)
                    ipAd02.Text = "" + 255;
                if (ipAd02.Text.Length > 2)
                    ipAd03.Focus();

            }
            catch (Exception)
            {
                ipAd02.Text = "";
                //throw;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(ipAd03.Text);
                if (x > 255)
                    ipAd03.Text = "" + 255;
                if (ipAd03.Text.Length > 2)
                    ipAd04.Focus();

            }
            catch (Exception)
            {
                ipAd03.Text = "";
                //throw;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(ipAd04.Text);
                if (x > 255)
                    ipAd04.Text = "" + 255;
                if (ipAd04.Text.Length > 2)
                    subMa01.Focus();

            }
            catch (Exception)
            {
                ipAd04.Text = "";
                //throw;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (slash != 1)
                {
                    slash = 2;
                    if (subMa02.Text.Length > 2)
                    {
                        int x = Convert.ToInt32(subMa02.Text);
                        if (x > 255)
                            subMa02.Text = "" + 255;
                        else
                        {
                            slashNotation.Text = "" + maskToSlash(x, 8);
                            subMa03.Text = "0";
                            subMa04.Text = "0";
                        }
                        if (subMa02.Text.Length > 2)
                            subMa03.Focus();
                    }
                }
            }
            catch (Exception)
            {
                subMa02.Text = "";
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
                    int x = Convert.ToInt32(subMa03.Text);
                    if (x > 255)
                        subMa03.Text = "" + 255;
                    else
                    {
                        slashNotation.Text = "" + maskToSlash(x, 16);
                        subMa04.Text = "0";
                    }
                    if (subMa03.Text.Length > 2)
                        subMa04.Focus();
                }
            }
            catch (Exception)
            {
                subMa03.Text = "";
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
                    int x = Convert.ToInt32(subMa04.Text);
                    if (x > 255)
                        subMa04.Text = "" + 255;
                    else if (Convert.ToInt32(subMa03.Text) > 254)
                    {
                        slashNotation.Text = "" + maskToSlash(x, 24);
                    }
                    if (subMa04.Text.Length > 2)
                        Calculate.Focus();
                }
            }
            catch (Exception)
            {
                subMa04.Text = "";
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
                    int x = Convert.ToInt32(slashNotation.Text);
                    if (x > 30)
                        slashNotation.Text = "" + 30;
                    else if (x > 24)
                    {
                        subMa02.Text = "255";
                        subMa03.Text = "255";
                        int sub = x - 24;
                        double mask = 0;
                        for (int i = 0; i < sub; i++)
                        {
                            mask += Math.Pow(2, 7 - i);
                        }
                        subMa04.Text = "" + mask;
                    }
                    else if (x > 16)
                    {
                        subMa02.Text = "255";
                        int sub = x - 16;
                        double mask = 0;
                        for (int i = 0; i < sub; i++)
                        {
                            mask += Math.Pow(2, 7 - i);
                        }
                        subMa03.Text = "" + mask;
                        subMa04.Text = "0";
                    }
                    else
                    {
                        int sub = x - 8;
                        double mask = 0;
                        for (int i = 0; i < sub; i++)
                        {
                            mask += Math.Pow(2, 7 - i);
                        }
                        subMa02.Text = "" + mask;
                        subMa03.Text = "0";
                        subMa04.Text = "0";
                    }
                }
            }
            catch (Exception)
            {
                slashNotation.Text = "";
                //throw;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                slash = 0;
                int[] ip = { Convert.ToInt32(ipAd01.Text), Convert.ToInt32(ipAd02.Text), Convert.ToInt32(ipAd03.Text), Convert.ToInt32(ipAd04.Text) };
                int[] sub = { Convert.ToInt32(subMa01.Text), Convert.ToInt32(subMa02.Text), Convert.ToInt32(subMa03.Text), Convert.ToInt32(subMa04.Text) };
                int[] ip_sub = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    ip_sub[i] = ip[i] & sub[i];
                }
                netAddShow.Text = "" + ip_sub[0] + "." + ip_sub[1] + "." + ip_sub[2] + "." + ip_sub[3];
                subMaskShow.Text = "" + subMa01.Text + "." + subMa02.Text + "." + subMa03.Text + "." + subMa04.Text;
                useAddShow.Text = "";

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

                if (sub[1] < 255)
                {
                    broadAddShow.Text = "" + ip_sub[0] + "." + ip_sub[1] + ".255.255";
                }
                else if (sub[2] < 255)
                {
                    broadAddShow.Text = "" + ip_sub[0] + "." + ip_sub[1] + "." + ip_sub[2] + ".255";
                }
                else
                    broadAddShow.Text = "" + ip_sub[0] + "." + ip_sub[1] + "." + ip_sub[2] + "." + (ip_sub[3] + Math.Pow(2, hostBits) - 1);

                useAddShow.Text = "" + (Math.Pow(2, hostBits) - 2);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            slash = 0;
            ipAd01.Text = "";
            ipAd02.Text = "";
            ipAd03.Text = "";
            ipAd04.Text = "";
            subMa02.Text = "";
            subMa03.Text = "";
            subMa04.Text = "";
            slashNotation.Text = "";
            netAddShow.Text = "";
            broadAddShow.Text = "";
            subMaskShow.Text = "";
            useAddShow.Text = "";
        }
    }
}
