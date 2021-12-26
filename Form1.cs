using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            double var1 = Double.Parse(textBoxInput1.Text);


            double var2=Double.Parse(textBoxInput2.Text);

            if (comboBox1.SelectedItem.ToString()=="Плюс")
            {
                textBoxRes.Text = (var1 + var2).ToString();   
            }
            else if  (comboBox1.SelectedItem.ToString() == "Минус")
            {
                textBoxRes.Text = (var1 - var2).ToString();
            }
           else if (comboBox1.SelectedItem.ToString() == "Разделить")
            {
                textBoxRes.Text = (var1 / var2).ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "Умножить")
            {
                textBoxRes.Text = (var1 * var2).ToString();
            }


        }
    }
}
