using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem
{
    public class Sustava
    {
        internal Teleso[] objekty;
        internal static double dt;
        internal static double G;

        public Sustava(double g, double t, params Teleso[] telesa)
        {
            objekty = new Teleso[telesa.Length];
            for (int i = 0; i < telesa.Length; i++)
            {
                objekty[i] = telesa[i];
            }
            nastav_pozicie();
            dt = t;
            G = g;
        }

        public void nastav_pozicie()
        {
            objekty[0].pozicia = new Vektor(0, 0);
            for (int i = 1; i < objekty.Length; i++)
            {
                objekty[i].pozicia = new Vektor(objekty[i].hl_poloos * (1 + objekty[i].excentricita), 0);
            }
        }

        public void nastav_farby(Color[] c)
        {
            for (int i = 0; i < objekty.Length; i++)
            {
                objekty[i].farba = new SolidBrush(c[i]);
            }
        }
                

        public static Vektor gravitacna_sila(Teleso a, Teleso b)
        {
            Vektor r = Vektor.odcitaj_vektor(a.pozicia, b.pozicia);
            Vektor r_jednotkovy = Vektor.vydel_skalarom(r, Vektor.velkost_vektora(r));
            double grav_sila_velkost = G * a.hmotnost * b.hmotnost / Math.Pow(Vektor.velkost_vektora(r), 2);
            return Vektor.vynasob_skalarom(r_jednotkovy, -grav_sila_velkost);
        }

        public static void update_sila(Teleso a, params Teleso[] zoznam)
        {
            a.sila = new Vektor(0, 0);
            for (int i = 0; i < zoznam.Length; i++)
            {
                if (a != zoznam[i])
                {
                    a.sila = Vektor.scitaj_vektory(a.sila, gravitacna_sila(a, zoznam[i]));
                    //Console.WriteLine(i.ToString() + " grav. sila: " + a.sila.x.ToString() + " " + a.sila.y.ToString());
                }
            }
        }

        public static void update_hybnost(Teleso a)
        {
            //Console.WriteLine("hybnost: " + a.hybnost.x.ToString() + " " + Vektor.vynasob_skalarom(a.sila, dt).x.ToString());
            a.hybnost = Vektor.scitaj_vektory(Vektor.vynasob_skalarom(a.sila, dt), a.hybnost);
        }

        public static void update_pozicia(Teleso a)
        {
            a.pozicia = Vektor.scitaj_vektory(a.pozicia, Vektor.vynasob_skalarom(Vektor.vydel_skalarom(a.hybnost, a.hmotnost), dt));
        }

    }
}
