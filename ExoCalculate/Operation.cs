using System;
using System.Windows;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCalculate
{
    public class Operation
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Soustraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Attention division par zero impossible !!");
                }
                return num1 / num2;
            }
            catch(DivideByZeroException exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
    }
}
