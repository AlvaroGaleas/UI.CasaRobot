using CasaRobot.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Services
{
    public class HistorialServicioService
    {
        private readonly ApiService _apiService;

        public HistorialServicioService()
        {
            _apiService = new ApiService();
        }

        public Task<List<HistorialServicio>> ObtenerHistorialAsync()
        {
            return _apiService.GetAsync<HistorialServicio>("api/HistorialServiciosControlador/ListarHistorial");
        }

        public Task<bool> CrearHistorialAsync(HistorialServicio historial)
        {
            return _apiService.PostAsync("api/HistorialServiciosControlador/CrearHistorial", historial);
        }

        public Task<bool> ActualizarHistorialAsync(HistorialServicio historial)
        {
            return _apiService.PutAsync($"api/HistorialServiciosControlador/ActualizarHistorial/{historial.HistorialID}", historial);
        }

        public Task<bool> EliminarHistorialAsync(int historialId)
        {
            return _apiService.DeleteAsync($"api/HistorialServiciosControlador/EliminarHistorial/{historialId}");
        }
    }
}
