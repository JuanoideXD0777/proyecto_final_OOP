using proyecto_final_OOP.Objeks;
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

namespace proyecto_final_OOP
{
    public partial class Acerca_De : Form
    {
        SoundPlayer ost;
        public Acerca_De()
        {
            ost = new SoundPlayer(Properties.Resources.menu);
            InitializeComponent();
        }

        private void Acerca_De_Load(object sender, EventArgs e)
        {
            ost.Play();
            //al cargar el formulario
            score_repo replib = new score_repo();
            Score_GRID.DataSource = replib.Obtener_D(); //muestra los puntajes globales en el gridview
            int T_score, rkscore,ccscore,mgrscore; //estas variables serviran para registrar el puntaje
            string nombre;
            score_repo nurepo = new score_repo();
            if (login.instance == null) //si no estas registrado
            {
                nombre = "Desconocido"; //tu nombre es desconocido
            }
            else
            {
                nombre = login.instance.username; //de otro modo, aparecera tu nobre de usuario
            }
            if (Rockmaruga.instance != null & Coin_Collector.instance == null & MegaRun.instance == null & final_level.instance == null)
            {//si solo jugaste a rockmaruga, ese sera tu score
                T_score = Rockmaruga.instance.score;
                rkscore = Rockmaruga.instance.score;
                ccscore = 0;
                mgrscore = 0;
            }
            else if (Rockmaruga.instance != null & Coin_Collector.instance != null & MegaRun.instance == null & final_level.instance == null)
            {//si jugaste rockmaruga y coin collector, se sumaran ambos puntajes
                T_score = Rockmaruga.instance.score + Coin_Collector.instance.score;
                rkscore = Rockmaruga.instance.score;
                ccscore = Coin_Collector.instance.score;
                mgrscore = 0;
            }
            else if (Rockmaruga.instance != null & Coin_Collector.instance != null & MegaRun.instance != null & final_level.instance == null)
            {//si jugaste casi todos los niveles menos el final, estos seran tus puntajes
                T_score = Rockmaruga.instance.score + Coin_Collector.instance.score + MegaRun.instance.score;
                rkscore = Rockmaruga.instance.score;
                ccscore = Coin_Collector.instance.score;
                mgrscore = MegaRun.instance.score;
            }
            else if (Rockmaruga.instance == null & Coin_Collector.instance == null & MegaRun.instance == null & final_level.instance == null & final_level.instance != null)
            {
                T_score = 40 + final_level.instance.score;
                rkscore = 0;
                ccscore = 0;
                mgrscore = 0;
            }
            else if (Rockmaruga.instance != null & Coin_Collector.instance != null & MegaRun.instance != null & final_level.instance != null)
            {//si completaste el juego, estos seran tus puntajes
                T_score = Rockmaruga.instance.score + Coin_Collector.instance.score + MegaRun.instance.score + final_level.instance.score;
                rkscore = Rockmaruga.instance.score;
                ccscore = Coin_Collector.instance.score;
                mgrscore = MegaRun.instance.score;
            }
            //si no has jugado ningun nivel, tu score es 40
            else
            {
                T_score = 40;
                rkscore = 0;
                ccscore = 0;
                mgrscore = 0;
            }

            //nombre = "ramon";
            Usr.Text = nombre; //mostrara tu nombre de usuario
            Score.Text = "Puntaje total:" + T_score;  //mostrara tu puntaje local
            nurepo.Regscore(T_score,rkscore,ccscore,mgrscore,nombre); //y lo subira a la base de datos

        }

        private void back_Click(object sender, EventArgs e)
        {
            Init start = new Init();
            this.Hide();
            start.Show();
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
