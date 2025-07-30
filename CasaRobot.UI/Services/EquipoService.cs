using CasaRobot.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Services
{
    public class EquipoService
    {
        private readonly ApiService _apiService;

    public EquipoService()
    {
        _apiService = new ApiService();
    }

    public Task<List<Equipo>> ObtenerEquiposAsync()
    {
        return _apiService.GetAsync<Equipo>("api/EquiposControlador/GetEquipos");
    }

    public Task<bool> CrearEquipoAsync(Equipo equipo)
    {
        return _apiService.PostAsync("api/EquiposControlador/CrearEquipo", equipo);
    }

    public Task<bool> ActualizarEquipoAsync(Equipo equipo)
    {
        return _apiService.PutAsync($"api/EquiposControlador/UpdateEquipo/{equipo.EquipoID}", equipo);
    }

    public Task<bool> EliminarEquipoAsync(int equipoId)
    {
        return _apiService.DeleteAsync($"api/EquiposControlador/EliminarEquipo/{equipoId}");
    }
}
}
