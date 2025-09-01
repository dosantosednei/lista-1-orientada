using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(10);
            dolar.CalcularResultado();
            Console.WriteLine(dolar.getresultado());
        }
    }
}
