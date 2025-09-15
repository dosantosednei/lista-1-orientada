using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex12
{
    internal class Triangulo
    {
        private int a;
        private int b;
        private int c;
        private int tr;

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

        public void setTr(int tr)
        {
            this.tr = tr;
        }

        public int getTr(int tr)
        {
            return this.tr;
        }



        public void calcularABC()
        {

            if (a + b > c && a + c > b && c + b > c)
            {
                
                Console.Write("Forma triangulo.");
            }
            else
            {
                Console.Write("Nao forma triangulo.");
            }


            if (a == c && a == b && b == c)
            {
                Console.Write(" E sua classificacao e 'Equilatero'.");
            }
            else
            {
                if (a == c || c == b || b == a)
                    Console.WriteLine(" E sua classificacao e 'Isoceles'.");
            }
            if (a != c && a != b && b != c)
            {
                Console.WriteLine(" E sua classificacao e 'Escaleno");
            }
        }



    }
    
    
}


