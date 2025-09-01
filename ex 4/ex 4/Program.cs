using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(8,9);
            triangulo.CalcularResultado();
            Console.WriteLine(triangulo.getresultado());
        }
    }
}
