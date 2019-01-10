using System.Collections.Generic;
using System.Web.Http;
using Rapento;
using RapentoWebAPI.Models;

namespace RapentoWebAPI.Controllers
{
    public class IndividualsController : ApiController
    {

        // GET: api/Individuals
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value3" };
        }

        [HttpPost]
        public void AddIndividual([FromBody]Individual input)
        {
            DataAccess data = new DataAccess();
            data.AddIndividual(input);
        }

        // PUT: api/Individuals/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Individuals/5
        public void Delete(int id)
        {
        }
    }
}
