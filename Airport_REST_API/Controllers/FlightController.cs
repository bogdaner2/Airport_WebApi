using System.Collections.Generic;
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
        public IEnumerable<Flight> Get()
        {
            return _service.GetData();
        }

        // GET api/flight/5
        [HttpGet("{id}")]
        public Flight Get(int id)
        {
            return _service.GetObject(id);
        }

        // POST api/flight
        [HttpPost]
        public IActionResult Post([FromBody]FlightDTO flight)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState); ;
            //var result = _service.
            return null;
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
