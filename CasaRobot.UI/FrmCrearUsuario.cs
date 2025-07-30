using CasaRobot.UI.Clases;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaRobot.UI
{
    public partial class FrmCrearUsuario : Form
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost:7233/ClientesControlador/";
        public FrmCrearUsuario()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            LoadClientesAsync();
        }

        private async  void btGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes
            {
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("http://localhost:7233/ClientesControlador/CrearCliente/", cliente);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente guardado exitosamente");
                    LoadClientesAsync();
                }
            }
        }
        private async Task LoadClientesAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(BaseUrl + "ListarClientes");
                var clientes = JsonSerializer.Deserialize<List<Clientes>>(response);
                dgvDatos.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
