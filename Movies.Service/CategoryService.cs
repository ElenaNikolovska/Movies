using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
   public  class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

    }
}
