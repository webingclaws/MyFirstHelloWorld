using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("service/register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        [Route("submit")]
        [HttpPost]
        public async Task<string> Register([FromBody] Dictionary<string, string> payload)
        {
           //TODO: save to database
            return await Task.Run(()=> JsonSerializer.Serialize(payload));
        }

    }
}
