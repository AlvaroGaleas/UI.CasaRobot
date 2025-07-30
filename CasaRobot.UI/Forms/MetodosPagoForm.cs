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
    public partial class MetodosPagoForm : Form
    {
        private readonly MetodoPagoService _pagoService = new MetodoPagoService();
        private readonly OrdenServicioService _ordenService = new OrdenServicioService();
        private int pagoSeleccionadoId = 0;
        private List<OrdenServicio> ordenes = new List<OrdenServicio>();
        public MetodosPagoForm()
        {
            InitializeComponent();
        }

        private async void MetodosPagoForm_Load(object sender, EventArgs e)
        {
            await CargarOrdenes();
            await CargarPagos();
        }
        private async Task CargarOrdenes()
        {
            ordenes = await _ordenService.ObtenerOrdenesAsync();
            cmbOrden.DataSource = ordenes;
            cmbOrden.DisplayMember = "DescripcionProblema";  // o "OrdenID"
            cmbOrden.ValueMember = "OrdenID";
        }

        private async Task CargarPagos()
        {
            var pagos = await _pagoService.ObtenerPagosAsync();
            dgvPagos.DataSource = pagos;
        }

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvPagos.Rows[e.RowIndex];
                pagoSeleccionadoId = Convert.ToInt32(fila.Cells["PagoID"].Value);
                cmbOrden.SelectedValue = Convert.ToInt32(fila.Cells["OrdenID"].Value);
                txtMetodo.Text = fila.Cells["Metodo"].Value?.ToString();
                txtMonto.Text = fila.Cells["Monto"].Value?.ToString();

                if (fila.Cells["FechaPago"].Value != DBNull.Value)
                {
                    dtpFechaPago.Value = Convert.ToDateTime(fila.Cells["FechaPago"].Value);
                }
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var pago = new MetodoPago
            {
                OrdenID = (int)cmbOrden.SelectedValue,
                Metodo = txtMetodo.Text,
                FechaPago = dtpFechaPago.Value,
                Monto = decimal.Parse(txtMonto.Text)
            };

            var exito = await _pagoService.CrearPagoAsync(pago);
            if (exito)
            {
                MessageBox.Show("Pago registrado.");
                await CargarPagos();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (pagoSeleccionadoId == 0) return;

            var pago = new MetodoPago
            {
                PagoID = pagoSeleccionadoId,
                OrdenID = (int)cmbOrden.SelectedValue,
                Metodo = txtMetodo.Text,
                FechaPago = dtpFechaPago.Value,
                Monto = decimal.Parse(txtMonto.Text)
            };

            var exito = await _pagoService.ActualizarPagoAsync(pago);
            if (exito)
            {
                MessageBox.Show("Pago actualizado.");
                await CargarPagos();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pagoSeleccionadoId == 0) return;

            var confirmar = MessageBox.Show("¿Eliminar pago?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                var exito = await _pagoService.EliminarPagoAsync(pagoSeleccionadoId);
                if (exito)
                {
                    MessageBox.Show("Pago eliminado.");
                    await CargarPagos();
                }
            }
        }
    }
}
