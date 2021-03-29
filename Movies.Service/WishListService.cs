using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
    public class WishListService: IWishListService
    {
        private readonly IWishListRepository _wishListRepository;

        public WishListService(IWishListRepository wishListRepository)
        {
            _wishListRepository = wishListRepository;
        }
    }
}
