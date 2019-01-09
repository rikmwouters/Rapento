using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;
using Rapento;

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

        // POST: api/Individuals/5
        [HttpPost]
        public HttpResponseMessage Post([FromBody]TaxonName taxonname)
        {
            //string taxonname = JsonConvert.DeserializeObject<dynamic>(input).taxonname;

            try
            {
                if (ModelState.IsValid)
                {
                    DataAccess data = new DataAccess();
                    return new HttpResponseMessage()
                    {
                        Content = new StringContent(
                        data.FindTaxonID(taxonname.GivenTaxonName).ToString(),
                        Encoding.UTF8,
                        "application/json"
                        )
                    };
                }
                else
                {
                    HttpResponseMessage response =
                        this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Something went wrong.");
                    throw new HttpResponseException(response);
                }
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
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
