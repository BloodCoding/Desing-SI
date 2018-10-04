using ControladoresApp.Pruebas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Base
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clave = Project_Base.Properties.Settings.Default.key_encrypt;
            PruebasUsuarios prueba = new PruebasUsuarios();
            prueba.agregarUsuario(clave);
        }
    }
}
