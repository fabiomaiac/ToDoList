using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDo.Domain.Dto.User;
using ToDo.Domain.Interfaces.Service;
using ToDo.Domain.Models;

namespace ToDo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        
        [HttpGet("{Id}")]
        public async Task<ActionResult<UserEntity>> GetById(int Id)
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
        public async Task<ActionResult<UserEntity>> Insert (UserInsertDto user)
        {
            try
            {
                return Ok(await _service.Insert(user));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("GetEmail/{Email}")]
        public async Task<ActionResult<UserEntity>> GetByEmail (string Email)
        {
            try
            {
                return Ok(await _service.GetByEmail(Email));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}