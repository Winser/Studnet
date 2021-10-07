using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Studnet.Context;
using Studnet.Models;

namespace Studnet.Controllers
{
    [ApiController]
    [Route("/universities")]
    public class UniversityController
    {
        private readonly StudnetContext _dbContext;

        public UniversityController(StudnetContext dbContext)
        {
            this._dbContext = dbContext;
        }
        [HttpGet]
        [Route("/universities/list/")]
        public IEnumerable<University> List()
        {
            return this._dbContext.Universities.ToArray();
        }
    }
}