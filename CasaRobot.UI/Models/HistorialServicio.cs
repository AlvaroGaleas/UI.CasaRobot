using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Models
{
    public class HistorialServicio
    {
        public int HistorialID { get; set; }
        public int OrdenID { get; set; }
        public int EmpleadoID { get; set; }
        public string DescripcionTrabajo { get; set; }

        // Opcionales si los retorna la API
        public string NombreEmpleado { get; set; }
        public string DescripcionOrden { get; set; }
    }
}
