using CasaRobot.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Services
{
    public class CostoService
    {
        private readonly ApiService _apiService;

        public CostoService()
        {
            _apiService = new ApiService();
        }

        public Task<List<Costo>> ObtenerCostosAsync()
        {
            return _apiService.GetAsync<Costo>("api/CostosControlador/ListarCostos");
        }

        public Task<bool> CrearCostoAsync(Costo costo)
        {
            return _apiService.PostAsync("api/CostosControlador/CrearCosto", costo);
        }

        public Task<bool> ActualizarCostoAsync(Costo costo)
        {
            return _apiService.PutAsync($"api/CostosControlador/ActualizarCosto/{costo.CostoID}", costo);
        }

        public Task<bool> EliminarCostoAsync(int costoId)
        {
            return _apiService.DeleteAsync($"api/CostosControlador/EliminarCosto/{costoId}");
        }
    }
}
