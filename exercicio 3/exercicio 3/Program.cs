using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado2 quadrado2 = new Quadrado2( 8);
            quadrado2.CalcularResultado();
            Console.WriteLine(quadrado2.getresultado());
        }
    }
}
