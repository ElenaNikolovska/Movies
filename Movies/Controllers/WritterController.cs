using Microsoft.AspNetCore.Mvc;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class WritterController : Controller
    {

        private readonly IWritterService _writterService;

        public WritterController(IWritterService writterService)
        {
            _writterService = writterService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
