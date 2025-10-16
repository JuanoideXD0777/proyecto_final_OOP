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
    public partial class login : Form
    {
        public static login instance;
        public string username;
        SoundPlayer player;
        public login()
        {
            player = new SoundPlayer(Properties.Resources.classic);
            InitializeComponent();
            instance = this;
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text.Trim(); //recoge lo que hayas escrito aqui
            //string password = tb_psw.Text.Trim();
            if (username == "") //se asegura de que no lo dejaras en blanco
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            usuarios usuario = usrepo.Login(username);
            if (usuario.Nombre == username) //si el usuario esta registrado
            {
                Init start = new Init(); //regresas al inicio
                this.Hide();
                start.Show();
            }
            else
            { //si no, pregunta si quieres registrarte
                DialogResult vol = MessageBox.Show("¡no estas registrado!\n¿quieres registrarte?", "Error", MessageBoxButtons.YesNo);
                if (vol == DialogResult.Yes)
                {
                    //si te quieres registrar, vas pá register 
                    register start = new register();
                    this.Hide();
                    start.Show();
                }
                else if (vol == DialogResult.No)
                {//si no, vuelves al inicio
                    Init start = new Init();
                    this.Hide();
                    start.Show();
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
