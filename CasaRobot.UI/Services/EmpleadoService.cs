using CasaRobot.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Services
{
    public class EmpleadoService
    {
        private readonly ApiService _apiService;

        public EmpleadoService()
        {
            _apiService = new ApiService();
        }

        public Task<List<Empleado>> ObtenerEmpleadosAsync()
        {
            return _apiService.GetAsync<Empleado>("api/EmpleadosControlador/ListarEmpleados");
        }

        public Task<bool> CrearEmpleadoAsync(Empleado empleado)
        {
            return _apiService.PostAsync("api/EmpleadosControlador/CrearEmpleado", empleado);
        }

        public Task<bool> ActualizarEmpleadoAsync(Empleado empleado)
        {
            return _apiService.PutAsync($"api/EmpleadosControlador/ActualizarEmpleado/{empleado.EmpleadoID}", empleado);
        }

        public Task<bool> EliminarEmpleadoAsync(int empleadoId)
        {
            return _apiService.DeleteAsync($"api/EmpleadosControlador/EliminarEmpleado/{empleadoId}");
        }
    }
}
