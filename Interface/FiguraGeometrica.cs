using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
        public abstract class FiguraGeometrica : IFiguraGeometrica
    {
        public double Lato { get; set; }

        public FiguraGeometrica(double lato)
        {
            Lato = lato;
        }

        public abstract double Perimetro();
        public abstract double Area();
        public virtual string StampaInfo()
        {
            var perimetro = Perimetro();
            var area = Area();
            var nome = GetType().Name;
            var messaggio = $"Il {nome} ha un perimetro di: {perimetro}, L'area è: {area}, il lato misura: {Lato} ";

            return messaggio;
        }
    }
}
