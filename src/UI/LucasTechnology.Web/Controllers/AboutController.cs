using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LucasTechnology.Web.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public IActionResult Index()
        {
            return View();
        }

        
        
    }
}
