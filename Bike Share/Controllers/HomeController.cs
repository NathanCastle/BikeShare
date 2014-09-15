﻿using System.Web.Mvc;

namespace BikeShare.Controllers
{
    /// <summary>
    /// Handles display of all of the mostly static home and info areas.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Displays a generic homepage.
        /// </summary>
        /// <returns>View with no ViewModel.</returns>
        public ActionResult Index()
        {
            return View("Index");
        }

        /// <summary>
        /// Displays a page with information about the app.
        /// </summary>
        /// <returns>View with no ViewModel.</returns>
        public ActionResult About()
        {
            return View("About");
        }
        public ActionResult Safety()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }

        /// <summary>
        /// Displays a page with license information.
        /// </summary>
        /// <returns>View with no ViewModel.</returns>
        public ActionResult License()
        {
            return View();
        }

        /// <summary>
        /// Displays page with information about registering for the service.
        /// </summary>
        /// <returns>View with no ViewModel.</returns>
        public ActionResult Register()
        {
            return View();
        }
    }
}