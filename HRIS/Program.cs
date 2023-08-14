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
            SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVEZrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRcQlViTX5Wdk1jUHtacXc=;Mgo+DSMBPh8sVXJ1S0R+XVFPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXZSckVmWXdeeXBQQWM=;ORg4AjUWIQA/Gnt2VFhiQlBEfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5bd0FjXH9WcH1RQWJf;MjY0MDg3OUAzMjMxMmUzMDJlMzBFc1dhSmhFTy91dVpEY3UxQ0s4THZycmpaQnpPcVRuSWw1S0VDSWZjQnV3PQ==;MjY0MDg4MEAzMjMxMmUzMDJlMzBDbUZLajkwajNUZnFJSjRvSXVmcXo4TXY0SHdxNmIwS08rL1BadzMxZStjPQ==;NRAiBiAaIQQuGjN/V0d+Xk9FdlRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TfkRnWXpeeHRcQ2ZbUg==;MjY0MDg4MkAzMjMxMmUzMDJlMzBrZjMxTUgvd3hUTkc5Zng0cEtFZEE0QVBpcGVYTGR2VlZuYjB5aHNuV29zPQ==;MjY0MDg4M0AzMjMxMmUzMDJlMzBnUTB2NzhGZlg1TmJkVkVVQmJQQTBqcW9WZXd5YmxBbG5JcUMzWmc3TVNNPQ==;Mgo+DSMBMAY9C3t2VFhiQlBEfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5bd0FjXH9WcH1TQ2Rf;MjY0MDg4NUAzMjMxMmUzMDJlMzBrL3RHZ21RZHU1bkJCQittZDNqRDBWVE9mU3I4N0J6c2x3NDhWeTB5b3VrPQ==;MjY0MDg4NkAzMjMxMmUzMDJlMzBsRjc0MVJIdVQ0REpBSTUxekhyRTd3ZUFvT1g1d3ZBMWF2UUZiZ3E4RTJVPQ==;MjY0MDg4N0AzMjMxMmUzMDJlMzBrZjMxTUgvd3hUTkc5Zng0cEtFZEE0QVBpcGVYTGR2VlZuYjB5aHNuV29zPQ==");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Application.Run(new Userlogin());

        }
    }
}