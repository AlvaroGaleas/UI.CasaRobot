using CasaRobot.UI.Models;
using CasaRobot.UI.Seguridad;
using CasaRobot.UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaRobot.UI.Forms
{
    public partial class EstadosForm : Form
    {
        private readonly EstadoService _estadoService = new EstadoService();
        private int estadoSeleccionadoId = 0;
        public EstadosForm()
        {
            InitializeComponent();
        }

        private async void EstadosForm_Load(object sender, EventArgs e)
        {

            if (!SesionUsuario.EstaAutenticado)
            {
                MessageBox.Show("Debe iniciar sesión para acceder.");
                this.Close();
                return;
            }

            lblUsuario.Text = $"Usuario: {SesionUsuario.NombreUsuario} ({SesionUsuario.Rol})";

            if (SesionUsuario.Rol != "Administrador" && SesionUsuario.Rol != "Supervisor")
            {
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                MessageBox.Show("Solo lectura: no tiene permisos para modificar clientes.");
            }
            await CargarEstados();
        }
        private async Task CargarEstados()
        {
            var estados = await _estadoService.ObtenerEstadosAsync();
            dgvEstados.DataSource = estados;
        }

        private void dgvEstados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvEstados.Rows[e.RowIndex];
                estadoSeleccionadoId = Convert.ToInt32(fila.Cells["EstadoID"].Value);
                txtNombreEstado.Text = fila.Cells["NombreEstado"].Value?.ToString();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            var estado = new Estado
            {
                NombreEstado = txtNombreEstado.Text
            };

            var exito = await _estadoService.CrearEstadoAsync(estado);
            if (exito)
            {
                MessageBox.Show("Estado registrado.");
                await CargarEstados();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (estadoSeleccionadoId == 0) return;
            if (!ValidarCampos()) return;
            var estado = new Estado
            {
                EstadoID = estadoSeleccionadoId,
                NombreEstado = txtNombreEstado.Text
            };

            var exito = await _estadoService.ActualizarEstadoAsync(estado);
            if (exito)
            {
                MessageBox.Show("Estado actualizado.");
                await CargarEstados();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (estadoSeleccionadoId == 0) return;

            var confirmar = MessageBox.Show("¿Eliminar estado?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                var exito = await _estadoService.EliminarEstadoAsync(estadoSeleccionadoId);
                if (exito)
                {
                    MessageBox.Show("Estado eliminado.");
                    await CargarEstados();
                }
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreEstado.Text))
            {
                MessageBox.Show("El nombre del estado es obligatorio.");
                txtNombreEstado.Focus();
                return false;
            }


            return true;
        }

    }
}
