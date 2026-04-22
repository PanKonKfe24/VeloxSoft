using VeloxSoft.Formularios;
using Microsoft.Extensions.Configuration;
using VeloxSoft.Config;
using VeloxSoft.Services;
using VeloxSoft.Models;

namespace VeloxSoft
{
    internal static class Program
    {

        public static IConfiguration config { get; private set; }
        public static Usuario UsuarioLogueado { get; set; }
        public static Roles RolActual { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            // Creamos las instancias necesarias para los servicios.
            var dbConfig = new DatabaseConfig(config);
            var AutenticarUsuario = new AutenticarUsuario(dbConfig);

            // Creamos el formulario de Login
            FormLogIn login = new FormLogIn(AutenticarUsuario);

            // Si el Login se cierra con un resultado "OK", iniciamos el menú
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMainMenu());
            }
        }
    }
}