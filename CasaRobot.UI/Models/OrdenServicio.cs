using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Models
{
    public class OrdenServicio
    {
        public int OrdenID { get; set; }
        public int? EquipoID { get; set; }
        public int? EstadoID { get; set; }
        public string DescripcionProblema { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }

        // Opcionales (si los trae tu API para mostrar)
        public string NombreEstado { get; set; }
        public string NombreCliente { get; set; }
        public string NumeroSerieEquipo { get; set; }
    }
}
