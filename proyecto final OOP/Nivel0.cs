using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_OOP
{
    public partial class Nivel0 : Form
    {
        //esto probablemente sera parte de la clase Jugador
        Image rock;
        List<string> rmov = new List<string>();
        int reducirframe = 0;
        bool Sup, Inf, Izq, Der;
        int rockx, rocky;
        int rockh = 50; 
        int rockw = 34;
        int vel = 8;
        bool enter;

        public Nivel0()
        {
            InitializeComponent();
        }

        private void Ev_Juego(object sender, EventArgs e)
        {
            
            if (Izq) //esto controla el movimiento
            {
                MU.Left += vel;
                MU.Image = Properties.Resources.rock_R_sprites_01;
            }
            if (Der)
            {
                MU.Left -= vel;
                MU.Image = Properties.Resources.rock_L_sprites_01;
            }
            if (Sup)
            {
                MU.Top -= vel;
                MU.Image = Properties.Resources.rock_up_sprites_01;
            }
            if (Inf)
            {
                MU.Top += vel;
                MU.Image = Properties.Resources.rock_down_sprites_01;
            }
            if (Nivel_1.Bounds.IntersectsWith(MU.Bounds))
            {
                Nivel_1.Image = Properties.Resources.lvl1p;
            }
            if (Nivel_1.Bounds.IntersectsWith(MU.Bounds)) //cuando presionamos enter mientras tocamos el nivel 1, nos mandara pa alla
            {
                if (enter)
                {
                    Puzzle_D Lvl_1 = new Puzzle_D();
                    this.Hide();
                    Game_Time.Stop();
                    Lvl_1.Show();
                }
            }
            else
            {
                Nivel_1.Image = Properties.Resources.lvl1;
            }
            if (Nivel_2.Bounds.IntersectsWith(MU.Bounds))
            {
                Nivel_2.Image = Properties.Resources.lvl2p;
                if (enter == true)
                {
                    Memorama Lvl_2 = new Memorama();
                    this.Hide();
                    Game_Time.Stop();
                    Lvl_2.Show();
                }
            }
            else
            {
                Nivel_2.Image = Properties.Resources.lvl2;
            }
            /*
            if (Nivel_2.Bounds.IntersectsWith(MU.Bounds) && enter)
            {
                Memorama Lvl_2 = new Memorama();
                this.Hide();
                Game_Time.Stop();
                Lvl_2.Show();
            }*/
            if (Nivel_3.Bounds.IntersectsWith(MU.Bounds))
            {
                Nivel_3.Image = Properties.Resources.lvl3p;
                if (enter)
                {
                    Rockmaruga Lvl3 = new Rockmaruga();
                    this.Hide();
                    Game_Time.Stop();
                    Lvl3.Show();
                }
            }
            else
            {
                Nivel_3.Image = Properties.Resources.lvl3;
            }
            if (Nivel_4.Bounds.IntersectsWith(MU.Bounds))
            {
                Nivel_4.Image = Properties.Resources.lvl4p;
                if (enter)
                {
                    Coin_Collector Lvl4 = new Coin_Collector();
                    this.Hide();
                    Game_Time.Stop();
                    Lvl4.Show();
                }
            }
            else
            {
                Nivel_4.Image = Properties.Resources.lvl4;
            }
            if (Nivel_5.Bounds.IntersectsWith(MU.Bounds))
            {
                Nivel_5.Image = Properties.Resources.lvl5p;
                if (enter)
                {
                    MegaRun Lvl5 = new MegaRun();
                    this.Hide();
                    Game_Time.Stop();
                    Lvl5.Show();
                }
            }
            else
            {
                Nivel_5.Image = Properties.Resources.lvl5;
            }
            if (Nivel_6.Bounds.IntersectsWith(MU.Bounds))
            {
                Nivel_6.Image = Properties.Resources.lvl6p;
                if (enter)
                {
                    plataformas classic = new plataformas();
                    this.Hide();
                    Game_Time.Stop();
                    classic.Show();
                }
                
            }
            else
            {
                Nivel_6.Image = Properties.Resources.lvl6;
            }
            if (Final_boss.Bounds.IntersectsWith(MU.Bounds))
            {
                Final_boss.Image = Properties.Resources.lvl7p;
                if (enter)
                {
                    final_level end = new final_level();
                    this.Hide();
                    Game_Time.Stop();
                    end.Show();
                }

            }
            else
            {
                Final_boss.Image = Properties.Resources.lvl7;
            }
            if (ecsit.Bounds.IntersectsWith(MU.Bounds) && enter)
            {
                Init inicio = new Init();
                this.Hide();
                Game_Time.Stop();
                inicio.Show();
            }
        }

        private void Abajo(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) //esto comprueba si la tecla esta siendo presionada
            {
                Izq = true;
                
            }
            if (e.KeyCode == Keys.A)
            {
                Der = true;
                
            }
            if (e.KeyCode == Keys.W)
            {
                Sup = true;
            }
            if (e.KeyCode == Keys.S)
            {
                Inf = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                enter = true;
            }
        }

        private void Arriba(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) //esto comprueba que la tecla ya no esta siendo pulsada
            {
                Izq = false;
                MU.Image = Properties.Resources.rock_stand_r;
            }
            if (e.KeyCode == Keys.A)
            {
                Der = false;
                MU.Image = Properties.Resources.rock_stand_l;
            }
            if (e.KeyCode == Keys.W)
            {
                Sup = false;
                MU.Image = Properties.Resources.rock_stand_up;
            }
            if (e.KeyCode == Keys.S)
            {
                Inf = false;
                MU.Image = Properties.Resources.rock_stand;
            }
            if (e.KeyCode == Keys.Enter)
            {
                enter = false;
            }
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //apaga todo cuando salimos del formulario
        }
    }
}
