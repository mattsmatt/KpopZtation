using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace KpopZtation.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute("", "Home", "~/View/HomePage.aspx");
            routes.MapPageRoute("", "Register", "~/View/RegisterPage.aspx");
            routes.MapPageRoute("", "", "~/View/LoginPage.aspx");
            routes.MapPageRoute("", "Login", "~/View/LoginPage.aspx");
            routes.MapPageRoute("", "{*url}", "~/View/NotFound404.aspx");
        }
    }
}