using CasaRobot.UI.Forms;
using CasaRobot.UI.Seguridad;
namespace CasaRobot.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Simulamos un usuario logueado
            SesionUsuario.NombreUsuario = "admin";
            SesionUsuario.Rol = "Administrador";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMenu());
        }
    }
}