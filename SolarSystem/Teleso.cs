using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SolarSystem
{
    public class Teleso
    {
        internal double polomer;
        internal double hmotnost;
        internal Vektor hybnost;
        internal Vektor pozicia;
        internal Vektor pociatocna_pozicia;
        internal bool stopa;
        internal bool viditelnost;
        internal Vektor sila;
        internal double hl_poloos;
        internal double excentricita;
        internal SolidBrush farba;
        internal PictureBox kruh;
        

        //public Teleso() { }
        public Teleso(string[] zoznam, PictureBox obrazok)
        {
            kruh = obrazok;
            viditelnost = true;

            polomer = (Convert.ToDouble(zoznam[4])); //[r_Zeme]
            hmotnost = (Convert.ToDouble(zoznam[1])); //[m_Zeme]
            hl_poloos = (Convert.ToDouble(zoznam[3])); //[AU]
            excentricita = Convert.ToDouble(zoznam[2]);
            pociatocna_pozicia = new Vektor(hl_poloos, 0);

            zisti_init_hybnost();
            
            stopa = true;
            sila = new Vektor(0,0);
        }

        public double zisti_init_rychlost()
        {
            double m_slnka = 333000;
            double G = 6.67 * Math.Pow(10,-11);
            //oprava na ine jednotky
            G = G * (5.972 / 3.375) * Math.Pow(10, -9);
            double pom1 = 2 / (hl_poloos * (1 + excentricita));
            double pom2 = 1 / hl_poloos;
            double pom = Math.Sqrt(G * m_slnka * (pom1-pom2));
            return pom;
        }

        public void zisti_init_hybnost()
        {
            hybnost = Vektor.vynasob_skalarom(new Vektor(0, -1), hmotnost * zisti_init_rychlost());
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
