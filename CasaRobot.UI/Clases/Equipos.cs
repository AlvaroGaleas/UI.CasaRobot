using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Clases
{
    public partial class Equipos
    {
        public int EquipoID { get; set; }

        public int? ClienteID { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string NumeroSerie { get; set; }

        public virtual Clientes Cliente { get; set; }

        //public virtual ICollection<OrdenesServicio> OrdenesServicio { get; set; } = new List<OrdenesServicio>();
    }
}
