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
    public partial class ConfigP : Form
    {
        int clk = 0;
        SoundPlayer ost;
        
        public ConfigP()
        {
            ost = new SoundPlayer(Properties.Resources.hubworld);
            InitializeComponent();
        }
        private void ConfigP_Load(object sender, EventArgs e)
        {
            ost.Play();
            if (clk == 0) //si no has presionado el boton login
            {
                label1.Text = "no estas registrado";
            }
            else
            {//de otro modo
                label1.Text = "registrado";
            }
        }

        private void login_Click(object sender, EventArgs e)
        {//cuando presiones este boton, iras al formulario de login
            login log = new login();
            this.Hide();
            log.Show();
            clk++;
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Init start = new Init();
            this.Hide();
            start.Show();
        }

        
    }
}
