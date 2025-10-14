using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//con este comando podemos convertir a clases los elementos en el nivel anterior

namespace proyecto_final_OOP.Objeks
{
    //a hueso digo er weso ya finalmente tenemos la primera clase, ahora solo nos faltan otras 7 xdxdxdxd
    internal class ghostnaviCC
    {
        int spd = 6;
        int Xpd = 3;
        int Ypd = 3;
        int maxH = 666;
        int maxW = 949;
        int minH = 58;
        int minW = 48;
        int cambio;
        Random RNG = new Random();
        string[] Dir = { "L", "R", "UP", "DOWN" , "Buscar"};
        string Ddir = "L";
        public PictureBox imagen = new PictureBox();

        public ghostnaviCC(Form Coin_Collector, Image img, int x, int y)
        {
            imagen.Image = img;
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen.Tag = "Gn";
            imagen.Width = 50;
            imagen.Height = 50;
            imagen.Left = x;
            imagen.Top = y;
            Coin_Collector.Controls.Add(imagen);
        }
        public void GhostnaviMov(PictureBox rocman)
        {
            if (cambio > 0)
            {
                cambio--;
            }
            else
            {
                cambio = RNG.Next(50, 80);
                Ddir = Dir[RNG.Next(Dir.Length)];
            }

            switch (Ddir)
            {
                case "L":
                    imagen.Left -= spd;
                    break;
                case "R":
                    imagen.Left += spd;
                    break;
                case "UP":
                    imagen.Top -= spd;
                    break;
                case "DOWN":
                    imagen.Top += spd;
                    break;
                case "Buscar":
                    if (imagen.Left > rocman.Left)
                    {
                        imagen.Left -= Xpd;
                    }
                    if (imagen.Left < rocman.Left)
                    {
                        imagen.Left += Xpd;
                    }
                    if (imagen.Top > rocman.Top)
                    {
                        imagen.Top -= Ypd;
                    }
                    if (imagen.Top < rocman.Top)
                    {
                        imagen.Top += Ypd;
                    }
                    break;
            }

            if (imagen.Left<minW)
            {
                Ddir = "R";
            }
            if (imagen.Left + imagen.Width > maxW)
            {
                Ddir = "L";
            }
            if (imagen.Top < minH)
            {
                Ddir = "DOWN";
            }
            if (imagen.Top + imagen.Height > maxH)
            {
                Ddir = "UP";
            }
        }
        public void Cambiar_Dir()
        {
            Ddir = Dir[RNG.Next(Dir.Length)];
        }
        //fantasmano 935, 666
        //fantasmatico 60, 589
        //fanta asmatico 949, 82
        //gasparin 48, 58
    }
}
