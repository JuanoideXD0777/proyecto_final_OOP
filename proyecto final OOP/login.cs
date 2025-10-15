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
    public partial class login : Form
    {
        public static login instance;
        public string username;
        public login()
        {
            InitializeComponent();
            instance = this;
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text.Trim();
            //string password = tb_psw.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            usuarios usuario = usrepo.Login(username);
            if (usuario.Nombre == username)
            {
                Init start = new Init();
                this.Hide();
                start.Show();
            }
            else
            {
                DialogResult vol = MessageBox.Show("¡no estas registrado!\n¿quieres registrarte?", "Error", MessageBoxButtons.YesNo);
                if (vol == DialogResult.Yes)
                {

                    register start = new register();
                    this.Hide();
                    start.Show();
                }
                else if (vol == DialogResult.No)
                {
                    Init start = new Init();
                    this.Hide();
                    start.Show();
                }
            }
        }
    }
}
