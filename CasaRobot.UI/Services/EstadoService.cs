using CasaRobot.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Services
{
    public class EstadoService
    {
        private readonly ApiService _apiService;

        public EstadoService()
        {
            _apiService = new ApiService();
        }

        public Task<List<Estado>> ObtenerEstadosAsync()
        {
            return _apiService.GetAsync<Estado>("api/EstadosControlador/ListarEstados");
        }

        public Task<bool> CrearEstadoAsync(Estado estado)
        {
            return _apiService.PostAsync("api/EstadosControlador/CrearEstado", estado);
        }

        public Task<bool> ActualizarEstadoAsync(Estado estado)
        {
            return _apiService.PutAsync($"api/EstadosControlador/ActualizarEstado/{estado.EstadoID}", estado);
        }

        public Task<bool> EliminarEstadoAsync(int estadoId)
        {
            return _apiService.DeleteAsync($"api/EstadosControlador/EliminarEstado/{estadoId}");
        }
    }
}
