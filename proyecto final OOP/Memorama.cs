using proyecto_final_OOP.InterFs;
using System;
using System.Collections;
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
    public partial class Memorama : Form,Ireturn
    {
        public static Memorama Instance;
        int Grid_Size = 4;
        int Movimiento = 0;
        int Cartas_volteadas = 0;
        List<string> Numcarta;
        List<string> Cartas_Revueltas;
        ArrayList cs;
        PictureBox tmp1;
        PictureBox tmp2;
        int Cartactual = 0;
        public int score = 10;
        SoundPlayer ost;
        public Memorama()
        {
            ost = new SoundPlayer(Properties.Resources.memorama_relax);
            InitializeComponent();
            Iniciar_Juego();
            Instance = this;
        }
        public void Iniciar_Juego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            Record.Text = "0";
            Cartas_volteadas = 0;
            Movimiento = 0;
            Juego.Controls.Clear();
            Numcarta = new List<string>();
            Cartas_Revueltas = new List<string>();
            cs = new ArrayList();
            for (int i = 0; i < 8;  i++)
            {
                Numcarta.Add(i.ToString());
                Numcarta.Add(i.ToString());
            }
            var RNG = new Random();
            var resultado = Numcarta.OrderBy(item => RNG.Next());
            foreach (string ValorCarta  in resultado)
            {
                Cartas_Revueltas.Add(ValorCarta);
            }
            var tabla_panel = new TableLayoutPanel();
            tabla_panel.RowCount = Grid_Size;
            tabla_panel.ColumnCount = Grid_Size;
            for (int i = 0;i < Grid_Size;i++)
            {
                var porcentaje = 150f / (float)Grid_Size - 10;
                tabla_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,porcentaje));
                tabla_panel.RowStyles.Add(new RowStyle(SizeType.Percent,porcentaje));
            }
            int contador_Fichas = 1;
            for (var i = 0; i < Grid_Size;i++)
            {
                for (var j = 0; j < Grid_Size;j++)
                {
                    var BattleChips = new PictureBox();
                    BattleChips.Name = string.Format("{0}", contador_Fichas);
                    BattleChips.Dock = DockStyle.Fill;
                    BattleChips.SizeMode = PictureBoxSizeMode.StretchImage;
                    BattleChips.Image = Properties.Resources.girada;
                    BattleChips.Cursor = Cursors.Hand;
                    BattleChips.Click += Card_Clk;
                    tabla_panel.Controls.Add(BattleChips,j,i);
                    contador_Fichas++;
                }
            }
            tabla_panel.Dock = DockStyle.Fill;
            Juego.Controls.Add(tabla_panel);
        }

        private void Card_Clk(object sender, EventArgs e)
        {
            if (cs.Count < 2)
            {
                Movimiento++;
                Record.Text = Convert.ToString(Movimiento);
                var CartaSelect = (PictureBox)sender;
                Cartactual = Convert.ToInt32(Cartas_Revueltas[Convert.ToInt32(CartaSelect.Name) - 1]);
                CartaSelect.Image = Recuperar_Img(Cartactual);
                cs.Add(CartaSelect);
                if(cs.Count==2)
                {
                    tmp1 = (PictureBox)cs[0];
                    tmp2 = (PictureBox)cs[1];
                    int C1 = Convert.ToInt32(Cartas_Revueltas[Convert.ToInt32(tmp1.Name) - 1]);
                    int C2 = Convert.ToInt32(Cartas_Revueltas[Convert.ToInt32(tmp2.Name) - 1]);
                    if (C1 != C2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        Cartas_volteadas++;
                        if (Cartas_volteadas > 7)
                        {
                            win();
                        }
                        tmp1.Enabled = false ; tmp2.Enabled = false;
                        cs.Clear();
                    }

                }
            }
        }
        public Bitmap Recuperar_Img(int Num_img)
        {
            Bitmap Tmp_I = new Bitmap(200, 100);
            switch (Num_img)
            {
                case 0: Tmp_I = Properties.Resources._11;
                    break;
                default: Tmp_I = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + Num_img);
                    break;
            }
            return Tmp_I;
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            Iniciar_Juego();
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void virar(object sender, EventArgs e)
        {
            int Tiempo_Virar_C = 1;
            if (Tiempo_Virar_C ==1 )
            {
                tmp1.Image=Properties.Resources.girada;
                tmp2.Image=Properties.Resources.girada;
                cs.Clear();
                Tiempo_Virar_C = 0;
                timer1.Stop();
            }

        }

        public void back()
        {
            Nivel0 start = new Nivel0();
            this.Hide();
            start.Show();
        }

        public void win()
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

        private void salir_Click(object sender, EventArgs e)
        {
            back();
        }

        private void Memorama_Load(object sender, EventArgs e)
        {
            ost.Play();
        }
    }
}
