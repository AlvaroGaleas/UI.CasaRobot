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
    public partial class HistorialForm : Form
    {
        private readonly HistorialServicioService _historialService = new HistorialServicioService();
        private readonly OrdenServicioService _ordenService = new OrdenServicioService();
        private readonly EmpleadoService _empleadoService = new EmpleadoService();

        private int historialSeleccionadoId = 0;
        private List<OrdenServicio> ordenes = new List<OrdenServicio>();
        private List<Empleado> empleados = new List<Empleado>();
        public HistorialForm()
        {
            InitializeComponent();
        }

        private async void HistorialForm_Load(object sender, EventArgs e)
        {
            await CargarOrdenes();
            await CargarEmpleados();
            await CargarHistorial();
        }
        private async Task CargarOrdenes()
        {
            ordenes = await _ordenService.ObtenerOrdenesAsync();
            cmbOrden.DataSource = ordenes;
            cmbOrden.DisplayMember = "DescripcionProblema";  // o "OrdenID"
            cmbOrden.ValueMember = "OrdenID";
        }

        private async Task CargarEmpleados()
        {
            empleados = await _empleadoService.ObtenerEmpleadosAsync();
            cmbEmpleado.DataSource = empleados;
            cmbEmpleado.DisplayMember = "Nombre";
            cmbEmpleado.ValueMember = "EmpleadoID";
        }

        private async Task CargarHistorial()
        {
            var historial = await _historialService.ObtenerHistorialAsync();
            dgvHistorial.DataSource = historial;
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvHistorial.Rows[e.RowIndex];
                historialSeleccionadoId = Convert.ToInt32(fila.Cells["HistorialID"].Value);
                cmbOrden.SelectedValue = Convert.ToInt32(fila.Cells["OrdenID"].Value);
                cmbEmpleado.SelectedValue = Convert.ToInt32(fila.Cells["EmpleadoID"].Value);
                txtDescripcionTrabajo.Text = fila.Cells["DescripcionTrabajo"].Value?.ToString();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var nuevo = new HistorialServicio
            {
                OrdenID = (int)cmbOrden.SelectedValue,
                EmpleadoID = (int)cmbEmpleado.SelectedValue,
                DescripcionTrabajo = txtDescripcionTrabajo.Text
            };

            var exito = await _historialService.CrearHistorialAsync(nuevo);
            if (exito)
            {
                MessageBox.Show("Historial registrado.");
                await CargarHistorial();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (historialSeleccionadoId == 0) return;

            var actualizado = new HistorialServicio
            {
                HistorialID = historialSeleccionadoId,
                OrdenID = (int)cmbOrden.SelectedValue,
                EmpleadoID = (int)cmbEmpleado.SelectedValue,
                DescripcionTrabajo = txtDescripcionTrabajo.Text
            };

            var exito = await _historialService.ActualizarHistorialAsync(actualizado);
            if (exito)
            {
                MessageBox.Show("Historial actualizado.");
                await CargarHistorial();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (historialSeleccionadoId == 0) return;

            var confirmar = MessageBox.Show("¿Eliminar historial?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                var exito = await _historialService.EliminarHistorialAsync(historialSeleccionadoId);
                if (exito)
                {
                    MessageBox.Show("Historial eliminado.");
                    await CargarHistorial();
                }
            }
        }
        private bool ValidarCampos()
        {
            if (cmbOrden.SelectedIndex < 0 || cmbOrden.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una orden de servicio.");
                cmbOrden.Focus();
                return false;
            }

            
            if (string.IsNullOrWhiteSpace(txtDescripcionTrabajo.Text))
            {
                MessageBox.Show("Debe ingresar el detalle del servicio.");
                txtDescripcionTrabajo.Focus();
                return false;
            }

            if (cmbEmpleado.SelectedIndex < 0 || cmbEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un técnico.");
                cmbEmpleado.Focus();
                return false;
            }

            return true;
        }


    }
}
