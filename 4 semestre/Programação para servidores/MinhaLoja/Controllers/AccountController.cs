﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaLoja.Data;
using MinhaLoja.Models;
using MinhaLoja.Services;
using MinhaLoja.ViewModel;

namespace MinhaLoja.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {

        [HttpPost("account/login")]
        public IActionResult Login(
            [FromBody] UserLoginViewModel model,
            [FromServices] AppDbContext context,
            [FromServices] TokenService tokenService)
        {
            var user = context.Users.FirstOrDefault(x => x.Email == model.Email);

            if (user == null)
                return StatusCode(401, new { message = "Usuário ou senha inválidos" });

            if (Settings.GenerateHash(model.Password) != user.Password)
                return StatusCode(401, new { message = "Usuário ou senha inválidos" });

            try
            {
                var token = tokenService.CreateToken(user);
                return Ok(new { token = token });
            }
            catch
            {
                return StatusCode(500, new { message = "Falha interna no servidor" });
            }
        }


        [HttpPost("account/signup")]
        public IActionResult Signup(
            [FromBody] UserSignupViewModel model,
            [FromServices] AppDbContext context)
        {
            var user = context.Users.FirstOrDefault(x => x.Email == model.Email);

            if (user != null)
                return StatusCode(401, new { message = "E-mail já cadastrado" });

            try
            {
                var userNew = new User
                {
                    Name = model.Name,
                    Email = model.Email,
                    Password = Settings.GenerateHash(model.Password),
                    Role = "Admin"
                };

                context.Users.Add(userNew);
                context.SaveChanges();

                return Ok(new { userId = userNew.Id });
            }
            catch
            {
                return StatusCode(500, new { message = "Falha interna no servidor" });
            }
        }


        [Authorize(Roles = "Admin")]
        [HttpGet("account/user")]
        public IActionResult Get(
            [FromServices] AppDbContext context)
        {
            try
            {
                var users = context.Users.ToList().Select(x => new UserReturnViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Email = x.Email,
                    Role = x.Role,
                    Password = x.Password
                });

                return Ok(users);
            }
            catch
            {
                return StatusCode(500, new { message = "Falha interna no servidor" });
            }
        }


    }
}