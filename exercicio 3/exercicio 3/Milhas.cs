using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    internal class Quadrado2
    {
        #region Atributos
        int d;
        
        int area;
        #endregion

        #region Construtores
        public Quadrado2()
        {
            this.d = 0;
          
        }

        public Quadrado2(int d )
        {
            this.d = d;
            
        }
        #endregion

        #region Setters e Getters
        public void setDiagonal(int d)
        {
            this.d = d;
        }

        
        
            
        

        public int getDiagonal()
        {
            return this.d;
        }

        
        
           
        

        public int getresultado()
        {
            return this.area;
        }
        #endregion

        #region Métodos funcionais
        public void CalcularResultado()
        {
            this.area = (this.d*this.d) / 2;
        }
        #endregion
    }
}
