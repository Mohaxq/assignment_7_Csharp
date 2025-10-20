using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7
{
    internal class Complex
    {
        private double real;
        private double img;
        public Complex(double r,double i)
        {
            real = r;
            img = i;
        }
        public Complex()
        {
            real = 0;
            img = 0;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex complex = new Complex();
            complex.real = c1.real + c2.real;
            complex.img = c1.img + c2.img;
            return complex;
        }
        override public string ToString()
        {
            return $"{real} + {img}i";
        }
    }
}
