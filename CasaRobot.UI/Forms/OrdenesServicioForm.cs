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
    public partial class OrdenesServicioForm : Form
    {
        private readonly OrdenServicioService _ordenService = new OrdenServicioService();
        private readonly EquipoService _equipoService = new EquipoService();
        private readonly EstadoService _estadoService = new EstadoService(); // lo creamos luego
        private int ordenSeleccionadaId = 0;
        private List<Equipo> equipos = new List<Equipo>();
        private List<Estado> estados = new List<Estado>();
        public OrdenesServicioForm()
        {
            InitializeComponent();
        }

        private async void OrdenesServicioForm_Load(object sender, EventArgs e)
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
            await CargarEquipos();
            await CargarEstados();
            await CargarOrdenes();
        }
        private async Task CargarEquipos()
        {
            equipos = await _equipoService.ObtenerEquiposAsync();
            cmbEquipo.DataSource = equipos;
            cmbEquipo.DisplayMember = "NumeroSerie";  // o Modelo si prefieres
            cmbEquipo.ValueMember = "EquipoID";
        }

        private async Task CargarEstados()
        {
            estados = await _estadoService.ObtenerEstadosAsync();
            cmbEstado.DataSource = estados;
            cmbEstado.DisplayMember = "NombreEstado";
            cmbEstado.ValueMember = "EstadoID";
        }

        private async Task CargarOrdenes()
        {
            var ordenes = await _ordenService.ObtenerOrdenesAsync();
            dgvOrdenes.DataSource = ordenes;
        }

        private void dgvOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvOrdenes.Rows[e.RowIndex];
                ordenSeleccionadaId = Convert.ToInt32(fila.Cells["OrdenID"].Value);
                cmbEquipo.SelectedValue = Convert.ToInt32(fila.Cells["EquipoID"].Value);
                cmbEstado.SelectedValue = Convert.ToInt32(fila.Cells["EstadoID"].Value);
                txtDescripcion.Text = fila.Cells["DescripcionProblema"].Value?.ToString();
                if (fila.Cells["FechaIngreso"].Value != DBNull.Value)
                {
                    dtpFechaIngreso.Value = Convert.ToDateTime(fila.Cells["FechaIngreso"].Value);
                }
                if (fila.Cells["FechaSalida"].Value != DBNull.Value)
                {
                    dtpFechaSalida.Value = Convert.ToDateTime(fila.Cells["FechaSalida"].Value);
                }
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            var orden = new OrdenServicio
            {
                EquipoID = (int)cmbEquipo.SelectedValue,
                EstadoID = (int)cmbEstado.SelectedValue,
                DescripcionProblema = txtDescripcion.Text,
                FechaIngreso = dtpFechaIngreso.Value,
                FechaSalida = dtpFechaSalida.Value

            };

            var exito = await _ordenService.CrearOrdenAsync(orden);
            if (exito)
            {
                MessageBox.Show("Orden registrada.");
                await CargarOrdenes();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var orden = new OrdenServicio
            {
                EquipoID = (int)cmbEquipo.SelectedValue,
                EstadoID = (int)cmbEstado.SelectedValue,
                FechaIngreso = dtpFechaIngreso.Value,
                FechaSalida = dtpFechaSalida.Value,
                DescripcionProblema = txtDescripcion.Text
               
            };

            var exito = await _ordenService.CrearOrdenAsync(orden);
            if (exito)
            {
                MessageBox.Show("Orden registrada correctamente.");
                await CargarOrdenes();
                //LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar la orden.");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ordenSeleccionadaId == 0) return;

            var confirmar = MessageBox.Show("¿Eliminar orden?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                var exito = await _ordenService.EliminarOrdenAsync(ordenSeleccionadaId);
                if (exito)
                {
                    MessageBox.Show("Orden eliminada.");
                    await CargarOrdenes();
                }
            }
        }
        private bool ValidarCampos()
        {
            if (cmbEquipo.SelectedIndex < 0 || cmbEquipo.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un equipo.");
                cmbEquipo.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex < 0 || cmbEstado.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                cmbEstado.Focus();
                return false;
            }
            if (dtpFechaIngreso.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de Ingreso no puede ser superior.");
                dtpFechaIngreso.Focus();
                return false;
            }

            if (dtpFechaSalida.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de Salida no puede ser menor.");
                dtpFechaSalida.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción del problema es obligatoria.");
                txtDescripcion.Focus();
                return false;
            }

            return true;
        }

    }
}
