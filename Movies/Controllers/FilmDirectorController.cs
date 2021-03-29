using Microsoft.AspNetCore.Mvc;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class FilmDirectorController : Controller
    {


        private readonly IFilmDirectorService _filmDirectorService;

        public FilmDirectorController(IFilmDirectorService filmDirectorService)
        {
            _filmDirectorService = filmDirectorService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
