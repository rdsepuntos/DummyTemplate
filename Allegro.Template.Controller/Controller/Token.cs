using Allegro.Framework.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Allegro.Template.Controller.Controller
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class Token : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            var token = new JwtTokenBuilder(TokenType.Password, 
                                           JwtSecretKey.Create("allegrosecretkey"),
                                           "Allegro Authentication", 
                                           "Allegro.Authentication", 
                                           "Allegro.Authentication")

                              .AddClaims<Payload>(new Payload
                              {
                                  UserId = 1,
                                  UserName = "rdsepuntos",
                                  Email = "rdsepuntos@allegro.com.ph",
                                  FullName = "Ronald Sepuntos",
                              })
                              .AddScope(new List<string> { "urn:allegro:tasks:getany", "urn:allegro:tasks:getany" })
                              .Build();

            return token.Value;
        }
    }

    public class Payload
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
