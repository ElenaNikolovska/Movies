using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMovieRepository _movieRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository,
           IMovieRepository movieRepository )
        {
            _shoppingCartRepository = shoppingCartRepository;
            _movieRepository = movieRepository;
        }
    }
}
