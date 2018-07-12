using System.Collections.Generic;
using System.Linq;
using System.Net;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Services.Service;
using Airport_REST_API.Shared.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Airport_REST_API.Controllers
{
    [Route("api/[controller]")]
    public class FlightController : Controller
    {
        private readonly IFlightService _service;
        public FlightController(IFlightService service)
        {
            _service = service;
        }
        // GET api/flight
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetData());
        }

        // GET api/flight/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetObject(id));
        }

        // POST api/flight
        [HttpPost]
        public IActionResult Post([FromBody]FlightDTO flight)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                    .Where(y => y.Count > 0)
                    .ToList();
                return BadRequest(errors);
            }
            var result = _service.AddObject(flight);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/flight/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]FlightDTO flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.UpdateObject(id,flight);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // DELETE api/flight/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.RemoveObject(id);
            return result == true ? StatusCode(200) : StatusCode(404);
        }
    }
}
