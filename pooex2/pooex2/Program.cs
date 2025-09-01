using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(9,9);
            quadrado.CalcularResultado();
            Console.WriteLine(quadrado.getresultado());
        }
    }
}
