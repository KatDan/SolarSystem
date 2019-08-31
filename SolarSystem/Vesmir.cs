using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{

    public partial class Vesmir : Form
    {
        public Vesmir()
        {
            plocha = new Panel
            {
                Size = new Size(1500, 900),
                Location = new Point(20, 60),
                BackColor = Color.Black,
            };
            Controls.Add(plocha);
            //plocha.Visible = false;

            //obrazky planet
            slnko_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                Image = Image.FromFile(@"slnko.png"),
                //BackColor = Color.Black,
                Parent = plocha,
                
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(slnko_pic);

            merkur_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                BackColor = Color.Transparent,
                Parent = plocha,
                Image = Image.FromFile(@"merkur.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(merkur_pic);

            venusa_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                Parent = plocha,
                Image = Image.FromFile(@"venusa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(venusa_pic);

            zem_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                Parent = plocha,
                Image = Image.FromFile(@"zem.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(zem_pic);

            mars_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                Parent = plocha,
                Image = Image.FromFile(@"mars.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(mars_pic);

            jupiter_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                Parent = plocha,
                Image = Image.FromFile(@"jupiter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(jupiter_pic);

            saturn_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                BackColor = Color.Transparent,
                Parent = plocha,
                Image = Image.FromFile(@"saturn.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(saturn_pic);

            uran_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                BackColor = Color.Transparent,
                Parent = plocha,
                Image = Image.FromFile(@"uran.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(uran_pic);

            neptun_pic = new PictureBox
            {
                Size = new Size(30, 30),
                Location = new Point(0, 0),
                BackColor = Color.Transparent,
                Parent = plocha,
                Image = Image.FromFile(@"neptun.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(neptun_pic);


            G = 6.67 * Math.Pow(10, -11);
            //G v [AU**3/m_Zs**2]
            G = G * (5.972 / 3.375) * Math.Pow(10, -9);
            Console.WriteLine("G: " + G);

            //G = 1;



            string[] udaje = new string[] { "neptun","17,15", "0,01", "30,061", "3,865" };

            System.IO.StreamReader data = new System.IO.StreamReader(@"planety.txt");
            data.ReadLine();
            //data.ReadLine();
            //data.ReadLine();

            //nazov, m, e, a, r
            string[] slnko_test = new string[] {"slnko", "1000", "0", "0","0,2"  };
            string[] merkur_test = new string[] {"merkur","20", "0,4", "5", "0,1" };

            Slnko = new Teleso(data.ReadLine().Split(),slnko_pic);
            Merkur = new Teleso(data.ReadLine().Split(),merkur_pic);
            Venusa = new Teleso(data.ReadLine().Split(),venusa_pic);
            Zem = new Teleso(data.ReadLine().Split(),zem_pic);
            Mars = new Teleso(data.ReadLine().Split(),mars_pic);
            Jupiter = new Teleso(data.ReadLine().Split(),jupiter_pic);
            Saturn = new Teleso(data.ReadLine().Split(),saturn_pic);
            Uran = new Teleso(data.ReadLine().Split(),uran_pic);
            Neptun = new Teleso(data.ReadLine().Split(),neptun_pic);

            data.Close();

            sustava = new Sustava(G, dt, Slnko, Merkur, Venusa, Zem, Mars, Jupiter, Saturn, Uran, Neptun);

           
            //G = 1;
            //posledne presne: dt = 1000000
            dt = 1000000;
            t = 0;

           

            zapnut = new Button
            {
                Location = new Point(900, 500),
                Size = new Size(200, 50),
                Text = "Start",
                Parent = plocha
            };
            Controls.Add(zapnut);
            zapnut.BringToFront();            
            zapnut.Click += new EventHandler(zapnut_Click);

            reset = new Button
            {
                Size = new Size(60,40),
                Location = new Point(1580,5),
                Text = "Reset"
            };
            Controls.Add(reset);
            reset.Click += new EventHandler(reset_Click);






            planety = new Rectangle[sustava.objekty.Length];
            for(int i = 0;  i< sustava.objekty.Length; i++)
            {
                planety[i] = new Rectangle(0, 0, 10, 10);
                //planety[i].X = 400;
            }
            

            mode = new Button
            {
                Text = "Mode: Heliocentric",
                Location = new Point(5,5),
                Size = new Size (400,40)
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
                Location = new Point(1500, 5),
                Size = new Size(60,40),
                Text = "Start"
            };
            Controls.Add(start_stop);
            start_stop.Click += new EventHandler(start_stop_Click);

            kresli = new Vykreslovanie(sustava, plocha);
            //kresli.preskaluj(sustava);
            //kresli.helio();

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



        internal Vykreslovanie kresli;
        internal Timer timer;
        internal Rectangle[] planety;

        internal Color[] farby_planet;
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

        internal Panel plocha;

        internal Sustava sustava;


        public void zapnut_Click(object sender, EventArgs e)
        {
            plocha.Visible = true;
            zapnut.Visible = false;

            reset.PerformClick();
            kresli.updateni_pozicie();
            //plocha.Invalidate();
        }

        public void mode_Click(object sender, EventArgs e)
        {
            if(mode.Text == "Mode: Heliocentric")
            {
                //kresli.geo();
                mode.Text = "Mode: Geocentric";
                //kresli.telesa[1].X -= 500;
                plocha.Update();
            }
            else
            {
                kresli.helio();
                mode.Text = "Mode: Heliocentric";
            }
        }

        public void start_stop_Click(object sender, EventArgs e)
        {
            if(start_stop.Text == "Start")
            {
                timer.Start();
                start_stop.Text = "Stop";
            }
            else
            {
                timer.Stop();
                start_stop.Text = "Start";
            }
        }

        public void reset_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader data = new System.IO.StreamReader(@"planety.txt");
            data.ReadLine();
            //data.ReadLine();
            //data.ReadLine();

            //nazov, m, e, a, r
            string[] slnko_test = new string[] { "slnko", "1000", "0", "0", "0,2" };
            string[] merkur_test = new string[] { "merkur", "20", "0,4", "5", "0,1" };

            Slnko = new Teleso(data.ReadLine().Split(), slnko_pic);
            Merkur = new Teleso(data.ReadLine().Split(), merkur_pic);
            Venusa = new Teleso(data.ReadLine().Split(), venusa_pic);
            Zem = new Teleso(data.ReadLine().Split(), zem_pic);
            Mars = new Teleso(data.ReadLine().Split(), mars_pic);
            Jupiter = new Teleso(data.ReadLine().Split(), jupiter_pic);
            Saturn = new Teleso(data.ReadLine().Split(), saturn_pic);
            Uran = new Teleso(data.ReadLine().Split(), uran_pic);
            Neptun = new Teleso(data.ReadLine().Split(), neptun_pic);

            data.Close();


            plocha.Invalidate();
            
            sustava = new Sustava(G, dt, Slnko, Merkur, Venusa, Zem, Mars, Jupiter, Saturn, Uran, Neptun);
            kresli = new Vykreslovanie(sustava, plocha);
        }


        public void tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");

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
            //Console.ReadLine();

        }

    }
}
