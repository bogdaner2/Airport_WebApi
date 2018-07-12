using System.Collections.Generic;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Airport_REST_API.Controllers
{
    [Route("api/[controller]")]
    public class DepartureController : Controller
    {
        private readonly IDepartureService _service;
        public DepartureController(IDepartureService service)
        {
            _service = service;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Departures> Get()
        {
            return _service.GetData();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
