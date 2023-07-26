using HRIS.Forms.Userlogin;

<<<<<<< HEAD:HRIS/HRIS/HRIS/Program.cs
<<<<<<< HEAD
using System.Configuration;
using Microsoft.Data.SqlClient;

=======
>>>>>>> backup files
=======
using System.Configuration;
using Microsoft.Data.SqlClient;

>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/Program.cs
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
<<<<<<< HEAD:HRIS/HRIS/HRIS/Program.cs
<<<<<<< HEAD
            
=======
>>>>>>> backup files
=======
            
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/Program.cs
            Application.Run(new Userlogin());
        }
    }
}