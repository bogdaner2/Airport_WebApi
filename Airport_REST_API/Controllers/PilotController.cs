using System.Collections;
using System.Linq;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Airport_REST_API.Controllers
{
    [Route("api/[controller]")]
    public class PilotController : Controller
    {
        private readonly IPilotService _service;
        public PilotController(IPilotService service)
        {
            _service = service;
        }
        // GET api/Pilot
        [HttpGet]
        public IEnumerable GetAll()
        {
            return _service.GetData();
        }

        // GET api/Pilot/:id
        [HttpGet("{id:int}")]
        public Pilot Get(int id)
        {
            return _service.GetObject(id);
        }

        // POSt api/Pilot
        [HttpPost]
        public IActionResult Post([FromBody]PilotDTO Pilot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.AddObject(Pilot);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/Pilot
        [HttpPut("{id:int}")]
        public IActionResult Put(int id,[FromBody]PilotDTO Pilot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.UpdateObject(id,Pilot);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/Pilot
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _service.RemoveObject(id);
            return result == true ? StatusCode(200) : StatusCode(404);
        }
    }
}