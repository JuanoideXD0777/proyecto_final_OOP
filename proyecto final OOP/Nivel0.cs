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
        bool Sup, Inf, Izq, Der;
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
            }
            if (Der)
            {
                MU.Left -= vel;
            }
            if (Sup)
            {
                MU.Top -= vel;
            }
            if (Inf)
            {
                MU.Top += vel;
            }
            if (Nivel_1.Bounds.IntersectsWith(MU.Bounds) && enter) //cuando presionamos enter mientras tocamos el nivel 1, nos mandara pa alla
            {
                Puzzle_D Lvl_1 = new Puzzle_D();
                this.Hide();
                Game_Time.Stop();
                Lvl_1.Show();
            }
            if (Nivel_2.Bounds.IntersectsWith(MU.Bounds) && enter)
            {
                Memorama Lvl_2 = new Memorama();
                this.Hide();
                Game_Time.Stop();
                Lvl_2.Show();
            }
            if (Nivel_3.Bounds.IntersectsWith(MU.Bounds) && enter)
            {
                Rockmaruga Lvl3 = new Rockmaruga();
                this.Hide();
                Game_Time.Stop();
                Lvl3.Show();
            }
            if (Nivel_4.Bounds.IntersectsWith(MU.Bounds) && enter)
            {
                Coin_Collector Lvl4 = new Coin_Collector();
                this.Hide();
                Game_Time.Stop();
                Lvl4.Show();
            }
            if (Nivel_5.Bounds.IntersectsWith(MU.Bounds) && enter)
            {
                MegaRun Lvl5 = new MegaRun();
                this.Hide();
                Game_Time.Stop();
                Lvl5.Show();
            }
            if (Nivel_6.Bounds.IntersectsWith(MU.Bounds) && enter)
            {
                plataformas classic = new plataformas();
                this.Hide();
                Game_Time.Stop();
                classic.Show();
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
            }
            if (e.KeyCode == Keys.A)
            {
                Der = false;
            }
            if (e.KeyCode == Keys.W)
            {
                Sup = false;
            }
            if (e.KeyCode == Keys.S)
            {
                Inf = false;
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
