﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class RentalController : Controller
    {
        [Authorize(Roles = RoleNames.canManageMovies)]
        public ActionResult New()
        {
            return View();
        }
    }
}