using proyecto_final_OOP.InterFs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_OOP
{
    public partial class plataformas : Form, IG_Over,Ireturn
    {
        public static plataformas instance;
        bool Izq, Der,pause, G_Over, salto, disparo;
        int impulso;
        int fuerza;
        public int score = 0;
        int vel = 8;
        int ivel;
        int hvel;
        int rakataka;
        string apuntando;
        int nmySpd;
        int nmyvel1;
        int nmyvel2;
        int nmyvel3;
        int gordovel;
        int regordovel;
        int morbidovel;
        int gunnervel1;
        int gunnervel2;
        int gunnervel3;
        PictureBox slash;
        int SlashSP;

        public plataformas()
        {
            InitializeComponent();
            instance = this;
        }

        public void Game_Over(string str)
        {
            G_Over = true;
            Menu.Visible = true;
            Menu.Enabled = true;
            titulo.Text = str;
            Start.Visible = true;
            Start.Text = "Reintentar";
            score++;
        }

        private void main(object sender, EventArgs e)
        {
            if (Izq) //esto controla el movimiento
            {
                Rock.Left -= vel;
            }
            if (Der)
            {
                Rock.Left += vel;
            }
            Rock.Top += impulso;
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
            if (Rock.Top > 663 && salto == false & score == 0)
            {
                fuerza = 12;
                Rock.Top = 663;
                impulso = 0;
            }
            if (Rock.Top > 550 && salto == false & score != 0)
            {
                fuerza = 12;
                Rock.Top = 551;
                impulso = 0;
            }
            rakataka = 15;
            nmySpd = 2;
            nmyvel1 = 1;
            nmyvel2 = nmySpd;
            nmyvel3 = nmySpd;
            gordovel = nmySpd;
            regordovel = nmySpd;
            morbidovel = nmySpd;
            gunnervel1 = nmySpd;
            gunnervel2 = nmySpd;
            gunnervel3 = nmySpd;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "limon")
                {
                    if (apuntando == "R")
                    {
                        x.Left += rakataka;
                        if (x.Left > 1030)
                        {
                            limpiar_pantalla(((PictureBox)x));
                        }
                    }
                    if (apuntando == "L")
                    {
                        x.Left -= rakataka;
                        if (x.Left < -10)
                        {
                            limpiar_pantalla(((PictureBox)x));
                        }
                    }
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "nmy" || (string)y.Tag == "gunner" || (string)y.Tag == "gordo")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                limpiar_pantalla(((PictureBox)x));
                                this.Controls.Remove(y);
                                y.Dispose();
                            }
                        }
                    }
                }
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "plataforma")
                    {
                        if (Rock.Bounds.IntersectsWith(x.Bounds))
                        {
                            fuerza = 8;
                            Rock.Top = x.Top - Rock.Height;
                        }
                        //x.BringToFront();
                    }
                    if ((string)x.Tag == "techo")
                    {
                        if (Rock.Bounds.IntersectsWith(x.Bounds))
                        {
                            fuerza = 7;
                            Rock.Top = x.Top + Rock.Height;
                        }
                        //x.BringToFront();
                    }
                    if ((string)x.Tag == "bound2")
                    {
                        if (Rock.Bounds.IntersectsWith(x.Bounds))
                        {
                            Rock.Left = x.Left - Rock.Width;
                        }
                    }
                    if (((string)x.Tag == "bound1"))
                    {
                        if (Rock.Bounds.IntersectsWith(x.Bounds))
                        {
                            Rock.Left = x.Left + Rock.Width;
                        }
                    }
                    if (((string)x.Tag == "nmy" || (string)x.Tag == "gunner" || (string)x.Tag == "gordo"))
                    {
                        if (Rock.Bounds.IntersectsWith(x.Bounds))
                        {
                            GT.Stop();
                            Game_Over("Perdiste");
                        }
                    }
                    
                }
                //enemigo1.Left -= nmyvel1;
                //enemigo2.Left -= nmyvel2;
                if (enemigo2.Left < pictureBox10.Left || enemigo2.Left + enemigo2.Width > pictureBox10.Left + pictureBox10.Width)
                {
                    nmyvel2 = -nmyvel2;
                }
                gordo.Top += gordovel;
                if (gordo.Bounds.IntersectsWith((pictureBox18).Bounds))
                {
                    //gordo.Top = pictureBox22.Top + gordo.Height;
                    gordo.Top += gordovel;
                }
                if (gordo.Bounds.IntersectsWith((pictureBox1).Bounds))
                {
                    gordo.Top = -gordovel;
                }
                regordo.Top += regordovel;
                if (regordo.Bounds.IntersectsWith((pictureBox22).Bounds))
                {
                    //gordo.Top = pictureBox22.Top + gordo.Height;
                    regordo.Top += gordovel;
                }
                if (regordo.Bounds.IntersectsWith((pictureBox1).Bounds))
                {
                    regordo.Top = -regordovel;
                }
                morbido.Top += morbidovel;
                if (morbido.Bounds.IntersectsWith((pictureBox22).Bounds))
                {
                    //gordo.Top = pictureBox22.Top + gordo.Height;
                    morbido.Top += morbidovel;
                }
                if (morbido.Bounds.IntersectsWith((pictureBox11).Bounds))
                {
                    morbido.Top = -morbidovel;
                }
                if (Rock.Bounds.IntersectsWith((puerta).Bounds))
                {

                }
            }

        }

        private void dwn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) //esto comprueba si la tecla esta siendo presionada
            {
                Der = true;
                apuntando = "R";
            }
            if (e.KeyCode == Keys.A)
            {
                Izq = true;
                apuntando = "L";
            }
            if (e.KeyCode == Keys.Enter && disparo == false)
            {
                disparo = true;
                genLimones(apuntando);
            }
            if (e.KeyCode == Keys.Space && salto == false)
            {
                salto = true;
            }
        }

        private void plataformas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) //esto comprueba si la tecla esta siendo presionada
            {
                Der = false;
            }
            if (e.KeyCode == Keys.A)
            {
                Izq = false;
            }
            if (disparo == true)
            {
                disparo = false;
            }
            if (salto == true)
            {
                salto = false;
            }
            if (e.KeyCode == Keys.P && G_Over != true)
            {
                if (pause)
                {
                    GT.Start();
                    //Menu.Enabled = false;
                    //Menu.Visible = false;
                    //pause = false;
                }
                else
                {
                    //Menu.Visible = true;
                    //Menu.Enabled = true;
                    //titulo.Text = "En pausa";
                    //Start.Visible = false;
                    GT.Stop();
                    //Instrucciones1.Text = "Puedes presionar la tecla P para pausar";
                    pause = true;
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset ()
        {
            Menu.Enabled = false;
            Menu.Visible = false;
            salto = false;
            G_Over = false;
            score = 0;
            SlashSP = 4;
            Rock.Left = 1;
            Rock.Top = 520;
            enemigo1.Left = 369;
            enemigo2.Left = 1031;
            enemigo3.Left = 445;
            gordo.Top = 431;
            regordo.Top = 431;
            morbido.Top = 162;
            gunner.Left = 643;
            gunner2.Left = 312;
            gunner3.Left = 249;
            

            GT.Start();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Nivel0 start = new Nivel0();
            this.Hide();
            start.Show();
        }

        /*
private void mov()
{
   if (Izq) //esto controla el movimiento
   {
       Rock.Left -= vel;
   }
   if (Der)
   {
       Rock.Left += vel;
   }
   Rock.Top += impulso;
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
   if (Rock.Top > 663 && salto == false & score == 0)
   {
       fuerza = 12;
       Rock.Top = 663;
       impulso = 0;
   }
   if (Rock.Top >550 && salto == false & score != 0)
   {
       fuerza = 12;
       Rock.Top = 551;
       impulso = 0;
   }
   rakataka = 15;
   nmySpd = 2;
   nmyvel1 = 1;
   nmyvel2 = nmySpd;
   nmyvel3 = nmySpd;
   gordovel = nmySpd;
   regordovel = nmySpd;
   morbidovel = nmySpd;
   gunnervel1 = nmySpd;
   gunnervel2 = nmySpd;
   gunnervel3 = nmySpd;
}
*/
        private void limpiar_pantalla(PictureBox bala)
        {
            this.Controls.Remove(bala);
            bala.Dispose();
        }
        private void genLimones(string fcing)
        {
            PictureBox bala = new PictureBox();
            bala.Image = Properties.Resources.Limon;
            bala.SizeMode = PictureBoxSizeMode.Zoom;
            bala.BorderStyle = BorderStyle.None;
            bala.Height = 10;
            bala.Width = 10;
            if (fcing == "R")
            {
                bala.Left = Rock.Left + Rock.Width + 2;
                bala.Top = Rock.Top + Rock.Height / 8;
            }
            if (fcing == "L")
            {
                bala.Left = Rock.Left + Rock.Width - 2;
                bala.Top = Rock.Top + Rock.Height / 8;
            }
            bala.Tag = "limon";
            this.Controls.Add(bala);
        }
        private void GenBala()
        {
            PictureBox balan = new PictureBox();
            balan.BackColor = Color.LimeGreen;
            //balan.BorderStyle = BorderStyle.None;
            balan.Height = 10;
            balan.Width = 10;
            balan.Left = Rock.Left + Rock.Width + 2;
            balan.Top = Rock.Top + Rock.Height / 8;
            balan.Tag = "bullet";
            this.Controls.Add(balan);
        }

        public void back()
        {
            throw new NotImplementedException();
        }

        public void win()
        {
            throw new NotImplementedException();
        }
    }
}
