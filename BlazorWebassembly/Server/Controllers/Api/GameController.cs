using DB_Connection.Models.GameModels;
using DB_Connection.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorWebassembly.Server.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        GameService gameService;
        public GameController(GameService gm)
        {
            gameService = gm;
        }
        // GET: api/<GameController>
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            var highScoreList = gameService.GetHighScore();
            return highScoreList;
        }

        // GET api/<GameController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GameController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT api/<GameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GameController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
