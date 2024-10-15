using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIO_1_classi_astratte_e_interfacce
{
    public abstract class CShape:IFiguraPiana 
    {
        public abstract double area();
        public abstract double perimetro();



    }
    public interface IFiguraPiana
    {
        double area();
        double perimetro();
    }

     public class CCircle : CShape
    {
        private float raggio;
        private const double pi = 3.14;
        public override double area()
        {
            double risultato = Math.Pow(raggio, 2);
            return risultato;
        }
       public override double perimetro()
        {
            return 2*raggio*pi;
        }   
     }
    public class CRectangle : CShape
    {
        private float b;
        private float h;

        public override double area()
        {
            return b *= h;
        }
        public override double perimetro()
        {
            return 2*(b+=h);
        }
    }

    
}
