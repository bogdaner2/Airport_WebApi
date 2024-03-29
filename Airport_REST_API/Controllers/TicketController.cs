﻿using System.Collections;
using System.Linq;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Airport_REST_API.Controllers
{
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        private readonly ITicketService _service;
        public TicketController(ITicketService service)
        {
            _service = service;
        }
        // GET api/ticket
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetData());
        }

        // GET api/ticket/:id
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetObject(id));
        }

        // POSt api/ticket
        [HttpPost]
        public IActionResult Post([FromBody]TicketDTO ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.AddObject(ticket);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/ticket
        [HttpPut("{id:int}")]
        public IActionResult Put(int id,[FromBody]TicketDTO ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.UpdateObject(id,ticket);
            return result == true ? StatusCode(200) : StatusCode(404);
        }

        // PUT api/ticket
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _service.RemoveObject(id);
            return result == true ? StatusCode(200) : StatusCode(404);
        }
    }
}