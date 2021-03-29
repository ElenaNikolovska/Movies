using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
    public class SeriesService : ISeriesService
    {
        private readonly ISeriesRepository _seriesRepository;

        public SeriesService(ISeriesRepository seriesRepository)
        {
            _seriesRepository = seriesRepository;
        }
    }
}
