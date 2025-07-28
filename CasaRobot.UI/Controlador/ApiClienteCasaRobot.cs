using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Controlador
{
    public class ApiClienteCasaRobot
    {
        private readonly HttpClient _httpClient; //Conecto a mi api
        private readonly string _baseUrl; //Direccion del api

        public ApiClienteCasaRobot(string baseUrl)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            _httpClient = new HttpClient();
        }
        public async Task<T> GetTAsync<T>(string endPoint)//Metodo generico para listar datos
        {
            var respuesta = await _httpClient.GetAsync($"{_baseUrl}/{endPoint}");//Leer datos
            respuesta.EnsureSuccessStatusCode();

            var contenido = await respuesta.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(contenido);
        }
        public async Task<HttpResponseMessage> CrearEntidadAsync<T>(string endPoint, T entidad)
        {
            var json = JsonConvert.SerializeObject(entidad);
            var contenido = new StringContent(json, Encoding.UTF8, "application/json");

            var respuesta = await _httpClient.PostAsync($"{_baseUrl}/{endPoint}", contenido);
            return respuesta;
        }
    }
}
