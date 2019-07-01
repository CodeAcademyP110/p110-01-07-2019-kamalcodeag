using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "Index";
            return view;
        }
    }
}
