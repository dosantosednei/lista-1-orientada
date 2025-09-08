using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso_altura
{
    internal class Peso
    {
        #region Atributos
        double a;
        double b;
        double r;
        #endregion

        #region Construtores
        public Peso()
        {
            this.a = 0;
            this.b = 0;
            this.r = 0;
        }

        public Peso(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        #endregion

        #region Setters e Getters
        public void setAltura(double a)
        {
            this.a = a;
        }

        public void setPeso(double b)
        {
            this.b = b;
        }

        public double getAltura()
        {
            return this.a;
        }

        public double getPeso()
        {
            return this.b;
        }

        public double getRelacao()
        {
            return this.r;
        }
        #endregion

         
        public void CalcularRelacao()
        {
            this.r = this.b / (this.a * this.a);
            if(this.r < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (this.r >= 25)
            {
                Console.WriteLine("Acima do peso");
            }
            if (this.r >= 20 && this.r < 25)
            {
                Console.WriteLine("Peso ideal");
            }
        }
    }
}