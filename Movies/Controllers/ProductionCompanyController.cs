using Microsoft.AspNetCore.Mvc;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class ProductionCompanyController : Controller
    {

        private readonly IProductionCompanyService _productionCompanyService;

        public ProductionCompanyController(IProductionCompanyService productionCompanyService)
        {
            _productionCompanyService = productionCompanyService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
