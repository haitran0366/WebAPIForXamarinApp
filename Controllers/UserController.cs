using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIForXamarinApp.Models;
using WebAPIForXamarinApp.Services;

namespace WebAPIForXamarinApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        //IUserService iUser = new UserService();

        // GET all action
        [HttpGet]
        public ActionResult<List<UserModel>> GetAll() => UserService.GetAll();

        [HttpGet("{username}/{password}")]
        public ActionResult<UserModel> Get(string username, string password)
        {
            var user = UserService.GetUser(username, password);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateAccount(UserModel user)
        {
            UserService.Add(user);
            return CreatedAtAction(nameof(CreateAccount), new { id = user.Id }, user);
        }

    }
}
