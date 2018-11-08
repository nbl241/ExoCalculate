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

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Text += "9";
        }

        private void textBox_Result(object sender, EventArgs e)
        {
            
        }

        private void button_Efface_Click(object sender, EventArgs e)
        {
            textBox_Resultat.Clear();
        }

        private void button_Multiple_Click(object sender, EventArgs e)
        {

        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            //creer methode pour additionner
            Operation operation = new Operation();

        }

        private void button_Egale_Click(object sender, EventArgs e)
        {

        }

        private void button_Divise_Click(object sender, EventArgs e)
        {

        }
    }
}
