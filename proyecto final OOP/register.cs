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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proyecto_final_OOP
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AñadirBD_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string usrnm = textBox1.Text.Trim();
            login.instance.username = usrnm;
            usrepo regato = new usrepo();
            regato.register(nombre);
            usuarios usuario = usrepo.Login(usrnm);
            MessageBox.Show("se ha agregado su usuario");
            Init start = new Init();
            this.Hide();
            start.Show();
        }
    }
}
