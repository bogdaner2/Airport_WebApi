using System.Collections.Generic;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Airport_REST_API.Controllers
{
    [Route("api/[controller]")]
    public class AircraftTypeController : Controller
    {
        private readonly IAircraftTypeService _service;
        public AircraftTypeController(IAircraftTypeService service)
        {
            _service = service;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetData());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetObject(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]AircraftTypeDTO type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.AddObject(type);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/aircrafttype/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]AircraftTypeDTO type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.AddObject(type);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // DELETE api/aircrafttype/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.RemoveObject(id);
            return result == true ? StatusCode(200) : StatusCode(404);
        }
    }
}
