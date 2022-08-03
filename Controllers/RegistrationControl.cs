using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Data.Dto;

namespace UserAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class RegistrationControl : ControllerBase
    {

        [HttpPost]
        public IActionResult UserRegister(CreateUserDto createDto)
        {
            //TODO activate the service
            return Ok();
        }
    }
}
