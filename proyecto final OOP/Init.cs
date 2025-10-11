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
        private void button1_Click(object sender, EventArgs e)
        {
            Nivel0 start = new Nivel0();
            this.Hide();
            start.Show();
        }
    }
}
