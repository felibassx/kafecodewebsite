using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using models;

namespace gui
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //se ejecutara el inicializador cuando la aplicacion corra por primera vez
            Database.SetInitializer<KafeCodeContext>(new Initializer());
        }
    }
}
