using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
    public class ProductionCompanyService: IProductionCompanyService
    {
        private readonly IProductionCompanyRepository _productionCompanyRepository;

        public ProductionCompanyService(IProductionCompanyRepository productionCompanyRepository)
        {
            _productionCompanyRepository = productionCompanyRepository;
        }
    }
}
