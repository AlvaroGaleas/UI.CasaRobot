using CasaRobot.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Services
{
    public class MetodoPagoService
    {
        private readonly ApiService _apiService;

        public MetodoPagoService()
        {
            _apiService = new ApiService();
        }

        public Task<List<MetodoPago>> ObtenerPagosAsync()
        {
            return _apiService.GetAsync<MetodoPago>("api/MetodosPagoControlador/ListarMetodos");
        }

        public Task<bool> CrearPagoAsync(MetodoPago pago)
        {
            return _apiService.PostAsync("api/MetodosPagoControlador/CrearMetodoPago", pago);
        }

        public Task<bool> ActualizarPagoAsync(MetodoPago pago)
        {
            return _apiService.PutAsync($"api/MetodosPagoControlador/ActualizarMetodo/{pago.PagoID}", pago);
        }

        public Task<bool> EliminarPagoAsync(int pagoId)
        {
            return _apiService.DeleteAsync($"api/MetodosPagoControlador/EliminarMetodoPago/{pagoId}");
        }
    }
}
