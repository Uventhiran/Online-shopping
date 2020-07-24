using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Common.Entities;
using OnlineShopping.Common.Interfaces;
using OnlineShopping.Common.Models;

namespace OnlineShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private IRegistrationBusiness _registrationBusiness;

        public RegistrationController(IRegistrationBusiness registrationBusiness)
        {
            _registrationBusiness = registrationBusiness;
        }

        //[Route("authenticate")]
        [AllowAnonymous]
        //[HttpPost]
        [HttpPost("registrate")]
        public async Task<IActionResult> Registrate([FromBody]UserModel model)
        {
            var user = await _registrationBusiness.Registrate(new User
            {
                Title = model.Title,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Username = model.Username,
                Email = model.Email,
                Password = model.Password
            }).ConfigureAwait(false);

            return Ok(user);
        }
    }
}