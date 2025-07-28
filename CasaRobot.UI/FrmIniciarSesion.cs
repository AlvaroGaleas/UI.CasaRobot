using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CasaRobot.UI
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }


        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void textIngresarUsuario_Enter(object sender, EventArgs e)
        {
            if (textIngresarUsuario.Text == "Usuario")
            {
                textIngresarUsuario.Text = "";
                textIngresarUsuario.ForeColor = Color.Black;
            }
        }

        private void textIngresarUsuario_Leave(object sender, EventArgs e)
        {
            if (textIngresarUsuario.Text == "")
            {
                textIngresarUsuario.Text = "Usuario";
                textIngresarUsuario.ForeColor = Color.Silver;
            }
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
