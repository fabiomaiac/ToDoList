using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDo.Domain.Dto.ToDo;
using ToDo.Domain.Interfaces.Service;
using ToDo.Domain.Models;

namespace ToDo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _service;
        public ToDoController(IToDoService service)
        {
            _service = service;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ToDoResponseDto>> GetById(int Id)
        {
            try
            {
                return Ok(await _service.GetById(Id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public string Insert (ToDoInsertDto user)
        {
            try
            {
                return  _service.Insert(user);
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        [HttpGet("GetAllUserId/{Id}")]
        public async Task<ActionResult<List<ToDoResponseDto>>> GetAllUserId (int Id)
        {
            try
            {
                return Ok(await _service.GetAllUserId(Id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete("{Id}")]
        public string Delete (int Id)
        {
            try
            {
                return _service.Delete(Id);
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }
    }   
}