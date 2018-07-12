﻿using System.Collections;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Airport_REST_API.Controllers
{
    [Route("api/[controller]")]
    public class StewardessController : Controller
    {
        private readonly IStewardessService _service;
        public StewardessController(IStewardessService service)
        {
            _service = service;
        }
        // GET api/Stewardess
        [HttpGet]
        public IEnumerable GetAll()
        {
            return _service.GetData();
        }

        // GET api/Stewardess/:id
        [HttpGet("{id:int}")]
        public object Get(int id)
        {
            return _service.GetObject(id);
        }

        // POSt api/Stewardess
        [HttpPost]
        public IActionResult Post([FromBody]StewardessDTO Stewardess)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.AddObject(Stewardess);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/Stewardess
        [HttpPut("{id:int}")]
        public IActionResult Put(int id,[FromBody]StewardessDTO Stewardess)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.UpdateObject(id,Stewardess);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/Stewardess
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _service.RemoveObject(id);
            return result == true ? StatusCode(200) : StatusCode(404);
        }
    }
}