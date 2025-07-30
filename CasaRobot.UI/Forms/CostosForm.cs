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
    public partial class CostosForm : Form
    {
        private readonly CostoService _costoService = new CostoService();
        private readonly OrdenServicioService _ordenService = new OrdenServicioService();
        private int costoSeleccionadoId = 0;
        private List<OrdenServicio> ordenes = new List<OrdenServicio>();
        public CostosForm()
        {
            InitializeComponent();
        }

        private async void CostosForm_Load(object sender, EventArgs e)
        {
            await CargarOrdenes();
            await CargarCostos();
        }
        private async Task CargarOrdenes()
        {
            ordenes = await _ordenService.ObtenerOrdenesAsync();
            cmbOrden.DataSource = ordenes;
            cmbOrden.DisplayMember = "DescripcionProblema";  // puedes mostrar también "OrdenID"
            cmbOrden.ValueMember = "OrdenID";
        }
        private async Task CargarCostos()
        {
            var costos = await _costoService.ObtenerCostosAsync();
            dgvCostos.DataSource = costos;
        }

        private void dgvCostos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvCostos.Rows[e.RowIndex];
                costoSeleccionadoId = Convert.ToInt32(fila.Cells["CostoID"].Value);
                cmbOrden.SelectedValue = Convert.ToInt32(fila.Cells["OrdenID"].Value);
                txtDetalleCosto.Text = fila.Cells["DetalleCosto"].Value?.ToString();
                txtMonto.Text = fila.Cells["Monto"].Value?.ToString();
            }
        }
        private void LimpiarCampos()
        {
            txtDetalleCosto.Clear();
            txtMonto.Clear();

            if (cmbOrden.Items.Count > 0)
                cmbOrden.SelectedIndex = -1;

            costoSeleccionadoId = 0; // Reinicia el ID seleccionado
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var costo = new Costo
            {
                OrdenID = (int)cmbOrden.SelectedValue,
                DetalleCosto = txtDetalleCosto.Text,
                Monto = decimal.Parse(txtMonto.Text)
            };

            var exito = await _costoService.CrearCostoAsync(costo);
            if (exito)
            {
                MessageBox.Show("Costo registrado correctamente.");
                await CargarCostos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar el costo.");
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (costoSeleccionadoId == 0)
            {
                MessageBox.Show("Seleccione un costo de la lista.");
                return;
            }

            if (!ValidarCampos()) return;

            var costo = new Costo
            {
                CostoID = costoSeleccionadoId,
                OrdenID = (int)cmbOrden.SelectedValue,
                DetalleCosto = txtDetalleCosto.Text,
                Monto = decimal.Parse(txtMonto.Text)
            };

            var exito = await _costoService.ActualizarCostoAsync(costo);
            if (exito)
            {
                MessageBox.Show("Costo actualizado correctamente.");
                await CargarCostos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el costo.");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {

            if (costoSeleccionadoId == 0) return;

            var confirmar = MessageBox.Show("¿Eliminar costo?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                var exito = await _costoService.EliminarCostoAsync(costoSeleccionadoId);
                if (exito)
                {
                    MessageBox.Show("Costo eliminado.");
                    await CargarCostos();
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

            if (string.IsNullOrWhiteSpace(txtDetalleCosto.Text))
            {
                MessageBox.Show("La descripción del costo es obligatoria.");
                txtDetalleCosto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("El monto es obligatorio.");
                txtMonto.Focus();
                return false;
            }

            if (!decimal.TryParse(txtMonto.Text, out var monto) || monto < 0)
            {
                MessageBox.Show("El monto debe ser un número válido y positivo.");
                txtMonto.Focus();
                return false;
            }

            return true;
        }

        private void GrupoBoxFormC_Enter(object sender, EventArgs e)
        {

        }
    }
}
