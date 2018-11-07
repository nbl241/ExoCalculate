using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExoCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "9";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //creer methode pour additionner
            Operation operation = new Operation();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button_Efface_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Clear();
        }
    }
}
