﻿using BikeShare.Models;
using System.Linq;
using System.Web.Mvc;

namespace BikeShare.Code
{
    /// <summary>
    /// Filter for inserting userName into views. This helps to enable unit testing when the action would otherwise directly depend on the roleManager.
    /// </summary>
    public sealed class UserNameFilter : ActionFilterAttribute
    {
        /// <summary>
        /// Called when executing the action. Inserts the correct userName into the arguments.
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            const string Key = "userName";

            if (filterContext.ActionParameters.ContainsKey(Key))
            {
                if (filterContext.HttpContext.User.Identity.IsAuthenticated)
                {
                    filterContext.ActionParameters[Key] = filterContext.HttpContext.User.Identity.Name;
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }

    public static class RoleCheck
    {
        public static bool IsUserAdmin(string userName)
        {
            using (var context = new BikesContext())
            {
                return context.BikeUser.Where(u => u.userName == userName).First().canAdministerSite;
            }
        }

        public static bool IsUserMechanic(string userName)
        {
            using (var context = new BikesContext())
            {
                return context.BikeUser.Where(u => u.userName == userName).First().canMaintainBikes;
            }
        }

        public static bool IsUserCashier(string userName)
        {
            using (var context = new BikesContext())
            {
                return context.BikeUser.Where(u => u.userName == userName).First().canCheckOutBikes;
            }
        }
    }
}