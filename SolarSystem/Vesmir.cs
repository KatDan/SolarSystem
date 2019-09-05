using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SolarSystem
{

    public partial class Vesmir : Form
    {
        public Vesmir()
        {
            plocha = new Panel
            {
                Size = new Size(1400, 950),
                Location = new Point(5, 10),
                BackColor = Color.Black,
            };
            Controls.Add(plocha);
            plocha.Visible = false;

            cas = new Label
            {
                Parent = plocha,
                Location = new Point(plocha.Location.X + 10, plocha.Location.Y + 10),
                AutoSize = true,
                BackColor = Color.Black,
                ForeColor = Color.White,
                Text = "Day: 0\nYear: 0"
            };
            Controls.Add(cas);
            cas.BringToFront();


            //obrazky planet
            {
                slnko_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    Image = Properties.Resources.slnko1,
                    //BackColor = Color.Black,
                    Parent = plocha,

                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(slnko_pic);
                slnko_pic.Visible = false;

                merkur_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    BackColor = Color.Transparent,
                    Parent = plocha,
                    Image = Properties.Resources.merkur,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(merkur_pic);
                merkur_pic.Visible = false;

                venusa_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    Parent = plocha,
                    Image = Properties.Resources.venusa,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(venusa_pic);
                venusa_pic.Visible = false;

                zem_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    Parent = plocha,
                    Image = Properties.Resources.zem,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(zem_pic);
                zem_pic.Visible = false;

                mars_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    Parent = plocha,
                    Image = Properties.Resources.mars,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(mars_pic);
                mars_pic.Visible = false;

                jupiter_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    Parent = plocha,
                    Image = Properties.Resources.jupiter,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(jupiter_pic);
                jupiter_pic.Visible = false;

                saturn_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    BackColor = Color.Transparent,
                    Parent = plocha,
                    Image = Properties.Resources.saturn,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(saturn_pic);
                saturn_pic.Visible = false;

                uran_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    BackColor = Color.Transparent,
                    Parent = plocha,
                    Image = Properties.Resources.uran,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(uran_pic);
                uran_pic.Visible = false;

                neptun_pic = new PictureBox
                {
                    Size = new Size(30, 30),
                    Location = new Point(0, 0),
                    BackColor = Color.Transparent,
                    Parent = plocha,
                    Image = Properties.Resources.neptun,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(neptun_pic);
                neptun_pic.Visible = false;
            }
           
            G = 6.67 * Math.Pow(10, -11);
            G = G * (5.972 / 3.375) * Math.Pow(10, -9);

            //nacitanie vstupu
            {
                var data = Properties.Resources.planety.Split(Convert.ToChar("\n"));

                //nazov, m, e, a, r

                Slnko = new Teleso(data[1].Split(), slnko_pic);
                Merkur = new Teleso(data[2].Split(), merkur_pic);
                Venusa = new Teleso(data[3].Split(), venusa_pic);
                Zem = new Teleso(data[4].Split(), zem_pic);
                Mars = new Teleso(data[5].Split(), mars_pic);
                Jupiter = new Teleso(data[6].Split(), jupiter_pic);
                Saturn = new Teleso(data[7].Split(), saturn_pic);
                Uran = new Teleso(data[8].Split(), uran_pic);
                Neptun = new Teleso(data[9].Split(), neptun_pic);

            }
            
            objekty_k_dispozicii = new Teleso[] { Slnko, Merkur, Venusa, Zem, Mars, Jupiter, Saturn, Uran, Neptun};
            viditelne_objekty = new List<Teleso>();

            viditelne_objekty.Add(Slnko);
            viditelne_objekty.Add(Merkur);
            viditelne_objekty.Add(Venusa);
            viditelne_objekty.Add(Zem);
            viditelne_objekty.Add(Mars);
            viditelne_objekty.Add(Jupiter);
            viditelne_objekty.Add(Saturn);
            viditelne_objekty.Add(Uran);
            viditelne_objekty.Add(Neptun);

            //mod = true;
            sustava = new Sustava(G, dt, objekty_k_dispozicii);

            //posledne presne pre neptun: dt = 1000000
            dt = 300000;
            t = 0;         

            zapnut = new Button
            {
                Location = new Point(500, 500),
                Size = new Size(400, 50),
                Text = "Start the simulation",
                Parent = plocha
            };
            Controls.Add(zapnut);
            zapnut.BringToFront();            
            zapnut.Click += new EventHandler(zapnut_Click);
            //zapnut.Visible = false;

            reset = new Button
            {
                Size = new Size(200,45),
                Location = new Point(1675,15),
                Text = "Reset",
                Font = new Font(Font.FontFamily, 12)
            };
            Controls.Add(reset);
            reset.Click += new EventHandler(reset_Click);
            
            mode = new Button
            {
                Text = "Mode: Heliocentric",
                Location = new Point(1450,70),
                Size = new Size (430,40),
                Font = new Font(Font.FontFamily,12)
            };
            Controls.Add(mode);
            mode.Click += new EventHandler(mode_Click);

            timer = new Timer
            {
                Interval = 1,
            };
            timer.Tick += new EventHandler(tick);
            //timer.Start();

            start_stop = new Button
            {
                Location = new Point(1450, 15),
                Size = new Size(200,45),
                Text = "Start",
                Font = new Font(Font.FontFamily, 12)
            };
            Controls.Add(start_stop);
            start_stop.Click += new EventHandler(start_stop_Click);

            kresli = new Vykreslovanie(sustava, plocha);

            //kresli.preskaluj(sustava);
            //kresli.helio();

            sustava.mod = true;

            InitializeComponent();
        }

        //moznosti
        internal Button zapnut;
        internal Button mode;
        internal Button start_stop;
        internal Button reset;

        //planety
        internal PictureBox slnko_pic;
        internal PictureBox merkur_pic;
        internal PictureBox venusa_pic;
        internal PictureBox zem_pic;
        internal PictureBox mars_pic;
        internal PictureBox jupiter_pic;
        internal PictureBox saturn_pic;
        internal PictureBox uran_pic;
        internal PictureBox neptun_pic;

        internal List<Teleso> viditelne_objekty;
        internal Teleso[] objekty_k_dispozicii;
        internal Label cas;

        //internal bool mod;

        internal static Vykreslovanie kresli;
        internal Timer timer;
        internal static double G;
        internal double dt;
        internal double t;

        internal Teleso Slnko;
        internal Teleso Merkur;
        internal Teleso Venusa;
        internal Teleso Zem;
        internal Teleso Mars;
        internal Teleso Jupiter;
        internal Teleso Saturn;
        internal Teleso Uran;
        internal Teleso Neptun;

        internal static Panel plocha;

        internal static Sustava sustava;

        public void zapnut_Click(object sender, EventArgs e)
        {
            plocha.Visible = true;
            zapnut.Visible = false;

            reset.PerformClick();
            kresli.updateni_pozicie();
            sustava.zviditelni_vsetky_telesa();
            //plocha.Invalidate();
        }

        public void start_stop_Click(object sender, EventArgs e)
        {
            if (start_stop.Text == "Start")
            {
                timer.Start();
                //presnost.Visible = false;
                start_stop.Text = "Stop";
            }
            else
            {
                timer.Stop();
                start_stop.Text = "Start";
                //presnost.Visible = true;
            }
        }

        public void mode_Click(object sender, EventArgs e)
        {
            if(mode.Text == "Mode: Heliocentric")
            {
                //kresli.geo();
                sustava.mod = false;
                mode.Text = "Mode: Geocentric";
                //kresli.telesa[1].X -= 500;
                plocha.Update();
            }
            else
            {
                sustava.mod = true;
                //kresli.helio();
                mode.Text = "Mode: Heliocentric";
            }
            reset.PerformClick();
        }

        

        public void reset_Click(object sender, EventArgs e)
        {
            vytvor_slnecnu_sustavu(viditelne_objekty);
            
            kresli.nastav_konstantu_a_ostatne_veci_tak_aby_sa_spravne_rozmiestnili_planety();
            kresli.preskaluj(sustava);
            if (sustava.mod == true) kresli.helio();
            else kresli.geo();
            kresli.updateni_pozicie();
            plocha.Invalidate();
            kresli.nastav_polomery();

            t = 0;
            cas.Text = "Day: 0\nYear: 0";
        }

        public void tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");
            Console.WriteLine(sustava.mod.ToString());

            for (int i = 1; i < sustava.objekty.Length; i++)
            {
                Teleso a = sustava.objekty[i];
                Sustava.update_sila(a, sustava.objekty);
                Sustava.update_hybnost(a);
                Sustava.update_pozicia(a);
                //Console.WriteLine("nova pozicia planety: " + a.pozicia.x.ToString() + " " + a.pozicia.y.ToString());
            }
            kresli.preskaluj(sustava);
            kresli.updateni_pozicie();
            //timer.Stop();
            t += dt;
            cas.Text ="Day: " + ((int)(t / 86400)).ToString() +"\nYear: " + ((int)(t / 31557600)).ToString();
            cas.Update();
            //Console.ReadLine();

        }

        public void vytvor_slnecnu_sustavu(List<Teleso> objekty)
        {
            bool pom = sustava.mod;
            sustava = new Sustava(G,dt,objekty_k_dispozicii);
            sustava.mod = pom;
            sustava.nastav_pociatocny_stav();
            kresli = new Vykreslovanie(sustava, plocha);
            plocha.Invalidate();
        }

        private void checkBox_slnko_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sun.CheckState == CheckState.Checked)
            {
                Slnko.viditelnost = true;
                Slnko.kruh.Visible = true;
            }
                
            else
            {
                Slnko.viditelnost = false;
                Slnko.kruh.Visible = false;
                checkBox_slnko_stopa.CheckState = CheckState.Unchecked;
                Slnko.stopa = false;
            }
            reset.PerformClick();
        }

        private void checkBox_merkur_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_merkur.CheckState == CheckState.Checked)
            {
                Merkur.viditelnost = true;
                Merkur.kruh.Visible = true;
            }
                
            else
            {
                Merkur.viditelnost = false;
                Merkur.kruh.Visible = false;
                checkBox_merkur_stopa.CheckState = CheckState.Unchecked;
                Merkur.stopa = false;
            }
            reset.PerformClick();
        }

        private void checkBox_venusa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_venusa.CheckState == CheckState.Checked)
            {
                Venusa.viditelnost = true;
                Venusa.kruh.Visible = true;
            }                
            else
            {
                Venusa.viditelnost = false;
                Venusa.kruh.Visible = false;
                Venusa.stopa = false;
                checkBox_venusa_stopa.CheckState = CheckState.Unchecked;
            }
            reset.PerformClick();
        }

        private void checkBox_zem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_zem.CheckState == CheckState.Checked)
            {
                Zem.viditelnost = true;
                Zem.kruh.Visible = true;
            }
                
            else
            {
                Zem.viditelnost = false;
                Zem.kruh.Visible = false;
                Zem.stopa = false;
                checkBox_zem_stopa.CheckState = CheckState.Unchecked;
            }
            reset.PerformClick();
        }

        private void checkBox_mars_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mars.CheckState == CheckState.Checked)
            {
                Mars.viditelnost = true;
                Mars.kruh.Visible = true;
            }
                
            else
            {
                Mars.viditelnost = false;
                Mars.kruh.Visible = false;
                Mars.stopa = false;
                checkBox_mars_stopa.CheckState = CheckState.Unchecked;
            }
            reset.PerformClick();
        }

        private void checkBox_jupiter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_jupiter.CheckState == CheckState.Checked)
            {
                Jupiter.viditelnost = true;
                Jupiter.kruh.Visible = true;
            }
                
            else
            {
                Jupiter.viditelnost = false;
                Jupiter.kruh.Visible = false;
                Jupiter.stopa = false;
                checkBox_jupiter_stopa.CheckState = CheckState.Unchecked;
            }
            reset.PerformClick();
        }

        private void checkBox_saturn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_saturn.CheckState == CheckState.Checked)
            {
                Saturn.viditelnost = true;
                Saturn.kruh.Visible = true;
            }
                
            else
            {
                Saturn.viditelnost = false;
                Saturn.kruh.Visible = false;
                Saturn.stopa = false;
                checkBox_saturn_stopa.CheckState = CheckState.Unchecked;
            }
            reset.PerformClick();
        }

        private void checkBox_uran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_uran.CheckState == CheckState.Checked)
            {
                Uran.viditelnost = true;
                Uran.kruh.Visible = true;
            }
                
            else
            {
                Uran.viditelnost = false;
                Uran.kruh.Visible = false;
                Uran.stopa = false;
                checkBox_uran_stopa.CheckState = CheckState.Unchecked;
            }
            reset.PerformClick();
        }

        private void checkBox_neptun_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_neptun.CheckState == CheckState.Checked)
            {
                Neptun.viditelnost = true;
                Neptun.kruh.Visible = true;
            }
                
            else
            {
                Neptun.viditelnost = false;
                Neptun.kruh.Visible = false;
                Neptun.stopa = false;
                checkBox_neptun_stopa.CheckState = CheckState.Unchecked;
            }
            reset.PerformClick();
        }

        private void checkBox_slnko_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_slnko_stopa.CheckState == CheckState.Checked) Slnko.stopa = true;
            else Slnko.stopa = false;
            reset.PerformClick();
        }

        private void checkBox_merkur_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_merkur_stopa.CheckState == CheckState.Checked) Merkur.stopa = true;
            else Merkur.stopa = false;
            reset.PerformClick();
        }

        private void checkBox_venusa_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_venusa_stopa.CheckState == CheckState.Checked) Venusa.stopa = true;
            else Venusa.stopa = false;
            reset.PerformClick();
        }

        private void checkBox_zem_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_zem_stopa.CheckState == CheckState.Checked) Zem.stopa = true;
            else Zem.stopa = false;
            reset.PerformClick();
        }

        private void checkBox_mars_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mars_stopa.CheckState == CheckState.Checked) Mars.stopa = true;
            else Mars.stopa = false;
            reset.PerformClick();
        }

        private void checkBox_jupiter_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_jupiter_stopa.CheckState == CheckState.Checked) Jupiter.stopa = true;
            else Jupiter.stopa = false;
            reset.PerformClick();
        }

        private void checkBox_saturn_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_saturn_stopa.CheckState == CheckState.Checked) Saturn.stopa = true;
            else Saturn.stopa = false;
            reset.PerformClick();
        }

        private void checkBox_uran_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_uran_stopa.CheckState == CheckState.Checked) Uran.stopa = true;
            else Uran.stopa = false;
            reset.PerformClick();
        }

        private void checkBox_neptun_stopa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_neptun_stopa.CheckState == CheckState.Checked) Neptun.stopa = true;
            else Neptun.stopa = false;
            reset.PerformClick();
        }

        private void rychlost_Scroll(object sender, EventArgs e)
        {
            switch (rychlost.Value)
            {
                case 1: timer.Interval = 100; break;
                case 2: timer.Interval = 10; break;
                case 3: timer.Interval = 1; break;
            }
            reset.PerformClick();
        }

        private void presnost_Scroll(object sender, EventArgs e)
        {
            dt = presnost.Value;
            reset.PerformClick();
        }
    }

    

}
