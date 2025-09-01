using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{

    internal class Maior
    {
        #region Atributos
        double valo1;

        double valo2;
        double maior;
        #endregion

        #region Construtores
        public Maior()
        {
            this.valo1 = 0;
            this.valo2 = 0;
        }

        public Maior(double valo1, double valo2)
        {

            this.valo1 = valo1;
            this.valo2 = valo2;
        }
        #endregion

        #region Setters e Getters
        public void setValo1(double valo1)
        {
            this.valo1 = valo1;
        }
        public void setValo2(double valo2)
        {
            this.valo2 = valo2;
        }





        public double getValo1()
        {
            return this.valo1;
        }

        public double getValo2()
        {
            return this.valo2;
        }

        public double getMaior()
        {
            return this.maior;
        }










        #endregion

        #region Métodos funcionais
        public void CalcularResultado()
        {
            if (this.valo1 > this.valo2)
            {
                this.maior = this.valo1;
            }
            else if (this.valo1 < this.valo2)
            {
                this.maior = this.valo2;
            }
            else
            {
                Console.WriteLine("os valores são iguais");
            }
        }

        #endregion
    }
}
