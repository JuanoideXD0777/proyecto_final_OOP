using proyecto_final_OOP.InterFs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace proyecto_final_OOP
{
    public partial class MegaRun : Form, IG_Over, Ireturn
    {
        public static MegaRun instance;
        bool salto = false; //controla el comando cuando presionamos la barra
        int impulso = 12; //impulso y fuerza determinan que tan alto vamos a saltar 
        int fuerza = 12;
        public int score = 0;
        int nmySpd = 10; //determina que tan rapido se mueven los enemigos
        Random RNG = new Random();
        bool disparo = false;
        int rakataka = 20;
        int boss_hp = 5;
        int Pos;
        bool G_Over;
        SoundPlayer ost;
        public MegaRun()
        {
            ost = new SoundPlayer(Properties.Resources.runBoyrun);
            InitializeComponent();
            reset();
            instance = this;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Rock.Top += impulso;
            label1.Text = "Puntuacion:" + score;
            if (salto == true && fuerza < 0)
            {
                salto = false;
            }
            if (salto == true)
            {
                impulso = -12;
                fuerza -= 1;
            }
            else
            {
                impulso = 12;
            }
            if (Rock.Top > 298 && salto == false)
            {
                fuerza = 12;
                Rock.Top = 299;
                Rock.Image = Properties.Resources.rock_r;
                impulso = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "limon")
                {
                    x.Left += rakataka;
                    if (x.Left > 560)
                    {
                        limpiar_pantalla(((PictureBox)x));
                    }

                    if (pictureBox5.Bounds.IntersectsWith(x.Bounds))
                    {
                        limpiar_pantalla(((PictureBox)x));
                        pictureBox5.Left = this.ClientSize.Width + RNG.Next(200, 500) + (pictureBox5.Width * 15);
                    }

                    if (pictureBox4.Bounds.IntersectsWith(x.Bounds))
                    {
                        limpiar_pantalla(((PictureBox)x));
                        boss_hp--;
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstaculo" && score!=15)
                {
                    x.Left -= nmySpd;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + RNG.Next(200,500) + (x.Width * 15);
                        score++;
                    }
                    if (Rock.Bounds.IntersectsWith(x.Bounds))
                    {
                        Rock.Image = Properties.Resources.rock_morido;
                        Tiempo.Stop();
                        G_Over = true;
                        Game_Over("Perdiste!");
                    }
                }
                if (x is PictureBox && (string)x.Tag == "enemigo" && score != 15)
                {
                    x.Left -= nmySpd;

                    if (x.Left == Rock.Left)
                    {
                        x.Left = Rock.Left;
                        score++;
                    }
                    if (Rock.Bounds.IntersectsWith(x.Bounds))
                    {
                        Rock.Image = Properties.Resources.rock_morido;
                        Tiempo.Stop();
                        G_Over = true;
                        Game_Over("Perdiste!");
                    }
                }
            }
            if (score == 15)
            {
                pictureBox4.Left -= nmySpd;

                if (pictureBox4.Left < -100)
                {
                    pictureBox4.Left = this.ClientSize.Width + RNG.Next(200, 500) + (pictureBox4.Width * 15);
                    score++;
                }
                if (Rock.Bounds.IntersectsWith(pictureBox4.Bounds))
                {
                    Rock.Image = Properties.Resources.rock_morido;
                    Tiempo.Stop();
                    G_Over = true;
                    Game_Over("Perdiste!");
                }
                if (boss_hp == 0)
                {
                    Tiempo.Stop();
                    win();
                }
                
            }
        }

        private void k_d(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && disparo == false)
            {
                Rock.Image = Properties.Resources.rock_limonero;
                disparo = true;
                genLimones();
            }
            if (e.KeyCode == Keys.Space && salto == false)
            {
                salto = true;
                Rock.Image = Properties.Resources.rock_limonero_saltando_r;
            }
        }

        private void k_u(object sender, KeyEventArgs e)
        {
            if (disparo == true)
            {
                disparo = false;
                Rock.Image = Properties.Resources.rock_r;
            }
            if (salto == true)
            {
                salto = false;
            }
        }
        private void reset()
        {
            Menu.Enabled = false;
            Menu.Visible = false;
            exit.Visible = false;
            fuerza = 12;
            impulso = 0;
            salto = false;
            score = 0;
            nmySpd = 10;
            disparo = false;
            rakataka = 20;
            boss_hp = 5;
            label1.Text = "Puntuacion:" + score;
            G_Over = false;
            Rock.Top = 298;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstaculo" || (string)x.Tag == "vacio" || (string)x.Tag == "enemigo" || (string)x.Tag == "boss")
                {
                    Pos = this.ClientSize.Width + RNG.Next(10, 100) + (x.Width * 10);
                    x.Left = Pos;
                }
            }

            Tiempo.Start();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Game_Over(string str)
        {
            G_Over = true;
            Menu.Visible = true;
            Menu.Enabled = true;
            exit.Visible = true;
            titulo.Text = str;
            Start.Visible = true;
            Start.Text = "Reintentar";
            //Parar_Todo();
        }

        private void MegaRun_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void limpiar_pantalla(PictureBox bala)
        {
            this.Controls.Remove(bala);
            bala.Dispose();
        }
        private void genLimones()
        {
            PictureBox bala = new PictureBox();
            bala.Image = Properties.Resources.Limon;
            bala.SizeMode = PictureBoxSizeMode.Zoom;
            bala.BorderStyle = BorderStyle.None;
            bala.Height = 10;
            bala.Width = 10;
            bala.Left = Rock.Left + Rock.Width+2;
            bala.Top = Rock.Top + Rock.Height/8;
            bala.Tag = "limon";
            this.Controls.Add( bala );
        }
        private void Bullet_time_Tick(object sender, EventArgs e)
        {
            
            
        }

        void IG_Over.Game_Over(string str)
        {
            Game_Over(str);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            back();
        }

        public void back()
        {
            Nivel0 start = new Nivel0();
            this.Hide();
            start.Show();
        }

        public void win()
        {
            DialogResult vol = MessageBox.Show("¡Felicidades!\n¿Quieres pasar al siguente nivel?", "S:/T/A/G/E/ C.L.E.A.R.", MessageBoxButtons.YesNo);
            if (vol == DialogResult.Yes)
            {

                Nivel0 start = new Nivel0();
                this.Hide();
                start.Show();
            }
            else if (vol == DialogResult.No)
            {
                Tiempo.Start();
                score = 17;
            }
        }

        private void MegaRun_Load(object sender, EventArgs e)
        {
            ost.Play();
        }
    }
}
