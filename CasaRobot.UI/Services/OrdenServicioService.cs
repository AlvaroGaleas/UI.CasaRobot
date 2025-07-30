using CasaRobot.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Services
{
    public class OrdenServicioService
    {
        private readonly ApiService _apiService;

        public OrdenServicioService()
        {
            _apiService = new ApiService();
        }

        public Task<List<OrdenServicio>> ObtenerOrdenesAsync()
        {
            return _apiService.GetAsync<OrdenServicio>("api/OrdenesServicioControlador/ListarOrdenesServicio");
        }

        public Task<bool> CrearOrdenAsync(OrdenServicio orden)
        {
            return _apiService.PostAsync("api/OrdenesServicioControlador/CrearOrdenes", orden);
        }

        public Task<bool> ActualizarOrdenAsync(OrdenServicio orden)
        {
            return _apiService.PutAsync($"api/OrdenesServicioControlador/ActualizarOrdenes/{orden.OrdenID}", orden);
        }

        public Task<bool> EliminarOrdenAsync(int ordenId)
        {
            return _apiService.DeleteAsync($"api/OrdenesServicioControlador/EliminarOrden/{ordenId}");
        }
    }
}
