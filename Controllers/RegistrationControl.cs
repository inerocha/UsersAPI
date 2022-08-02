using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersAPI.Data.Dto;

namespace UsersAPI.Controllers
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
