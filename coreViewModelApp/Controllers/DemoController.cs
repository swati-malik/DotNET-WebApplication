using coreViewModelApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreViewModelApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Details()
        {
            DataRepository dataRepository = new DataRepository();
            return View(dataRepository.DataSource());
        }
    }
}
