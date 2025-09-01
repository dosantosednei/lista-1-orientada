using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milhas milhas = new Milhas(6);
            milhas.CalcularResultado();
            Console.WriteLine(milhas.getresultado());
        }
    }
}
