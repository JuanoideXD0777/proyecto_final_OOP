using proyecto_final_OOP.InterFs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_OOP
{
    public partial class Puzzle_D : Form,Ireturn
    {
        public static Puzzle_D instance;
        List<PictureBox> pblis = new List<PictureBox>(); //cuando se cargue la imagen, sus datos se guardaran en esta lista
        List<Bitmap> Imagendurisima = new List<Bitmap>();
        List<string> Pos = new List<string>(); //esto nos ayudara para saber cuando ganamos
        List<string> Pos_Act = new List<string>(); //esto solo mide cuanto falta para ganar

        string win;
        string Aun_No;
        Bitmap MbM;
        SoundPlayer ost;
        public int score = 10;
        public Puzzle_D()
        {
            ost = new SoundPlayer(Properties.Resources.puzzle_relax);
            InitializeComponent();
            instance = this;
        }

        private void Puzzle_D_Load(object sender, EventArgs e)
        {
            ost.Play();
        }
        //las siguientes funciones seran parte de la clase Sliding_P
        private void CrearPB()
        {
            for (int i = 0; i<9; i++)
            {
                PictureBox tmp = new PictureBox();
                tmp.Size = new Size(130, 130);
                tmp.Tag = i.ToString();
                tmp.Click += On_Clk;
                pblis.Add(tmp);
                Pos.Add(i.ToString());
            }
        }

        private void On_Clk(object sender, EventArgs e)
        {
            PictureBox p_b = (PictureBox)sender;
            PictureBox Bloque_Azul = pblis.Find(x => x.Tag.ToString() == "0");
            Point I1 = new Point(p_b.Location.X, p_b.Location.Y);
            Point I2 = new Point(Bloque_Azul.Location.X, Bloque_Azul .Location.Y);
            var index1 = this.Controls.IndexOf(p_b);
            var index2 = this.Controls.IndexOf(Bloque_Azul);
            if (p_b.Right == Bloque_Azul.Left && p_b.Location.Y == Bloque_Azul.Location.Y 
                || p_b.Left == Bloque_Azul.Right && p_b.Location.Y==Bloque_Azul.Location.Y
                || p_b.Top == Bloque_Azul.Bottom && p_b.Location.X == Bloque_Azul.Location.X
                || p_b.Bottom == Bloque_Azul.Top && p_b.Location.X == Bloque_Azul.Location.X)
            {
                p_b.Location = I2;
                Bloque_Azul.Location = I1;
                this.Controls.SetChildIndex(p_b, index2);
                this.Controls.SetChildIndex(Bloque_Azul, index1);
            }
            Pos_Act.Clear();
            checkgame();
        }

        private void Crear_P(Bitmap Principal, int height, int with)
        {
            int x, y;
            x = 0;
            y = 0;

            for (int block = 0; block < 9; block++)
            {
                Bitmap P_Imagen = new Bitmap(height, with);
                for (int i = 0;i < height;i++)
                {
                    for(int j = 0;j < with;j++)
                    {
                        P_Imagen.SetPixel(i, j, Principal.GetPixel((i+x),(j+y)));
                    }
                }
                Imagendurisima.Add(P_Imagen);
                x += 130;
                if (x== 390)
                {
                    x = 0;
                    y += 130;
                }
            }
        }
        private void Crear_Imagen(Bitmap MbM)
        {
            Bitmap tmp_B = new Bitmap(MbM, new Size(390,390));

            Crear_P(tmp_B, 130, 130);
            for (int i = 1; i < pblis.Count;i++)
            {
                pblis[i].BackgroundImage = (Image)Imagendurisima[i];
            }
            Dar_Formato();
        }
        private void Dar_Formato()
        {
            var Shuffle = pblis.OrderBy(a=>Guid.NewGuid()).ToList();
            pblis = Shuffle;

            int x = 200;
            int y = 25;
            for (int i = 0; i < pblis.Count;i++)
            {
                pblis[i].BackColor =Color.BlueViolet;
                if (i ==3 || i ==6)
                {
                    y += 130;
                    x = 200;
                }
                pblis[i].BorderStyle = BorderStyle.FixedSingle;
                pblis[i].Location = new Point(x, y);
                this.Controls.Add(pblis[i]);
                x += 130;
                win += Pos[i];
            }

        }
        private void checkgame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    Pos_Act.Add(x.Tag.ToString());
                }
            }
            Aun_No = string.Join("", Pos_Act);
            if (win == Aun_No)
            {
                DialogResult vol = MessageBox.Show("¡Nivel Completado!\n¿Volver al selector de nivel?", "Has ganado", MessageBoxButtons.YesNo);
                if (vol == DialogResult.Yes)
                {
                    Nivel0 start = new Nivel0();
                    this.Hide();
                    start.Show();
                }
                else if (vol == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void cerrar(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pblis != null) //si la imagen estaba cargada previamente, la borra y vuelve a cargar
            {
                foreach (PictureBox pictur in pblis.ToList())
                {
                    this.Controls.Remove(pictur);
                }
                pblis.Clear();
                Imagendurisima.Clear();
                Pos.Clear();
                Pos_Act.Clear();
                win = string.Empty;
                Aun_No = string.Empty;
            }
            //esto probablemente sea parte de otra clase
            /*
            String Obt_Folder = "C:\\Users\\jadey\\Downloads\\I\\test 2\\proyecto final OOP\\proyecto final OOP";
            string Pic = "imagen_durisima.jpeg";
            string rutapic = Path.Combine(Obt_Folder, "Resources", Pic);
            try
            {
                System.Diagnostics.Process.Start(rutapic);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la imagen: " + ex.Message);
            }
            
            String Obt_Folder = AppDomain.CurrentDomain.BaseDirectory;
            OpenFileDialog Pic = new OpenFileDialog();
            Pic.InitialDirectory = Obt_Folder;
            Pic.Filter = "Solo imagenes|*.jpeg";
            if (Pic.ShowDialog() == DialogResult.OK)
            {
                //Process.Start(rutapic);
                MbM = new Bitmap(Pic.FileName);
                CrearPB();
                Crear_Imagen();
            }
            else
            {
                MessageBox.Show("Error al abrir el archivo");
            }
            */
            String Obt_Folder = "C:\\Users\\jadey\\Downloads\\I\\test 2\\proyecto final OOP\\proyecto final OOP\\Resources";
            OpenFileDialog Pic = new OpenFileDialog();
            Pic.InitialDirectory = Obt_Folder;
            Pic.Filter = "Solo imagenes|*.jpeg";
            if (Pic.ShowDialog() == DialogResult.OK)
            {
                //Process.Start(rutapic);
                MbM = new Bitmap(Pic.FileName);
                CrearPB();
                Crear_Imagen(MbM);
            }
            else
            {
                MessageBox.Show("Error al abrir el archivo");
            }
        }

        public void back()
        {
            Nivel0 start = new Nivel0();
            this.Hide();
            start.Show();
        }

        void Ireturn.win()
        {
            throw new NotImplementedException();
        }

        private void salir_clk(object sender, EventArgs e)
        {
            back();
        }
    }
}
