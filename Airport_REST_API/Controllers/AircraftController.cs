using System.Collections.Generic;
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
        private readonly IMapper _mapper;
        public AircraftController(IAircraftService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Aircraft> Get()
        {
            return _service.GetData();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Aircraft Get(int id)
        {
            return _service.GetObject(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]AircraftDTO aircraft)
        {
            var type = aircraft.TypeId;
            var result = _service.AddObject(_mapper.Map<Aircraft>(aircraft),type);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]AircraftDTO aircraft)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
