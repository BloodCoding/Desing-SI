using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace LoginApp.Interface
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //ESTE METODO EN CONJUNTO DE LA LIBRERIA INTEROPSERVICES NOS PERMITEN ARRASTRAR EL FORMULARIO EN LA PANTALLA. 
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);﻿



        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnslide_Click(object sender, EventArgs e) //ESTE METODO ES PARA CAMBIAR EL ANCHO DEL MUENÚ. 
        {
            if (menuvertical.Width == 250)
            {
                menuvertical.Width = 70;
            }
            else
            {
                menuvertical.Width = 250;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barratitulo_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);

        }

        private void AbrirFormPanel(object formhijo)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();



        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel( new Productos());
        }
    }
}
