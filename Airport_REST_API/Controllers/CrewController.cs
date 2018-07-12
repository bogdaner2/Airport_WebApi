using System.Collections;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Airport_REST_API.Controllers
{
    [Route("api/[controller]")]
    public class CrewController : Controller
    {
        private ICrewService _service;
        public CrewController(ICrewService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable GetAll()
        {
            return _service.GetData();
        }

        // GET api/Crew/:id
        [HttpGet("{id:int}")]
        public Crew Get(int id)
        {
            return _service.GetObject(id);
        }

        // POSt api/Crew
        [HttpPost]
        public IActionResult Post([FromBody]CrewDTO Crew)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.AddObject(Crew);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/Crew
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody]CrewDTO Crew)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.UpdateObject(id, Crew);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/Crew
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
             var result = _service.RemoveObject(id);
             return result == true ? StatusCode(200) : StatusCode(404);
        }
    }
}