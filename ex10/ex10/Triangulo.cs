using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class Triangulo
    {
        #region Atributos
        double baze;

        double alti;
        double area;
        #endregion

        #region Construtores
        public Triangulo()
        {
            this.baze = 0;
            this.alti = 0;
        }

        public Triangulo(double baze, double alti)
        {

            this.baze = baze;
            this.alti = alti;
        }
        #endregion

        #region Setters e Getters
        public void setBaze(double baze)
        {
            this.baze = baze;
        }
        public void setAlti(double alti)
        {
            this.alti = alti;
        }





        public double getBaze()
        {
            return this.baze;
        }

        public double getAlti()
        {
            return this.alti;
        }

        public double getArea()
        {
            return this.area;
        }










        #endregion

        #region Métodos funcionais
        public void CalcularResultado()
        {
            this.area= this.baze* this.alti;
            if ((this.baze * this.alti)> 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
            #endregion
        }
    }
}