using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
    public class WritterService: IWritterService
    {
        private readonly IWritterRepository _writterRepository;

        public WritterService(IWritterRepository writterRepository)
        {
            _writterRepository = writterRepository;
        }
    }
}
