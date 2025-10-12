using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_OOP
{
    public partial class Rockmaruga : Form
    {
        PictureBox[] bit; //este crea pictureboxes que se usaran como parte del fondo
        int velF = 0; //esto controla su velocidad
        Random RNG;  //de momento solo controla la generacion de los BITS
        int vel;

        PictureBox[] bala;
        int rakataka;

        PictureBox[] Netnavi;
        int nmyVel;

        PictureBox[] Slash;
        int slashSpeed;

        int Course;
        int score;
        bool pause;
        bool G_Over;

        public Rockmaruga()
        {
            InitializeComponent();
        }

        private void Rockmaruga_Load(object sender, EventArgs e)
        {
            pause = false;
            G_Over = false;
            Course = 0;
            velF = 4;
            bit = new PictureBox[10];
            RNG = new Random();
            vel = 4;
            rakataka = 20;
            nmyVel = 4;
            slashSpeed = 4;
            score = 0;
            for (int i = 0; i < bit.Length; i++) //crea un buen de BITS
            {
                bit[i] = new PictureBox();
                bit[i].Image = Properties.Resources.Bit; //hace que el pb muestre el gif bit que esta en resources
                bit[i].SizeMode = PictureBoxSizeMode.StretchImage;
                bit[i].BorderStyle = BorderStyle.None;
                bit[i].Location = new Point(RNG.Next(-10, 500), RNG.Next(20, 800));
                if (i % 2 == 1)
                {
                    bit[i].Size = new Size(12,12);
                }
                else
                {
                    bit[i].Size = new Size(25,25);
                }
                this.Controls.Add(bit[i]);
            }
            bala = new PictureBox[3];
            for (int i = 0; i < bala.Length; i++)
            {
                bala[i] = new PictureBox();
                bala[i].Size = new Size(12, 12);
                bala[i].Image = Properties.Resources.Limon;
                bala[i].SizeMode = PictureBoxSizeMode.Zoom;
                bala[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(bala[i]);
            }

            Netnavi = new PictureBox[10];
            Image NMY1 = Properties.Resources.nmy1RK;
            Image NMY2 = Properties.Resources.nmy2RK;
            Image NMY3 = Properties.Resources.nmy3RK;
            Image NMY4 = Properties.Resources.nmy4RK;
            Image Boss = Properties.Resources.BossRK;
            for (int i = 0;i < Netnavi.Length;i++)
            {
                Netnavi[i] = new PictureBox();
                Netnavi[i].Size = new Size(50, 50);
                Netnavi[i].SizeMode = PictureBoxSizeMode.Zoom;
                Netnavi[i].BorderStyle = BorderStyle.None;
                Netnavi[i].Visible = false;
                this.Controls.Add(Netnavi[i]);
                Netnavi[i].Location = new Point((i + 1) * 50, 20);
            }
            Netnavi[0].Image = NMY2;
            Netnavi[1].Image = Boss;
            Netnavi[2].Image = NMY4;
            Netnavi[3].Image = NMY3;
            Netnavi[4].Image = NMY1;
            /*
            Netnavi[5].BackColor = Color.Green;
            Netnavi[6].BackColor = Color.Yellow;
            Netnavi[7].BackColor = Color.Green;
            Netnavi[8].BackColor = Color.Yellow;
            Netnavi[9].Image = Boss;
            */
            Slash = new PictureBox[10];
            for (int i = 0; i < Slash.Length;i++)
            {
                Slash[i] = new PictureBox();
                Slash[i].Size = new Size(2, 25);
                Slash[i].Visible = false;
                Slash[i].BackColor = Color.LimeGreen;
                int x = RNG.Next(0, 10);
                Slash[i].Location = new Point(Netnavi[0].Location.X, Netnavi[0].Location.Y - 20);
                Slash[i].Location = new Point(Netnavi[4].Location.X, Netnavi[4].Location.Y - 10);
                this.Controls.Add(Slash[i]);
            }
        }

        private void Cerrar(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            for (int i = 0;i < bit.Length/2;i++) //controla la velocidad en la que cae los bits
            {
                bit[i].Top += velF;
                if (bit[i].Top >= this.Height)
                {
                    bit[i].Top = -bit[i].Height;
                }
            }

            for (int i = bit.Length/2;i < bit.Length;i++) //esto hace que algunos bits caigan mas lento de lo normal
            {
                bit[i].Top += velF-2;
                if (bit[i].Top >= this.Height)
                {
                    bit[i].Top = -bit[i].Height;
                }
            }
        }

        //esta es una forma alternativa de generar el movimiento del personaje, aparentemente es un poco mas eficiente/sencilla que
        //la utilizada en el nivel 0
        private void Arriba_Tick(object sender, EventArgs e)
        {
            if (Rock.Top>20)
            {
                Rock.Top -= vel;
            }
        }

        private void Abajo_Tick(object sender, EventArgs e)
        {
            if (Rock.Top < 560)
            {
                Rock.Top += vel;
            }
        }

        private void Izquierda_Tick(object sender, EventArgs e)
        {
            if (Rock.Left > 10)
            {
                Rock.Left -= vel;
            }
        }

        private void Derecha_Tick(object sender, EventArgs e)
        {
            if (Rock.Right < 350)
            {
                Rock.Left += vel;
            }
        }

        private void Rockmaruga_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.D) //esto comprueba si la tecla esta siendo presionada
                {
                    Derecha.Start();
                }
                if (e.KeyCode == Keys.A)
                {
                    Izquierda.Start();
                }
                if (e.KeyCode == Keys.W)
                {
                    Arriba.Start();
                }
                if (e.KeyCode == Keys.S)
                {
                    Abajo.Start();
                }
            }

        }

        private void Rockmaruga_KeyUp(object sender, KeyEventArgs e)
        {
            Arriba.Stop();
            Abajo.Stop();
            Izquierda.Stop();
            Derecha.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if(!G_Over)
                {
                    if (pause)
                    {
                        Init();
                        label1.Visible = false;
                        pause = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width / 2 - 120, 150);
                        label1.Text = "Pausa";
                        label1.Visible = true;
                        Parar_Todo();
                        pause = true;
                    }
                }
            }
        }

        //esto ya es de otra cosa :v
        private void Bullet_time_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bala.Length; i++)
            {
                if (bala[i].Top > 0)
                {
                    bala[i].Visible = true;
                    bala[i].Top -= rakataka;
                    Colision();
                }
                else
                {
                    bala[i].Visible = false;
                    bala[i].Location = new Point(Rock.Location.X +20, Rock.Location.Y -i*30);
                }
            }
        }

        private void netnavi_time_Tick(object sender, EventArgs e)
        {
            MovNMY(Netnavi, nmyVel);
        }
        private void MovNMY(PictureBox[] arr, int SPD)
        {
            for (int i = 0;i < arr.Length;i++)
            {
                arr[i].Visible = true;
                arr[i].Top += SPD;

                if (arr[i].Top > this.Height)
                {
                    arr[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        private void Colision()
        {
            for (int i = 0; i < Netnavi.Length; i++)
            {
                if (bala[0].Bounds.IntersectsWith(Netnavi[i].Bounds) || bala[1].Bounds.IntersectsWith(Netnavi[i].Bounds) || bala[2].Bounds.IntersectsWith(Netnavi[i].Bounds))
                {
                    score += 1;
                    if (score % 30 == 0)
                    {
                        Course += 1;
                        lvl.Text = (Course < 10) ? "0" + Course.ToString(): Course.ToString();
                        if (nmyVel <= 10 && slashSpeed<=10)
                        {
                            slashSpeed++;
                            nmyVel++;
                        }
                        if (Course == 5)
                        {
                            DialogResult vol = MessageBox.Show("¡Felicidades!\n¿Quieres pasar al siguente nivel?", "S:/T/A/G/E/ C.L.E.A.R.", MessageBoxButtons.YesNo);
                            if (vol == DialogResult.Yes)
                            {
                                Parar_Todo();
                                Nivel0 start = new Nivel0();
                                this.Hide();
                                start.Show();
                            }
                            else if (vol == DialogResult.No)
                            {
                                Game_Over("NIVEL COMPLETADO");
                            }
                        }
                    }
                    Netnavi[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Rock.Bounds.IntersectsWith(Netnavi[i].Bounds))
                {
                    Rock.Visible = false;
                    Game_Over("Perdiste!");
                }
            }
        }

        private void Game_Over(string str)
        {
            label1.Text = str;
            label1.Location = new Point(120, 120);
            label1.Visible = true;
            Reintentar.Visible = true;
            Parar_Todo();
        }

        private void Parar_Todo()
        {
            Tiempo.Stop();
            Bullet_time.Stop();
            netnavi_time.Stop();
            netnavi_BulletTime.Stop();
        }
        private void Init()
        {
            Tiempo.Start();
            netnavi_time.Start();
            Bullet_time.Start();
            netnavi_BulletTime.Start();
        }

        private void netnavi_BulletTime_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Slash.Length; i++)
            {
                if (Slash[i].Top < this.Height)
                {
                    Slash[i].Visible = true;
                    Slash[i].Top += slashSpeed;
                    Balearon_A_Rock();
                }
                else
                {
                    Slash[i].Visible = false;
                    Slash[i].Location = new Point(Netnavi[0].Location.X + 20, Netnavi[0].Location.Y + 30);
                    Slash[i].Location = new Point(Netnavi[4].Location.X + 20, Netnavi[4].Location.Y + 30);
                }
            }
        }
        private void Balearon_A_Rock()
        {
            for (int i = 0; i < Slash.Length; i++)
            {
                if (Slash[i].Bounds.IntersectsWith(Rock.Bounds))
                {
                    Slash[i].Visible = false;
                    Rock.Visible = false;
                    Game_Over("G:/a/m/e O.V.E.R.");
                }
            }
        }

        private void Reintentar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Rockmaruga_Load(e, e);
        }
    }
}
