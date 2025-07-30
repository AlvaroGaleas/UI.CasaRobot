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
    public partial class EquiposForm : Form
    {
        private readonly EquipoService _equipoService = new EquipoService();
        private readonly ClienteService _clienteService = new ClienteService();
        private int equipoSeleccionadoId = 0;
        private List<Cliente> clientes = new List<Cliente>();
        public EquiposForm()
        {
            InitializeComponent();
        }

        private async void EquiposForm_Load(object sender, EventArgs e)
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
            await CargarClientes();
            await CargarEquipos();
        }
        private async Task CargarClientes()
        {
            clientes = await _clienteService.ObtenerClientesAsync();
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "ClienteID";
        }
        private async Task CargarEquipos()
        {
            var equipos = await _equipoService.ObtenerEquiposAsync();
            dgvEquipos.DataSource = equipos;
        }

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvEquipos.Rows[e.RowIndex];
                equipoSeleccionadoId = Convert.ToInt32(fila.Cells["EquipoID"].Value);
                cmbCliente.SelectedValue = Convert.ToInt32(fila.Cells["ClienteID"].Value);
                txtMarca.Text = fila.Cells["Marca"].Value?.ToString();
                txtModelo.Text = fila.Cells["Modelo"].Value?.ToString();
                txtNumeroSerie.Text = fila.Cells["NumeroSerie"].Value?.ToString();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            var equipo = new Equipo
            {
                ClienteID = (int)cmbCliente.SelectedValue,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                NumeroSerie = txtNumeroSerie.Text
            };

            var exito = await _equipoService.CrearEquipoAsync(equipo);
            if (exito)
            {
                MessageBox.Show("Equipo registrado.");
                await CargarEquipos();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (equipoSeleccionadoId == 0) return;
            if (!ValidarCampos()) return;
            var equipo = new Equipo
            {
                EquipoID = equipoSeleccionadoId,
                ClienteID = (int)cmbCliente.SelectedValue,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                NumeroSerie = txtNumeroSerie.Text
            };

            var exito = await _equipoService.ActualizarEquipoAsync(equipo);
            if (exito)
            {
                MessageBox.Show("Equipo actualizado.");
                await CargarEquipos();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (equipoSeleccionadoId == 0) return;

            var confirmar = MessageBox.Show("¿Eliminar equipo?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                var exito = await _equipoService.EliminarEquipoAsync(equipoSeleccionadoId);
                if (exito)
                {
                    MessageBox.Show("Equipo eliminado.");
                    await CargarEquipos();
                }
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("La marca es obligatoria.");
                txtMarca.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("El modelo es obligatorio.");
                txtModelo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroSerie.Text))
            {
                MessageBox.Show("La descripción es obligatoria.");
                txtNumeroSerie.Focus();
                return false;
            }

            if (cmbCliente.SelectedIndex < 0 || cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                cmbCliente.Focus();
                return false;
            }

            return true;
        }

    }
}
