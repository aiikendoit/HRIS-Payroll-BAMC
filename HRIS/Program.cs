using HRIS.Forms.Userlogin;

using System.Configuration;
using Microsoft.Data.SqlClient;
using Syncfusion.Licensing;

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
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cVWhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEZjUX5dcHBXQmBfVkRxXA==");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            
            //Application.Run(new Userlogin());
            
        }
    }
}