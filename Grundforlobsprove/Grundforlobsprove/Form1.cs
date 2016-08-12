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
            try
            {
                int x = Convert.ToInt32(textBox5.Text);
                if (x > 255)
                    textBox5.Text = "" + 255;
                if (textBox5.Text.Length > 2)
                    textBox6.Focus();
                textBox9.Enabled = false;
            }
            catch (Exception)
            {
                textBox5.Text = "";
                //throw;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox9.Text);
                if (x > 30)
                    textBox9.Text = "" + 30;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
            }
            catch (Exception)
            {
                textBox9.Text = "";
                //throw;
            }
        }

        
    }
}
