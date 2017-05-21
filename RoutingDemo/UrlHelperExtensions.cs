using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RoutingDemo.Controllers;

namespace RoutingDemo
{
    public static class UrlHelperExtensions
    {
        public static string HomeAction(this UrlHelper urlHelper)
        {
            return urlHelper.Action(nameof(HomeController.Index), HomeController.Route);
        }

        public static string HomeAboutAction(this UrlHelper urlHelper)
        {
            return urlHelper.Action(nameof(HomeController.About), HomeController.Route);
        }

        public static string HomeContactAction(this UrlHelper urlHelper, string contactName)
        {
            return urlHelper.Action(nameof(HomeController.Contact), HomeController.Route, new ContactQuery()
            {
                ContactName = contactName
            });
        }
    }
}
