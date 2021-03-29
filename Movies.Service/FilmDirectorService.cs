using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
    public class FilmDirectorService: IFilmDirectorService
    {
        private readonly IFilmDirectorRepository _filmdirectorRepository;

        public FilmDirectorService(IFilmDirectorRepository filmDirectorRepository)
        {
            _filmdirectorRepository = filmDirectorRepository;
        }
    }
}
