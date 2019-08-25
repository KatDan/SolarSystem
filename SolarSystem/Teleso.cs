using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem
{
    public class Teleso
    {
        internal double polomer;
        internal double hmotnost;
        internal Vektor hybnost;
        internal Vektor pozicia;
        internal bool stopa;
        internal Vektor sila;
        internal double hl_poloos;
        internal double excentricita;
        internal SolidBrush farba;
        internal Rectangle kruh;

        //public Teleso() { }
        public Teleso(string[] zoznam)
        {
            polomer = rZeme_to_m(Convert.ToDouble(zoznam[4])); //[r_Zeme]
            hmotnost = mZeme_to_kg(Convert.ToDouble(zoznam[1])); //[m_Zeme]
            hl_poloos = AU_to_m(Convert.ToDouble(zoznam[3])); //[AU]
            excentricita = Convert.ToDouble(zoznam[2]); //[ano]
            hybnost = Vektor.vynasob_skalarom(new Vektor(0, -1), hmotnost * zisti_init_rychlost()); //[m_Zeme * AU/d]
            //nedoriesena hybnost slnka v pripade geocentrickeho modelu
            //Console.WriteLine("hybnost: " + hybnost.y.ToString());
            stopa = true;
            sila = new Vektor(0,0);
        }

        public double zisti_init_rychlost()
        {
            double G = 6.67 * Math.Pow(10,-11);
            double pom1 = 2 / (hl_poloos * (1 + excentricita));
            double pom2 = 1 / hl_poloos;
            double pom = Math.Sqrt(G * hmotnost * (pom1-pom2));
            //[AU/s]
            return pom;
        }

        public static double AU_to_m(double au)
        {
            return au * 1.5 * Math.Pow(10, 11);
        }

        public static double mZeme_to_kg(double m)
        {
            return m * 5.972 * Math.Pow(10, 24);

        }

        public static double rZeme_to_m(double r)
        {
            return r * 6378000;
        }


    }
}
