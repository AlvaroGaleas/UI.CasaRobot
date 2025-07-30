using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Seguridad
{
    public static class SesionUsuario
    {
        public static string NombreUsuario { get; set; }
        public static string Rol { get; set; }

        public static bool EstaAutenticado => !string.IsNullOrEmpty(NombreUsuario);
    }
}
