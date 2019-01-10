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

        // POST: api/Individuals/{id}
        [HttpPost]
        public string IndividualPost(string id, [FromBody]IndividualInput input)
        {
            DataAccess data = new DataAccess();
            int result = data.FindTaxonID(input.GivenTaxonName);
            return id + ". Het nummer van dit taxon is: " + result.ToString();
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
