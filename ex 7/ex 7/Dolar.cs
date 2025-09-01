using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7
{
    internal class Dolar
    {
        #region Atributos
        double dolar;

        double real;
        #endregion

        #region Construtores
        public Dolar()
        {
            this.real = 0;
            this.dolar = 0;
        }

        public Dolar(double dolar)
        {

            this.dolar = dolar;
        }
        #endregion

        #region Setters e Getters
        public void setDolar(double dolar)
        {
            this.dolar = dolar;
        }






        public double getDolar()
        {
            return this.dolar;
        }






        public double getresultado()
        {
            return this.real;
        }
        #endregion

        #region Métodos funcionais
        public void CalcularResultado()
        {
            this.real = this.dolar * 5.45;
        }
        #endregion
    }
}
