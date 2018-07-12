using System.Collections.Generic;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
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
        // GET api/departure
        [HttpGet]
        public IEnumerable<Departures> Get()
        {
            return _service.GetData();
        }

        // GET api/departure/5
        [HttpGet("{id}")]
        public Departures Get(int id)
        {
            return _service.GetObject(id);
        }

        // POST api/departure
        [HttpPost]
        public IActionResult Post([FromBody]DeparturesDTO departure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.AddObject(departure);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/departure/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]DeparturesDTO departure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.UpdateObject(id, departure);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // DELETE api/departure/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.RemoveObject(id);
            return result == true ? StatusCode(200) : StatusCode(404);
        }
    }
}
