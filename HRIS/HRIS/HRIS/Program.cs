using HRIS.Forms.Userlogin;

<<<<<<< HEAD
using System.Configuration;
using Microsoft.Data.SqlClient;

=======
>>>>>>> backup files
namespace HRIS
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
<<<<<<< HEAD
            
=======
>>>>>>> backup files
            Application.Run(new Userlogin());
        }
    }
}