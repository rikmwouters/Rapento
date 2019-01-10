using Rapento;
using RapentoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RapentoWebAPI.Controllers
{
    public class TaxonsController : ApiController
    {
        // GET: api/Taxons
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Taxons/{id}
        public string Get(string id)
        {
            return id;
        }

        // POST: api/Taxons
        [HttpPost]
        public string FindTaxonID([FromBody]FindTaxonIDInput input)
        {
            DataAccess data = new DataAccess();
            int result = data.FindTaxonID(input.GivenTaxonName);

            return result.ToString();
        }

        // PUT: api/Taxons/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Taxons/5
        public void Delete(int id)
        {
        }
    }
}
