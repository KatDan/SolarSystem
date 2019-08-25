using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SolarSystem
{
    public class Vykreslovanie
    {
        internal Vektor[] pozicie_pix_zakl;
        internal Vektor[] pozicie_pix_vykr;
        internal int[] polomery_pix;
        internal bool[] stopa;

        internal int last_index;
        internal Sustava sustava;
        internal Rectangle[] telesa;
        internal Panel panel;
        internal double k;
        internal Graphics g;
        internal Pen pen;

        internal Vektor posun;
        

        public Vykreslovanie(Sustava sus, Panel pan)
        {
            stopa = new bool[sus.objekty.Length];
            posun = new Vektor(0, 0);
            sustava = sus;
            telesa = new Rectangle[sus.objekty.Length];
            pozicie_pix_zakl = new Vektor[sus.objekty.Length];
            pozicie_pix_vykr = new Vektor[sus.objekty.Length];

            last_index = sus.objekty.Length - 1;

            polomery_pix = new int[sus.objekty.Length];
            panel = pan;
            double pom1 = panel.Size.Width - 500;
            double pom2 = sus.objekty[last_index].hl_poloos * 2;
            k = pom1/pom2;
            g = panel.CreateGraphics();

            preskaluj(sus);
            pen = new Pen(Brushes.Red);

            //potial ok

            helio();
            //pretypuj_polohove_vektory();

            for(int i = 0; i< sus.objekty.Length; i++)
            {
                telesa[i] = new Rectangle(new Point(Convert.ToInt32(pozicie_pix_vykr[i].x - polomery_pix[i]), Convert.ToInt32(pozicie_pix_vykr[i].y - polomery_pix[i])), new Size(polomery_pix[i],polomery_pix[i]));
                stopa[i] = sus.objekty[i].stopa;
                Console.WriteLine("rectangle: " + telesa[i].X + " " + telesa[i].Y + " " + telesa[i].Width + " " + telesa[i].Height);
            }
        }

        public void preskaluj(Sustava sus)
        {
            for (int i = 0; i<pozicie_pix_zakl.Length; i++)
            {
                pozicie_pix_zakl[i] = Vektor.vynasob_skalarom(sus.objekty[i].pozicia,k);
                
                pozicie_pix_zakl[i].x = Math.Round(pozicie_pix_zakl[i].x);
                pozicie_pix_zakl[i].y = Math.Round(pozicie_pix_zakl[i].y);
                Console.WriteLine("preskalovane: " + pozicie_pix_zakl[i].x.ToString() + " " + pozicie_pix_zakl[i].y.ToString());
                polomery_pix[i] = 5;
            }
        }

        public void nakresli_objekty()
        {           
            for(int i = 0; i < telesa.Length; i++)
            {
                g.FillEllipse(sustava.objekty[i].farba, telesa[i]);
                panel.Update();
                //Console.WriteLine("kreslim " + telesa[i].X.ToString());
                //g.FillEllipse(sustava.objekty[i].farba, new Rectangle(1320, 410, 10, 10));
            }
            //g.FillEllipse(sustava.objekty[1].farba, new Rectangle(150,0,25,25));
            panel.Update();
            //g.Dispose();
        }

        public void helio()
        {
            double p = 1 - sustava.objekty[last_index].excentricita;
            Vektor pom = new Vektor(sustava.objekty[last_index].hl_poloos * p, 0);
            posun = Vektor.vynasob_skalarom(pom, k);
            posun.y = panel.Size.Height / 2;

            pretypuj_polohove_vektory();
        }

        public void geo()
        {
            Vektor pom1 = new Vektor(sustava.objekty[last_index].hl_poloos * (1 - sustava.objekty[last_index].excentricita), 0);
            Vektor helio = Vektor.vynasob_skalarom(pom1, k);
            helio.y = panel.Size.Height / 2;

            Vektor pom2 = pozicie_pix_zakl[3];
            posun = Vektor.scitaj_vektory(helio, pom2);
            pretypuj_polohove_vektory();
        }

        public void pretypuj_polohove_vektory()
        {
            Console.WriteLine("posun: "+ posun.x.ToString());
            for(int i = 0; i < pozicie_pix_zakl.Length; i++)
            {
                pozicie_pix_vykr[i] = Vektor.scitaj_vektory(posun, pozicie_pix_zakl[i]);
                Console.WriteLine(pozicie_pix_vykr[i].x.ToString() + " " + pozicie_pix_vykr[i].y.ToString());
            }
        }

        public void updateni_pozicie()
        {
            preskaluj(sustava);
            helio();
            for (int i = 0; i < pozicie_pix_vykr.Length; i++ )
            {
                Rectangle pom = new Rectangle(Convert.ToInt32(pozicie_pix_vykr[i].x), Convert.ToInt32(pozicie_pix_vykr[i].y), 2,2);
                if (i % 2 == 0) pen.Color = Color.Blue;
                else pen.Color = Color.Red;
                g.DrawRectangle(pen,pom);
                panel.Update();

                telesa[i].X = Convert.ToInt32(pozicie_pix_vykr[i].x) - polomery_pix[i];
                telesa[i].Y = Convert.ToInt32(pozicie_pix_vykr[i].y) - polomery_pix[i];
                panel.Update();
                Console.WriteLine("pozicia: " + pozicie_pix_vykr[i].x.ToString() + pozicie_pix_vykr[i].y.ToString());

                //pen.Dispose();
            }
            
        }

    }
}
