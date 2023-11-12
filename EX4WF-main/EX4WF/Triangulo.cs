using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4WF
{
    internal class Triangulo
    {
        private double baseTriangulo;

        private double alturaTriangulo;



        public Triangulo(double baseTriangulo, double alturaTriangulo)

        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public Triangulo()

        {
            this.baseTriangulo = 0;
            this.alturaTriangulo = 0;
        }

        public void setBase(double baseTriangulo)
        { 
            this.baseTriangulo = baseTriangulo; 
        }

        public void setAltura(double alturaTriangulo)
        {
            this.alturaTriangulo = alturaTriangulo;
        }

        public double getBase()
        {
            return baseTriangulo;
        }

        public double getAltura()
        {
            return alturaTriangulo;
        }

        public double CalcularArea()

        {

            return (baseTriangulo * alturaTriangulo) / 2;

        }
    }
}
