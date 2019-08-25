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
            string[] udaje = new string[] { "neptun","17,15", "0,01", "30,061", "3,865" };

            System.IO.StreamReader data = new System.IO.StreamReader(@"planety.txt");
            data.ReadLine();

            Slnko = new Teleso(data.ReadLine().Split());
            Merkur = new Teleso(data.ReadLine().Split());
            Venusa = new Teleso(data.ReadLine().Split());
            Zem = new Teleso(data.ReadLine().Split());
            Mars = new Teleso(data.ReadLine().Split());
            Jupiter = new Teleso(data.ReadLine().Split());
            Saturn = new Teleso(data.ReadLine().Split());
            Uran = new Teleso(data.ReadLine().Split());
            Neptun = new Teleso(data.ReadLine().Split());

            data.Close();
            

            G = 6.67 * Math.Pow(10,-11);
            dt = 1000000;
            t = 0;

            sustava = new Sustava(G, dt, Slnko, Merkur, Venusa, Zem, Mars, Jupiter, Saturn, Uran, Neptun);

            plocha = new Panel
            {
                Size = new Size(1800,900),
                Location = new Point(60,60),
                BackColor = Color.Black,
            };
            Controls.Add(plocha);
            plocha.Visible = false;

            zapnut = new Button
            {
                Location = new Point(900, 500),
                Size = new Size(200, 50),
                Text = "Start"
            };
            Controls.Add(zapnut);
            zapnut.Click += new EventHandler(zapnut_Click);

            farby_planet = new Color[] {Color.Yellow, Color.MediumTurquoise, Color.Crimson, Color.Aquamarine, Color.OrangeRed, Color.Peru, Color.Gold, Color.Turquoise, Color.SlateBlue };
            sustava.nastav_farby(farby_planet);

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


        internal Vykreslovanie kresli;
        internal Timer timer;

        internal Color[] farby_planet;
        internal double G;
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

            
            kresli.nakresli_objekty();
        }

        public void mode_Click(object sender, EventArgs e)
        {
            if(mode.Text == "Mode: Heliocentric")
            {
                kresli.geo();
                mode.Text = "Mode: Geocentric";
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



        public void tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");

            for (int i = 1; i < sustava.objekty.Length; i++)
            {
                Teleso a = sustava.objekty[i];
                Sustava.update_sila(a, sustava.objekty);
                Sustava.update_hybnost(a);
                Sustava.update_pozicia(a);
                Console.WriteLine("nova pozicia planety: " + a.pozicia.x.ToString() + " " + a.pozicia.y.ToString());
            }
            kresli.preskaluj(sustava);
            kresli.updateni_pozicie();
            //timer.Stop();
            t += dt;
            Console.ReadLine();

        }
    }
}
