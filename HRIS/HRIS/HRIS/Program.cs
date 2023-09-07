using HRIS.Forms.Userlogin;

<<<<<<< HEAD
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
=======
using System.Configuration;
using Microsoft.Data.SqlClient;

>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
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
<<<<<<< HEAD:HRIS/HRIS/HRIS/Program.cs
<<<<<<< HEAD
            
=======
>>>>>>> backup files
=======
            
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/Program.cs
=======
            
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
            Application.Run(new Userlogin());
        }
    }
}