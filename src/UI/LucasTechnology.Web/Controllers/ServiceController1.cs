using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LucasTechnology.Web.Controllers
{
    public class ServiceController1 : Controller
    {
        // GET: ServiceController1
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
