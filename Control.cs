using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PM2
{
    internal class Control
    {
        private double num1;
        private double num2;


        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }


        public double Suma()
        {
            return num1 + num2;
        }

        public double Resta()
        {
            return num1 - num2;
        }

        public double Multiplicacion()
        {
            return num1 * num2;
        }

        public double Division()
        {
            return num1 / num2;
        }
    }
}
