using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso_altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso p = new Peso();

            Console.WriteLine("Digite o peso: ");
            p.setPeso(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a altura");
            p.setAltura(double.Parse(Console.ReadLine()));
            p.CalcularRelacao();
            Console.WriteLine((p.getRelacao()));
        }
    }
}
