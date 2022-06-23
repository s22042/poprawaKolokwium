using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poprawa.Services;
using poprawa.Models;
using poprawa.Models.DTO;
namespace poprawa.Controllers
{   [ApiController]
    [Route("api")]
    public class TeamController : ControllerBase
    {
        readonly IDbService _service;

        public TeamController(IDbService dbService)
        {
            _service = dbService;
        
        
        }


        [HttpGet]
        [Route("{idteam}")]
        public async Task<IActionResult> GetTeam(string idteam)
        {

            var result = await _service.GetTeams(idteam);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> PostUser([FromBody]Member member,[FromBody]Team team)
        {
            if (!await _service.CheckIfInOrganization(member,team ))
                return NotFound("Nie nalezy do organizacji");
            await _service.AddUser(member, team);
            return Ok();
        }
    }
}
