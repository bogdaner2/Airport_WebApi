using System.Collections.Generic;
using System.Net.Http.Headers;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Airport_REST_API.Controllers
{
    [Route("api/[controller]")]
    public class AircraftController : Controller
    {
        private readonly IAircraftService _service;
        public AircraftController(IAircraftService service)
        {
            _service = service;
        }
        // GET api/aircraft
        [HttpGet]
        public IEnumerable<Aircraft> Get()
        {
            return _service.GetData();
        }

        // GET api/aircraft/5
        [HttpGet("{id}")]
        public Aircraft Get(int id)
        {
            return _service.GetObject(id);
        }

        //  POST api/aircraft/5
        [HttpPost]
        public IActionResult Post([FromBody]AircraftDTO aircraft)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = _service.AddObject(aircraft);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/aircraft/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]AircraftDTO aircraft)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = _service.UpdateObject(id,aircraft);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // DELETE api/aircraft/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.RemoveObject(id);
            return result == true ? StatusCode(200) : StatusCode(404);
        }
    }
}
