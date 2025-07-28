using CasaRobot.UI.Clases;
using CasaRobot.UI.Controlador;
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
        private const string BaseUrlEquipos = "https://localhost:7233/api/EquiposControlador/";

        public FrmIngresarEquipos()
        {
            InitializeComponent();
            _httpEquipos = new HttpClient();
            CargarClientes();            
            LoadEquiposAsync();
        }
        private async Task LoadEquiposAsync()
        {
            try
            {
                var response = await _httpEquipos.GetStringAsync(BaseUrlEquipos + "GetEquipos");
                var equipos = JsonSerializer.Deserialize<List<Equipos>>(response);
                dgvDatos.DataSource = equipos;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                var response = await client.GetAsync("https://localhost:7233/api/ClientesControlador/" + "GetClientes");
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
                NumeroSerie = txtNumeroS.Text,
                ClienteID = (int?)cmbClientes.SelectedValue
                
            };

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://localhost:7233/api/EquiposControlador/CrearEquipo", equipo);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Equipo guardado");
                    LoadEquiposAsync();
                }
            }


        }
    }
}
