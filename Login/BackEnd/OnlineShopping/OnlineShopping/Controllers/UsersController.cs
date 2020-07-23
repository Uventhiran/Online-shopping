using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Common.Interfaces;
using OnlineShopping.Common.Models;

namespace OnlineShopping.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserBusiness _userBusiness;

        public UsersController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        /// <summary>
        /// This method is used to authenticate user and will return user details with JWT token. 
        /// </summary>
        /// <param name="model">This parameter will receive username of user and password of user</param>
        /// <returns></returns>

        //[Route("authenticate")]
        [AllowAnonymous]
        //[HttpPost]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateRequestModel model)
        {
            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
            {
                return BadRequest();
            }
            else
            {
                try
                {
                    var response = _userBusiness.Authenticate(model);
                    if (response == null)
                        return BadRequest(new { message = "Username or password is incorrect" });

                    return Ok(response);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }
            }




            //var response = _userBusiness.Authenticate(model);

            //if (response == null)
            //    return BadRequest(new { message = "Username or password is incorrect" });

            //return Ok(response);
        }
    }
}

