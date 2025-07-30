using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Models
{
    public class Costo
    {
        public int CostoID { get; set; }
        public int OrdenID { get; set; }
        public string DetalleCosto { get; set; }
        public decimal Monto { get; set; }

        // Opcional, si tu API lo retorna
        public string DescripcionOrden { get; set; }
    }
}
