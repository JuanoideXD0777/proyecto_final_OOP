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
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }
        //al presionar el boton 1, se abre el formulario nivel 0
        private void button1_Click(object sender, EventArgs e) //iniciar juego
        {
            Nivel0 start = new Nivel0();
            this.Hide();
            start.Show();
        }

        private void button3_Click(object sender, EventArgs e) //ver puntajes
        {
            Acerca_De ad = new Acerca_De();
            this.Hide();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e) //configuracion
        {
            ConfigP conf = new ConfigP();
            this.Hide();
            conf.Show();
        }

        private void close(object sender, FormClosedEventArgs e) //salir de la aplicacion
        {
            Application.Exit();
        }
    }
}
