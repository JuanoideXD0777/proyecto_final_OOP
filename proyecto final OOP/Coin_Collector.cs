using proyecto_final_OOP.Objeks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_OOP
{
    public partial class Coin_Collector : Form
    {
        public static Coin_Collector instance;
        //en este nivel regrese al metodo de movimiento anterior ya que al no utilizar timers, tiene menos delay
        bool Sup, Inf, Izq, Der; //por como esta hecho el mapa, no implementare el movimiento automatico tipico de los juegos de pacman
        List<PictureBox> muros = new List<PictureBox>(); //necesario para las colisiones
        List<PictureBox> monedas = new List<PictureBox>();
        int vel = 8;
        public int score = 0;
        bool pause, G_Over;
        bool Limon; //esto lo añadire mas tarde, utilizara la clase Limon la cual sera nuestra segunda clase (creo), ya saben, por el meme de que megaman lanza limones
        ghostnaviCC R, G, B, roze; //pre genera a los fantasmas
        string apuntando = "R";
        List<ghostnaviCC> P_Navis = new List<ghostnaviCC>();

        public Coin_Collector()
        {
            InitializeComponent();
            Setup();
            instance = this;
        }

        private void Coin_Collector_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.D) //esto comprueba si la tecla esta siendo presionada
                {
                    Der = true;
                    apuntando = "Ri";
                }
                if (e.KeyCode == Keys.A)
                {
                    Izq = true;
                    apuntando = "Le";
                }
                if (e.KeyCode == Keys.W)
                {
                    Sup = true;
                    apuntando = "W";
                }
                if (e.KeyCode == Keys.S)
                {
                    Inf = true;
                    apuntando = "S";
                }
                if (e.KeyCode == Keys.Space)
                {
                    //Limon = true;
                }
            }
        }

        private void Coin_Collector_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) //esto comprueba que la tecla ya no esta siendo pulsada
            {
                Der = false;
                Rockman.Image = Properties.Resources.rock_stand_r;
            }
            if (e.KeyCode == Keys.A)
            {
                Izq = false;
                Rockman.Image = Properties.Resources.rock_stand_l;
            }
            if (e.KeyCode == Keys.W)
            {
                Sup = false;
                Rockman.Image = Properties.Resources.rock_stand_up;
            }
            if (e.KeyCode == Keys.S)
            {
                Inf = false;
                Rockman.Image = Properties.Resources.rock_stand;
            }
            if (e.KeyCode == Keys.Space)
            {
                //Limones(apuntando);
            }
            if (e.KeyCode == Keys.P)
            {
                if (!G_Over)
                {
                    if (pause)
                    {
                        PacTime.Start();
                        Menu.Enabled = false;
                        Menu.Visible = false;
                        pause = false;
                    }
                    else
                    {
                        Menu.Visible = true;
                        Menu.Enabled = true;
                        titulo.Text = "En pausa";
                        Start.Visible = false;
                        PacTime.Stop();
                        Instrucciones.Text = "Puedes presionar la tecla P para pausar";
                        pause = true;
                    }
                }
            }
        }

        private void PacTime_Tick(object sender, EventArgs e)
        {
            Mov(); //ejecuta los comandos de movimiento

            foreach (PictureBox Muro in muros) //comprueba las colisiones de los muros
            {
                Pared(Rockman, Muro);
            }

            foreach (PictureBox moneda in monedas) //COMPRUEBA LAS COLISIONES DE LAS MONEDAS
            {
                CC(Rockman, moneda);
            }
            if (score == monedas.Count()) //comprueba el conteo de monedas, esto afectara al score y si ya completaste el nivel
            {
                PacTime.Stop();
                DialogResult vol = MessageBox.Show("¡Felicidades!\n¿Quieres pasar al siguente nivel?", "S:/T/A/G/E/ C.L.E.A.R.", MessageBoxButtons.YesNo);
                if (vol == DialogResult.Yes)
                {
                    
                    Nivel0 start = new Nivel0();
                    this.Hide();
                    start.Show();
                }
                else if (vol == DialogResult.No)
                {
                    PacTime.Start();
                    mostrar_Monedas();
                    score = 0;
                }
                
            }
            //se inicia la ia de los enemigos para que se dirijan al jugador
            R.GhostnaviMov(Rockman);
            G.GhostnaviMov(Rockman);
            B.GhostnaviMov(Rockman);
            roze.GhostnaviMov(Rockman);

            //comprueba las colisiones de los fantasmas
            foreach (ghostnaviCC Phantom in P_Navis)
            {
                Colisiones(Phantom, Rockman, Phantom.imagen);
                //aqui deberia agregar un segundo foreach para cuando reciban los limonazos
            }
        }

        private void Start_Click(object sender, EventArgs e) 
        {
            Menu.Enabled = false;
            Menu.Visible = false;
            score = 0;
            //mueve los fantasmas a su posicion inicial
            R.imagen.Location = new Point(935, 666);
            G.imagen.Location = new Point(60, 589);
            B.imagen.Location = new Point(949, 82);
            roze.imagen.Location = new Point(48, 58);
            PacTime.Start();
        }

        private void Setup()
        {
            //primero comprueba el numero de muros y monedas
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Muro")
                {
                    muros.Add((PictureBox)x);
                }
                if (x is PictureBox && x.Tag == "Moneda")
                {
                    monedas.Add((PictureBox)x);
                }
            }
            //crea a los fantasmas gracias a la clase ghostnaviCC
            R = new ghostnaviCC(this, Properties.Resources.BossRK, 100,100);
            P_Navis.Add(R);
            G = new ghostnaviCC(this, Properties.Resources.fanta_asmatico, 848, 597);
            P_Navis.Add(G);
            B = new ghostnaviCC(this, Properties.Resources.fanta_asmatico, 132, 584);
            P_Navis.Add(B);
            roze = new ghostnaviCC(this, Properties.Resources.fanta_asmatico, 877, 130);
            P_Navis.Add(roze);
        }

        private void Mov()
        {
            if (Izq) //esto controla el movimiento
            {
                Rockman.Left -= vel;
                Rockman.Image = Properties.Resources.rock_L_sprites_01;
            }
            if (Der)
            {
                Rockman.Left += vel;
                Rockman.Image = Properties.Resources.rock_R_sprites_01;
            }
            if (Sup)
            {
                Rockman.Top -= vel;
                Rockman.Image = Properties.Resources.rock_up_sprites_01;
            }
            if (Inf)
            {
                Rockman.Top += vel;
                Rockman.Image = Properties.Resources.rock_down_sprites_01;
            }

            if (Rockman.Left < -30)
            {
                Rockman.Left = this.ClientSize.Width - Rockman.Width;
            }
            if (Rockman.Left + Rockman.Width > this.ClientSize.Width)
            {
                Rockman.Left = -10;
            }
            if (Rockman.Top < -30)
            {
                Rockman.Top = this.ClientSize.Height - Rockman.Height;
            }
            if (Rockman.Top + Rockman.Width > this.ClientSize.Height)
            {
                Rockman.Top = -10;
            }
        }

        private void mostrar_Monedas() //si el jugador decide seguir jugando para farmear puntos, las monedas haran respawn cuando el jugador las recolecte todas
        {
            foreach(PictureBox moneda in monedas)
            {
                moneda.Visible = true;
            }
        }

        private void Pared (PictureBox rockman, PictureBox muros) //evita que el jugador pueda traspasar paredes, esta medio bugeado porque las coordenadas hacen lo que les da su regalada gana las hijas de su madre
        {
            if (rockman.Bounds.IntersectsWith(muros.Bounds))
            {
                if (Izq)
                {
                    Izq = false;
                    rockman.Left = muros.Right + 2;
                }
                if (Der)
                {
                    Der = false;
                    rockman.Left = muros.Left - rockman.Width - 2;
                }
                if (Sup)
                {
                    Sup = false;
                    rockman.Top = muros.Bottom + 2;
                }
                if (Inf)
                {
                    Inf = false;
                    rockman.Top = muros.Top - rockman.Height - 2;
                }
            }
        }
        private void CC (PictureBox rockman, PictureBox monedas)
        {
            if (rockman.Bounds.IntersectsWith(monedas.Bounds))
            {
                if (monedas.Visible)
                {
                    monedas.Visible = false;
                    score += 1;
                }
            }
        }
        private void Limones (string apuntando) //genera los limones
        {
            Limon disparo = new Limon();
            disparo.direccion = apuntando;
            disparo.limon_L = Rockman.Left + (Rockman.Width / 2);
            disparo.limon_T = Rockman.Top + (Rockman.Height / 2);
            disparo.Balistica(this);
        }
        private void Colisiones (ghostnaviCC g, PictureBox rocman, PictureBox nmy) //se encarga de las colisiones con enemigos
        {
            if (rocman.Bounds.IntersectsWith (nmy.Bounds))
            {
                Rockman.Image = Properties.Resources.rock_morido;
                Game_Over("Te han atrapado");
                g.Cambiar_Dir();
            }
        }
        private void Game_Over(string str) 
        {
            G_Over = true;
            Menu.Visible = true;
            Menu.Enabled = true;
            titulo.Text = str;
            Start.Visible = true;
            Start.Text = "Reintentar";
            PacTime.Stop();
            mostrar_Monedas();
            Rockman.Location = new Point(495, 559);
            Instrucciones.Text = "Puedes presionar la tecla P\n para pausar";
            //Parar_Todo();
        }
        private void Coin_Collector_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
