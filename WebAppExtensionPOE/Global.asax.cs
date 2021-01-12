using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebAppExtensionPOE
{
    public class Global : HttpApplication
    {
        static string strt = HttpRuntime.AppDomainAppPath;
        public static string conn = Path.GetFullPath(Path.Combine(strt, @"..\..\"));
        public static string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + conn + @"weatherForecastAppPOE\weatherForecastAppPOE\DatabaseWFD.mdf;Integrated Security = True";

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}