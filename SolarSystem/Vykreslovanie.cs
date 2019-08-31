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

        internal Vektor posun;
        

        public Vykreslovanie(Sustava sus, Panel pan)
        {
            t = 0;
            stopa = new bool[sus.objekty.Length];
            posun = new Vektor(0, 0);
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
            double pom1 = panel.Size.Width - 400;
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

            helio();
            //pretypuj_polohove_vektory();

            for(int i = 0; i< sus.objekty.Length; i++)
            {
                telesa[i] = sustava.objekty[i].kruh;
                telesa[i].Location = new Point((int)(pozicie_pix_vykr[i].x - polomery_pix[i]), (int)(pozicie_pix_vykr[i].y - polomery_pix[i]));
                stopa[i] = sus.objekty[i].stopa;
                vychodzia_pozicia[i] = new Vektor(telesa[i].Location.X, telesa[i].Location.Y);

                //Console.WriteLine("rectangle: " + telesa[i].X + " " + telesa[i].Y + " " + telesa[i].Width + " " + telesa[i].Height);
            }
            nastav_polomery(6, 1, 2, 4, 5, 10, 8, 7, 6);
        }

        public void nastav_polomery(params int[] polomer)
        {
            for (int i = 0; i < polomer.Length; i++)
            {
                polomery_pix[i] = polomer[i];
            }
            for (int i = 0; i < polomery_pix.Length; i++)
            {
                telesa[i].Size = new Size(2 * polomery_pix[i], 2 * polomery_pix[i]);
                
            }
            updateni_pozicie();
            panel.Update();
        }

        public void preskaluj(Sustava sus)
        {
            for (int i = 0; i<pozicie_pix_zakl.Length; i++)
            {
                pozicie_pix_zakl[i] = Vektor.vynasob_skalarom(sus.objekty[i].pozicia,k);
                
                pozicie_pix_zakl[i].x = Math.Round(pozicie_pix_zakl[i].x);
                pozicie_pix_zakl[i].y = Math.Round(pozicie_pix_zakl[i].y);
                //Console.WriteLine("preskalovane: " + pozicie_pix_zakl[i].x.ToString() + " " + pozicie_pix_zakl[i].y.ToString());
                polomery_pix[i] = 15;
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
            posun = Vektor.vynasob_skalarom(pom, k);
            posun.y = panel.Size.Height / 2;

            pretypuj_polohove_vektory();
        }

        public void geo()
        {
            Vektor pom1 = new Vektor(sustava.objekty[last_index].hl_poloos * (1 - sustava.objekty[last_index].excentricita)+20, 0);
            Vektor helio = Vektor.vynasob_skalarom(pom1, k);
            helio.y = panel.Size.Height / 2;

            Vektor pom2 = pozicie_pix_zakl[3];
            posun = Vektor.scitaj_vektory(helio, pom2);
            pretypuj_polohove_vektory();
        }

        public void pretypuj_polohove_vektory()
        {
            //Console.WriteLine("posun: "+ posun.x.ToString());
            for(int i = 0; i < pozicie_pix_zakl.Length; i++)
            {
                
                pozicie_pix_vykr[i] = Vektor.scitaj_vektory(posun, pozicie_pix_zakl[i]);
                pom_body[i].Add(new Point((int)pozicie_pix_vykr[i].x,(int)pozicie_pix_vykr[i].y));
                //Console.WriteLine("nove pozicie: " + pozicie_pix_vykr[i].x.ToString() + " " + pozicie_pix_vykr[i].y.ToString());
            }
        }

        public void updateni_pozicie()
        {
            preskaluj(sustava);
            helio();
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


                g.DrawRectangle(pen, pom);
                telesa[i].Parent = panel;
                panel.Update();

                //Console.WriteLine("pozicia: " + pozicie_pix_vykr[i].x.ToString() + pozicie_pix_vykr[i].y.ToString());

                //pen.Dispose();
            }
            
            
        }

    }
}
