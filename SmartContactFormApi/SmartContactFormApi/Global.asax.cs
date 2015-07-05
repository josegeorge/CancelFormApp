using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using log4net;

namespace SmartContactFormApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {

        private static readonly ILog Logger;

        static WebApiApplication()
        {
            Logger = LogManager.GetLogger(typeof(WebApiApplication));
        }


        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Logger.Info("SmartContactFormApi Started...");


        }
    }
}
