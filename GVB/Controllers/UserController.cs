﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GVB.Controllers
{
    public class UserController : Controller
    {
        // This controller is to control all views seen by everyday users - only views included should be (1) selecting feedlot and
        // (2) selecting the dairy (dropdown) and typing in the cow # assigned from the dairy to move the cow from the cattle table 
        // to the deceased database

        public ActionResult ChooseFeedlot()
        {
            return View();
        }
    }
}