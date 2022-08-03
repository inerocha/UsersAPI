using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Data.Dto; 
using UserAPI.Services;

namespace UserAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class RegistrationControl : ControllerBase
    {
        private CreateRecord _createRecord; 

        public RegistrationControl(CreateRecord createRecord)
        {
            _createRecord = createRecord;
        }

        [HttpPost]
        public IActionResult UserRegister(CreateUserDto createDto)
        {
            Result result = _createRecord.UserRegister(createDto);
            if (result.IsFailed) return StatusCode(500);
            return Ok();
        }
    }
}
