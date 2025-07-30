using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Models
{
    public class MetodoPago
    {
        public int PagoID { get; set; }
        public int? OrdenID { get; set; }
        public string Metodo { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }

        // Opcional
        public string DescripcionOrden { get; set; }
    }
}
