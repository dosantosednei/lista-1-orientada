using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior maior = new Maior(7,7);
            maior.CalcularResultado();
            Console.WriteLine(maior.getMaior());
        }
    }
}
