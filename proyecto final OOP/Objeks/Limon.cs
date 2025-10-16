using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_OOP.Objeks
{
    internal class Limon
    {
        public string direccion;
        public int limon_L;
        public int limon_T;

        private int vl = 12;
        private PictureBox lime = new PictureBox();
        private Timer Bullet_Time = new Timer();

        public void Balistica(Form CC) //genera los limones
        {
            lime.Image = Properties.Resources.Limon;
            lime.Size = new Size(15,15);
            lime.SizeMode = PictureBoxSizeMode.Zoom;
            lime.BorderStyle = BorderStyle.None;
            lime.Tag = "Proyectil";
            lime.Left = limon_L;
            lime.Top = limon_T;
            lime.BringToFront();
            CC.Controls.Add(lime);

            Bullet_Time.Interval = vl;
            Bullet_Time.Tick += new EventHandler(Bullet_Time_EV);
            Bullet_Time.Start();
        }

        private void Bullet_Time_EV(object sender, EventArgs e) //es el timer que se encarga del movimiento de los limones, funciona cuando le da la gana xdxd
        {
            if (direccion == "Le")
            {
                lime.Left -= vl;
            }
            if (direccion == "Ri")
            {
                lime.Left += vl;
            }
            if (direccion == "W")
            {
                lime.Top -= vl;
            }
            if (direccion == "S")
            {
                lime.Top += vl;
            }
            
            if (lime.Left < 10 || lime.Left > 1010 || lime.Top < 10 || lime.Top > 520)
            {
                Bullet_Time.Stop();
                Bullet_Time.Dispose();
                lime.Dispose();
                Bullet_Time = null;
                lime = null;
            }
        }
    }
}
