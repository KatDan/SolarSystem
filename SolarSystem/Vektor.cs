using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Vektor
    {
        internal double x;
        internal double y;
        public Vektor(double xx, double yy)
        {
            x = xx;
            y = yy;
        }

        public static Vektor scitaj_vektory(Vektor a, Vektor b)
        {
            return new Vektor(a.x + b.x, a.y + b.y);
        }

        public static Vektor odcitaj_vektor(Vektor a, Vektor b)
        {
            return new Vektor(a.x - b.x, a.y - b.y);
        }

        public static double velkost_vektora(Vektor a)
        {
            return Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2));
        }

        public static Vektor vydel_skalarom(Vektor a, double b)
        {
            return new Vektor(a.x / b, a.y / b);
        }

        public static Vektor vynasob_skalarom(Vektor a, double b)
        {
            return new Vektor(a.x * b, a.y * b);
        }
    }
}
