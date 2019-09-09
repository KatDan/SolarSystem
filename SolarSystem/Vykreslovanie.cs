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
        internal Vektor[] vychodzia_pozicia;
        internal int[] polomery_pix;
        internal bool[] stopa;
        internal List<Point>[] pom_body;

        internal int last_index;
        internal Sustava sustava;
        internal PictureBox[] telesa;
        internal Panel panel;
        internal double k;
        internal static Graphics g;
        internal Pen pen;
        internal int t;

        internal Vektor[] posun;
        

        public Vykreslovanie(Sustava sus, Panel pan)
        {
            t = 0;
            stopa = new bool[sus.objekty.Length];
            posun = new Vektor[sus.objekty.Length];
            sustava = sus;
            telesa = new PictureBox[sus.objekty.Length];
            pozicie_pix_zakl = new Vektor[sus.objekty.Length];
            pozicie_pix_vykr = new Vektor[sus.objekty.Length];
            polomery_pix = new int[sus.objekty.Length];
            pom_body = new List<Point>[sus.objekty.Length];
            vychodzia_pozicia = new Vektor[sus.objekty.Length];

            last_index = sus.objekty.Length - 1;

            //polomery_pix = new int[sus.objekty.Length];
            panel = pan;
            double pom1 = panel.Size.Height - 40;
            double pom2 = sus.objekty[last_index].hl_poloos * 2;
            k = pom1/pom2;
            //Console.WriteLine(k);
            g = panel.CreateGraphics();
            
            for(int i = 0; i <sus.objekty.Length; i++)
            {
                pom_body[i] = new List<Point>();
            }

            preskaluj(sus);
            pen = new Pen(Brushes.Red);

            //potial ok

            if (sustava.mod == true) helio();
            else geo();
            //pretypuj_polohove_vektory();

            for (int i = 0; i< sus.objekty.Length; i++)
            {
                telesa[i] = sustava.objekty[i].kruh;
                telesa[i].Location = new Point((int)(pozicie_pix_vykr[i].x - polomery_pix[i]), (int)(pozicie_pix_vykr[i].y - polomery_pix[i]));
                stopa[i] = sus.objekty[i].stopa;
                vychodzia_pozicia[i] = new Vektor(telesa[i].Location.X, telesa[i].Location.Y);

                //Console.WriteLine("rectangle: " + telesa[i].X + " " + telesa[i].Y + " " + telesa[i].Width + " " + telesa[i].Height);
            }
            
        }

        public void nastav_konstantu_a_ostatne_veci_tak_aby_sa_spravne_rozmiestnili_planety()
        {
            //int last_index = 0;

            for (int i = 0; i < polomery_pix.Length; i++)
            {
                if (sustava.objekty[i].viditelnost == true) last_index = i; ;
            }
            if(sustava.mod == true)
            {
                double pom1 = panel.Size.Height - 40;
                double pom2 = sustava.objekty[last_index].hl_poloos * 2;
                k = pom1 / pom2;
            }
            else
            {
                double pom1 = panel.Size.Height - 40;
                double pom2 = (sustava.objekty[last_index].hl_poloos + sustava.objekty[3].hl_poloos) * 2;
                k = pom1 / pom2;
            }
            

            if (sustava.mod == true) helio();
            else geo();
            preskaluj(sustava);
        }

        public void nastav_polomery()
        {
            int[] mierka = new int[] { 45, 7, 9, 10, 7, 9, 40, 30, 20, 20 };
            List<int> indexy_viditelne_planety = new List<int>();

            for (int i = 0; i < polomery_pix.Length; i++)
            {
                polomery_pix[i] = mierka[i];
                if (sustava.objekty[i].viditelnost == true) indexy_viditelne_planety.Add(i);
            }
            if(indexy_viditelne_planety.Count >= 2)
            {
                double a = pozicie_pix_vykr[indexy_viditelne_planety[1]].x - pozicie_pix_vykr[indexy_viditelne_planety[0]].x;
                double b = a * Math.Sqrt(1 - Math.Pow(sustava.objekty[indexy_viditelne_planety[1]].excentricita, 2));
                double pom = 2 *mierka[indexy_viditelne_planety[0]] + mierka[indexy_viditelne_planety[1]] + 30;
                double k = b / pom;

                for (int i = 0; i < polomery_pix.Length; i++)
                {
                    polomery_pix[i] = (int)(polomery_pix[i] * k);
                    if (polomery_pix[i] == 0) polomery_pix[i] = 1;

                    Console.WriteLine("polomer : " + polomery_pix[i] * (int)k);
                    telesa[i].Size = new Size((int)(2 * polomery_pix[i]), (int)(2 * polomery_pix[i]));
                    telesa[i].BringToFront();
                }
                updateni_pozicie();
                panel.Update();
            }
        }

        //prenasobi skutocne hodnoty konstantou
        public void preskaluj(Sustava sus)
        {
            for (int i = 0; i<pozicie_pix_zakl.Length; i++)
            {
                pozicie_pix_zakl[i] = Vektor.vynasob_skalarom(sus.objekty[i].pozicia,k);
                
                pozicie_pix_zakl[i].x = Math.Round(pozicie_pix_zakl[i].x);
                pozicie_pix_zakl[i].y = Math.Round(pozicie_pix_zakl[i].y);
            }
        }

        public void nakresli_objekty()
        {
            updateni_pozicie();
        }

        public void helio()
        {
            double p = 1 - sustava.objekty[last_index].excentricita;
            Vektor pom = new Vektor(sustava.objekty[last_index].hl_poloos * p, 0);
            for(int i =0; i < sustava.objekty.Length; i++)
            {
                posun[i] = Vektor.vynasob_skalarom(pom, k);
                posun[i].x += 50;
                posun[i].y = panel.Size.Height / 2;
            }
            

            pretypuj_polohove_vektory();
        }

        public void geo()
        {
            for(int i = 0; i < sustava.objekty.Length; i++)
            {
                posun[i] = new Vektor(panel.Width / 2, panel.Height / 2);
                pozicie_pix_vykr[i] = Vektor.scitaj_vektory(Vektor.odcitaj_vektor(pozicie_pix_zakl[i], pozicie_pix_zakl[3]),posun[i]);
                pom_body[i].Add(new Point((int)pozicie_pix_vykr[i].x, (int)pozicie_pix_vykr[i].y));
            }


        }

        public void pretypuj_polohove_vektory()
        {
            //Console.WriteLine("posun: "+ posun.x.ToString());
            for(int i = 0; i < pozicie_pix_zakl.Length; i++)
            {
                
                pozicie_pix_vykr[i] = Vektor.scitaj_vektory(posun[i], pozicie_pix_zakl[i]);
                pom_body[i].Add(new Point((int)pozicie_pix_vykr[i].x,(int)pozicie_pix_vykr[i].y));
                //Console.WriteLine("nove pozicie: " + pozicie_pix_vykr[i].x.ToString() + " " + pozicie_pix_vykr[i].y.ToString());
            }
        }

        public void updateni_pozicie()
        {
            preskaluj(sustava);

            if (sustava.mod == true) helio();
            else geo();
            t += 1;
            for (int i = 0; i < pozicie_pix_vykr.Length; i++ )
            {
                pen.Color = sustava.objekty[i].farba.Color;
                
                panel.Update();
                Rectangle pom = new Rectangle(0,0,1,1);
                
                telesa[i].Location = new Point((int)(pozicie_pix_vykr[i].x - polomery_pix[i]), (int)(pozicie_pix_vykr[i].y - polomery_pix[i]));
                telesa[i].Parent = panel;
                telesa[i].SendToBack();

                while (Math.Sqrt(Math.Pow(pom_body[i][0].X-(int)pozicie_pix_vykr[i].x,2) + Math.Pow(pom_body[i][0].Y - (int)pozicie_pix_vykr[i].y, 2)) > polomery_pix[i]+7)
                {
                    pom = new Rectangle(pom_body[i][0].X, pom_body[i][0].Y, 1, 1);
                    pom_body[i].RemoveAt(0);
                }            

                if(sustava.objekty[i].stopa == true)
                {
                    g.DrawRectangle(pen, pom);
                }
                telesa[i].BringToFront();
                telesa[i].Parent = panel;
                panel.Update();
            }
            
            
        }

    }
}
