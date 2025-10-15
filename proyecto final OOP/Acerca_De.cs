using proyecto_final_OOP.Objeks;
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
    public partial class Acerca_De : Form
    {
        public Acerca_De()
        {
            InitializeComponent();
        }

        private void Acerca_De_Load(object sender, EventArgs e)
        {
            score_repo replib = new score_repo();
            Score_GRID.DataSource = replib.Obtener_D();
            int T_score, rkscore,ccscore,mgrscore;
            string nombre;
            score_repo nurepo = new score_repo();
            if (login.instance == null)
            {
                nombre = "Desconocido";
            }
            else
            {
                nombre = login.instance.username;
            }
            if (Rockmaruga.instance == null & Coin_Collector.instance == null & MegaRun.instance == null)
            {
                T_score = 40;
                rkscore = 0;
                ccscore = 0;
                mgrscore = 0;
            }
            else if (Rockmaruga.instance != null & Coin_Collector.instance == null & MegaRun.instance == null)
            {
                T_score = Rockmaruga.instance.score;
                rkscore = Rockmaruga.instance.score;
                ccscore = 0;
                mgrscore = 0;
            }
            else if (Rockmaruga.instance != null & Coin_Collector.instance != null & MegaRun.instance == null)
            {
                T_score = Rockmaruga.instance.score + Coin_Collector.instance.score;
                rkscore = Rockmaruga.instance.score;
                ccscore = Coin_Collector.instance.score;
                mgrscore = 0;
            }
            else
            {
                T_score = Rockmaruga.instance.score + Coin_Collector.instance.score + MegaRun.instance.score;
                rkscore = Rockmaruga.instance.score;
                ccscore = Coin_Collector.instance.score;
                mgrscore = MegaRun.instance.score;
            }
            
            //nombre = "ramon";
            Usr.Text = nombre;
            Score.Text = "Puntaje total:" + T_score;
            nurepo.Regscore(T_score,rkscore,ccscore,mgrscore,nombre);

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
