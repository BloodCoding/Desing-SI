using BackenApp.Pruebas;
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

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clave = Project_Base.Properties.Settings.Default.key_encrypt;
            PruebaUsuarios prueba = new PruebaUsuarios();
            prueba.mostrardatos(0);
            dataGridView1.DataSource = prueba.datosParaGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PruebaUsuarios prueba = new PruebaUsuarios();
            dataGridView1.DataSource = prueba.filtroParaGrid(textBox1.Text);
        }
    }
}
