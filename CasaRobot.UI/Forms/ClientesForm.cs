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
    public partial class ClientesForm : Form
    {
        private readonly ClienteService _clienteService = new ClienteService();
        private int clienteSeleccionadoId = 0;
        public ClientesForm()
        {
            InitializeComponent();
        }

        private async void ClientesForm_Load(object sender, EventArgs e)
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
        }
        private async Task CargarClientes()
        {
            var clientes = await _clienteService.ObtenerClientesAsync();
            dgvClientes.DataSource = clientes;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvClientes.Rows[e.RowIndex];
                clienteSeleccionadoId = Convert.ToInt32(fila.Cells["ClienteID"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            var cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            var exito = await _clienteService.CrearClienteAsync(cliente);
            if (exito)
            {
                MessageBox.Show("Cliente registrado.");
                await CargarClientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar cliente.");
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == 0)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            if (!ValidarCampos()) return;

            var cliente = new Cliente
            {
                ClienteID = clienteSeleccionadoId,
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            var exito = await _clienteService.ActualizarClienteAsync(cliente);
            if (exito)
            {
                MessageBox.Show("Cliente actualizado.");
                await CargarClientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar cliente.");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == 0)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            var confirmar = MessageBox.Show("¿Está seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                var exito = await _clienteService.EliminarClienteAsync(clienteSeleccionadoId);
                if (exito)
                {
                    MessageBox.Show("Cliente eliminado.");
                    await CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar cliente.");
                }
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                await CargarClientes();
                return;
            }

            var resultados = await _clienteService.BuscarClientesPorNombreAsync(nombre);
            dgvClientes.DataSource = resultados;
        }
        private void LimpiarCampos()
        {
            clienteSeleccionadoId = 0;
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtBuscarNombre.Text = "";
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El correo es obligatorio.");
                txtCorreo.Focus();
                return false;
            }

            // Validación de formato de correo
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo no tiene un formato válido.");
                txtCorreo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.");
                txtTelefono.Focus();
                return false;
            }

            // Validación de solo números
            if (!long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El teléfono debe contener solo números.");
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.");
                txtDireccion.Focus();
                return false;
            }

            return true;
        }

    }
}
