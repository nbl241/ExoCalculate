using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCalculate
{
    class DisplayOperation
    {
        public string RetrieveResult(string result)
        {
            //recupere le result
            //tu split sur l'opérateur
            //tu recup les deux chiffres en format string
            //tu converti les chiffres en string en int
            //tu choissi la bonne operation a appliquer en fonction de ce signe

            string[] ArrayNumber = result.Split('+', '-', '*', '/');
            double num1 = double.Parse(ArrayNumber[0]);
            double num2 = double.Parse(ArrayNumber[1]);

            Operation op = new Operation();

            if (result.Contains("*"))
            {
                result = (op.Multiplication(num1, num2)).ToString();
            }

            else if (result.Contains("+"))
            {
                result = (op.Addition(num1, num2)).ToString();
            }

            else if (result.Contains("-"))
            {
                result = (op.Soustraction(num1, num2)).ToString();
            }

            else if (result.Contains("/"))
            {
                result = (op.Division(num1, num2)).ToString();
            }

            return result; ;
        }
    }
}
