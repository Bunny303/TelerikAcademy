using Places.Repositories;
using PlacesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Places.Services.Controllers
{
    public class VotesController : ApiController
    {
        private IRepository<Vote> voteRepository;

        public VotesController(IRepository<Vote> repository)
        {
            this.voteRepository = repository;
        }
    }
}
