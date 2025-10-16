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

namespace proyecto_final_OOP
{
    public partial class final_level : Form, IG_Over,Ireturn
    {
        public static final_level instance;
        SoundPlayer ost;
        public int score = 0;
        int preguntaCorr; //se combina con el tag para elegir la respuesta
        int numP = 1; //sirve para conocer en que pregunta estamos
        int porcentaje;
        int totalP; //es el numero total de preguntas
        public final_level()
        {
            ost = new SoundPlayer(Properties.Resources.glorious);
            InitializeComponent();
            instance = this;
            preguntar(numP); 
            totalP = 5; //se fija el numero maximo de preguntas
        }

        public void back()
        {
            Nivel0 start = new Nivel0();
            this.Hide();
            start.Show();
        }

        public void Game_Over(string str)
        {
            MessageBox.Show($"{str}, no que bruto" + Environment.NewLine + "has respondido todas mal" + Environment.NewLine + "tu porcentaje es del 0%" + Environment.NewLine + "presiona ok para reintentar");
            score = 0;
            numP = 1;
            preguntar(numP);
        }

        public void win()
        {
            DialogResult vol = MessageBox.Show("¡Victory!\nHas terminado el juego\n¿quieres seguir jugando?", "S:/T/A/G/E/ C.L.E.A.R.", MessageBoxButtons.YesNo);
            if (vol == DialogResult.Yes)
            {
                score = 0;
                numP = 1;
                preguntar(numP);

            }
            else if (vol == DialogResult.No)
            {
                Nivel0 start = new Nivel0();
                this.Hide();
                start.Show();
                score = score + 1000;
            }
        }

        private void clk(object sender, EventArgs e) //los 4 botones estan conectados a este evento
        {
            var senderObjekt = (Button)sender; //convierte el boton seleccionado en un objeto
            int botonTag = Convert.ToInt32(senderObjekt.Tag); //lee el tag del boton seleccionado y lo convierte en un numero entero
            if (botonTag == preguntaCorr ) //si el tag es igual al numero correcto de la lista
            {
                score++; //aumenta el score
            }

            if (numP == totalP) //cuando se haya respondido la ultima pregunta
            {
                porcentaje = (int)Math.Round((double)(score * 100 / totalP)); //genera un porcentaje. al final no lo utilice XD
                if (score == 0) //si respondes todas mal, pierdes
                {
                    Game_Over("baboso");
                }
                else //si respondes aunque sea una bien, ganaste
                {
                    win(); 
                }
            }
            //esto se encarga de pasar a la siguiente pregunta
            numP++; 
            preguntar(numP);
        }
        private void preguntar (int Qnum) //utiliza un switch para mostrar las preguntas
        {
            switch (Qnum)
            {
                case 1: //si estamos en la pregunta 1, osea preguntar (numP) cuando numP es igual a 1:
                    tablon_imagen.Image = Properties.Resources.MM6_PlantBarrier;//insertar picturebox
                    pregunta.Text = "de que robot master es el arma plant barrier";//hace la pregunta
                    button1.Text = "Plantman"; //cambia el texto de los botones
                    button2.Text = "groundman"; //a las respuestas
                    button3.Text = "dustman";
                    button4.Text = "gutsman";

                    preguntaCorr = 1; //numero del boton
                    break;
                case 2:
                    tablon_imagen.Image = Properties.Resources.zero;
                    pregunta.Text = "en cual megaman x puedes jugar con zero contra los jefes";
                    button1.Text = "X9"; 
                    button2.Text = "X3"; 
                    button3.Text = "Z";
                    button4.Text = "X4";
                    preguntaCorr = 4;
                    break;
                case 3:
                    tablon_imagen.Image = Properties.Resources.light_armor;
                    pregunta.Text = "como se llama la armadura del primer megaman x";
                    button1.Text = "power armor";
                    button2.Text = "light armor";
                    button3.Text = "Zero armor";
                    button4.Text = "x armor";
                    preguntaCorr = 2;
                    break;
                case 4:
                    tablon_imagen.Image = Properties.Resources.bassEXE;
                    pregunta.Text = "el diseño de bass.exe es unico ya que...";
                    button1.Text = "es negro";
                    button2.Text = "fue el primer netnavi creado";
                    button3.Text = "es el unico netnavi que usa tela";
                    button4.Text = "es un enemigo de la saga x";
                    preguntaCorr = 3;
                    break;
                case 5:
                    tablon_imagen.Image = Properties.Resources.Megabuster;
                    pregunta.Text = "megaman netnavi es el unico megaman que...";
                    button1.Text = "tiene un hermano :v";
                    button2.Text = "tiene los ojos verdes";
                    button3.Text = "derroto a sigma";
                    button4.Text = "tiene el buster en la mano derecha";
                    preguntaCorr = 4;
                    break;
            }
        }

        private void esc(object sender, EventArgs e)
        {
            back();
        }

        private void xit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void final_level_Load(object sender, EventArgs e)
        {
            ost.Play();
        }
    }
}
