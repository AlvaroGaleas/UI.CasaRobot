using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using CasaRobot.UI.Models;

namespace CasaRobot.UI.Services
{
    public class ClienteService
    {
        private readonly ApiService _apiService;

        public ClienteService()
        {
            _apiService = new ApiService();
        }

        public Task<List<Cliente>> ObtenerClientesAsync()
        {
            return _apiService.GetAsync<Cliente>($"api/ClientesControlador/GetClientes");
        }

        public Task<Cliente> ObtenerClientePorIdAsync(int id)
        {
            return _apiService.GetByIdAsync<Cliente>($"api/ClientesControlador/BuscarCliente/{id}");
        }

        public Task<List<Cliente>> BuscarClientesPorNombreAsync(string nombre)
        {
            return _apiService.GetAsync<Cliente>($"api/ClientesControlador/ListarClientesNombre/{nombre}");
        }

        public Task<bool> CrearClienteAsync(Cliente cliente)
        {
            return _apiService.PostAsync("api/ClientesControlador/CrearCliente", cliente);
        }

        public Task<bool> ActualizarClienteAsync(Cliente cliente)
        {
            return _apiService.PutAsync($"api/ClientesControlador/ActualizarCliente/{cliente.ClienteID}", cliente);
        }

        public Task<bool> EliminarClienteAsync(int clienteId)
        {
            return _apiService.DeleteAsync($"api/ClientesControlador/EliminarCliente/{clienteId}");
        }
    }
}
