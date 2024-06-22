using System.Security.Cryptography.X509Certificates;

namespace SalesManagement
{
    public static class Globals
    {
        public static bool admin = false;
        public static string idUtilizador { get; set; }
        public static string nomeUtilizador { get; set; }
    }

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
            Application.Run(new FormLogin());
        }
    }
}