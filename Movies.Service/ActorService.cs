using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
    public class ActorService :IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService (IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
    }
}
