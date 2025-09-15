using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex13
{
    internal class Triangulo2
    {
        private int a;
        private int b;
        private int c;

        public void setA(int a)
        {
            this.a = a;
        }

        public int getA(int a)
        {
            return this.a;
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public int getB()
        {
            return this.b;
        }

        public void setC(int c)
        {
            this.c = c;
        }

        public int getC()
        {
            return this.c;
        }

        public void calcularABC()
        {
            if ((c * c) == (a * a) + (b * b) || (b * b) == (a * a) + (c * c) || (a * a) == (c * c) + (b * b))
            {
                Console.Write("Forma triangulo retangulo.");

            }
            else
            {
                Console.Write("Nao forma triangulo retangulo.");
            }
        }












    }
}
