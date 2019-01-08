using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Rapento;

namespace RapentoWebAPI.Controllers
{
    public class IndividualsController : ApiController
    {

        // GET: api/Individuals
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Individuals/5
        public HttpResponseMessage Get(string taxonname)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DataAccess data = new DataAccess();
                    return new HttpResponseMessage()
                    {
                        Content = new StringContent(
                        data.FindTaxonID(taxonname).ToString(),
                        Encoding.UTF8,
                        "text/html"
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

        // POST: api/Individuals
        public IHttpActionResult Post([FromBody]string genus, [FromBody]string species, [FromBody]string collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DataAccess data = new DataAccess();
                    data.AddIndividual(genus, species, collection);

                    return Ok("Successfully added.");
                }
                else
                {
                    return BadRequest("Something went wrong.");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message.ToString());
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
