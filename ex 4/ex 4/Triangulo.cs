using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4
{
    internal class Triangulo
    {
        #region Atributos
        int a;
        int b;
        int area;
        #endregion

        #region Construtores
        public Triangulo()
        {
            this.a = 0;
            this.b = 0;
        }

        public Triangulo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        #endregion

        #region Setters e Getters
        public void setLadoa(int a)
        {
            this.a = a;
        }

        public void setLadob(int b)
        {
            this.b = b;
        }

        public int getLadoa()
        {
            return this.a;
        }

        public int getLadob()
        {
            return this.b;
        }

        public int getresultado()
        {
            return this.area;
        }
        #endregion

        #region Métodos funcionais
        public void CalcularResultado()
        {
            this.area = (this.a * this.b) / 2;
        }
        #endregion
    }
}
