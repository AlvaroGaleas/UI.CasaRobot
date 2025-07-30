using CasaRobot.UI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaRobot.UI
{
    public partial class FrmIngresarEquipos : Form
    {
        private readonly HttpClient _httpEquipos;
        private const string BaseUrlEquipos = "http://localhost:7233/EquiposControlador/";

        public FrmIngresarEquipos()
        {
            InitializeComponent();
            _httpEquipos = new HttpClient();
            CargarClientes();

        }
        private async Task LoadEquiposAsync()
        {
            try
            {
                var response = await _httpEquipos.GetStringAsync(BaseUrlEquipos + "ListarEstadosTodos");
                var equipos = JsonSerializer.Deserialize<List<Equipos>>(response);
                dgvDatos.DataSource = equipos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmIngresarEquipos_Load(object sender, EventArgs e)
        {

        }
        private async void CargarClientes()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                var response = await client.GetAsync("http://localhost:7233/ClientesControlador/" + "GetClientes");
                if (response.IsSuccessStatusCode)
                 {
                    var clientes = await response.Content.ReadAsAsync<List<Clientes>>();
                    cmbClientes.DataSource = clientes;
                    cmbClientes.DisplayMember = "Nombre";
                    cmbClientes.ValueMember = "ClienteID";
                 }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void panelIniciar_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btGuardar_Click(object sender, EventArgs e)
        {
            var equipo = new Equipos
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                NumeroSerie = txtNumeroSerie.Text,
                ClienteID = (int?)cmbClientes.SelectedValue
                
            };

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("http://localhost:7233/EquiposControlador/", equipo);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Equipo guardado");
                    LoadEquiposAsync();
                }
            }

        }
    }
}
