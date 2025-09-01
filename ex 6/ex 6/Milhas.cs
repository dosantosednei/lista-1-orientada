using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6
{
    internal class Milhas
    {
        #region Atributos
        double milha;
        
        double km;
        #endregion

        #region Construtores
        public Milhas()
        {
            this.km = 0;
            this.milha = 0;
        }

        public Milhas(double milha)
        {
            
            this.milha = milha;
        }
        #endregion

        #region Setters e Getters
        public void setMilha(double milha)
        {
            this.milha = milha;
        }

        
        
           
        

        public double getMilha()
        {
            return this.milha;
        }

        
        
           
        

        public double getresultado()
        {
            return this.km;
        }
        #endregion

        #region Métodos funcionais
        public void CalcularResultado()
        {
            this.km = this.milha * 1.852;
        }
        #endregion
    }
}
