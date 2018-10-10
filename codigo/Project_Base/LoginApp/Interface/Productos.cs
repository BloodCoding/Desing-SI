using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.Interface
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }


        
        private void btnguardarproductos_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfiltro_Enter(object sender, EventArgs e)
        {
            if (txtfiltro.Text == "FILTRO")
            {
                txtfiltro.Text = "";
                txtfiltro.ForeColor = Color.LightGray;
            }
        }

        private void txtfiltro_Leave(object sender, EventArgs e)
        {
            if (txtfiltro.Text == "")
            {
                txtfiltro.Text = "FILTRO";
                txtfiltro.ForeColor = Color.DimGray;
            }
        }
    }
}
