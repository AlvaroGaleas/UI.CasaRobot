using CasaRobot.UI.Models;
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
    public partial class EmpleadosForm : Form
    {
        private readonly EmpleadoService _empleadoService = new EmpleadoService();
        private int empleadoSeleccionadoId = 0;
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private async void EmpleadosForm_Load(object sender, EventArgs e)
        {
            await CargarEmpleados();
        }
        private async Task CargarEmpleados()
        {
            var empleados = await _empleadoService.ObtenerEmpleadosAsync();
            dgvEmpleados.DataSource = empleados;
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvEmpleados.Rows[e.RowIndex];
                empleadoSeleccionadoId = Convert.ToInt32(fila.Cells["EmpleadoID"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtCargo.Text = fila.Cells["Cargo"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado
            {
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text,
                Telefono = txtTelefono.Text
            };

            var exito = await _empleadoService.CrearEmpleadoAsync(empleado);
            if (exito)
            {
                MessageBox.Show("Empleado registrado.");
                await CargarEmpleados();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionadoId == 0) return;

            var empleado = new Empleado
            {
                EmpleadoID = empleadoSeleccionadoId,
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text,
                Telefono = txtTelefono.Text
            };

            var exito = await _empleadoService.ActualizarEmpleadoAsync(empleado);
            if (exito)
            {
                MessageBox.Show("Empleado actualizado.");
                await CargarEmpleados();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionadoId == 0) return;

            var confirmar = MessageBox.Show("¿Eliminar empleado?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                var exito = await _empleadoService.EliminarEmpleadoAsync(empleadoSeleccionadoId);
                if (exito)
                {
                    MessageBox.Show("Empleado eliminado.");
                    await CargarEmpleados();
                }
            }
        }
    }
}
