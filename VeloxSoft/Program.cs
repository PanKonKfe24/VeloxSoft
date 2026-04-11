using VeloxSoft.Formularios;
using Microsoft.Extensions.Configuration;
using VeloxSoft.Config;

namespace VeloxSoft
{
    internal static class Program
    {

        public static IConfiguration config { get; private set; }

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

            var dbConfig = new DatabaseConfig(config);

            // Creamos el formulario de Login
            FormLogIn login = new FormLogIn();

            // Si el Login se cierra con un resultado "OK", iniciamos el menú
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMainMenu());
            }
        }
    }
}