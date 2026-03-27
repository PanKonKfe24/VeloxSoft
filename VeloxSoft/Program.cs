using VeloxSoft.Formularios;

namespace VeloxSoft
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

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