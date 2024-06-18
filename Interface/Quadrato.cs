using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Quadrato : FiguraGeometrica
    {
        public Quadrato(double l) : base(l) 
        {
            
        }

        public override double Perimetro()
        {
            var perimetro = Lato * 4;
            return perimetro;
        }

        public override double Area()
        {
            var Area = Lato * Lato;
            return Area;
        }

    }
}
