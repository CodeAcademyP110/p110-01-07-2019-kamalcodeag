﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P110_CoreStart
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }
    }
}
