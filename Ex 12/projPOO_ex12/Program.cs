using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();

            Console.Write("Insira o primeiro valor: ");
            t.setA(int.Parse(Console.ReadLine()));

            Console.Write("Insira o segundo valor: ");
            t.setB(int.Parse(Console.ReadLine()));

            Console.Write("Insira o terceiro valor: ");
            t.setC(int.Parse(Console.ReadLine()));

            t.calcularABC();

            

        }
    }
}
