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
    public class ThomasInfoController : ControllerBase
    {
        private Random rnd = new Random();
        // GET: api/<ThomasInfoController>
        [HttpGet]
        public string Get(string info)
        {
            switch (info.Trim().ToLower())
            {
                case "utbildning":
                    return Education();
                case "arbetserfarenhet":
                    return WorkExperience();
                case "övrigt":
                    return RandomInfo();
                default:
                   return "Den gubben gick inte. Här kommer en ordvits istället.";
            }
        }

        private string Education()
        {
            var infoList = new List<string>()
            {
                "Thomas har en tvåårig yh-utbildning från Nackademin.",
                "Thomas har utbildat sig till Programutvecklare inom .Net",
                "Under utbildningen har Thomas lärt sig C#, Sql, Html, Css och Javascript."
            };

            return infoList[rnd.Next(0, infoList.Count)];
        }

        private string WorkExperience()
        {
            var infoList = new List<string>()
            {
                "Thomas har jobbat som systemutvecklare hos Metamatrix sedan våren 2019.",
                "Thomas har haft 14 veckors praktik på företaget DGC våren 2018.",
                "Innan Thomas började arbeta som systemutvecklare har han jobbat 4 år som ventilationsmontör.",
                "På Metamatrix jobbat Thomas med Episerver och Umbraco, där han gör integrationer mot olika Crm och andra externa tjänster."
            };

            return infoList[rnd.Next(0, infoList.Count)];
        }

        private string RandomInfo()
        {
            var infoList = new List<string>()
            {
                "Thomas har sort matintresse och spenderar gärna fritiden åt att lära sig nya knep i köket.",
                "Thomas bästa resemål vad en resa till Island 2017.",
                "Musik är ett äldre intresse som det inte ägnas lika mycket tid åt idag, men Thomas har tidigare spelat gitarr i ett band och haft flera spelningar runt om i stockholm.",
                "Thomas KOMMER dra dåliga ordvitsar när han får chansen."
            };

            return infoList[rnd.Next(0, infoList.Count)];
        }


        // GET api/<ThomasInfoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ThomasInfoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ThomasInfoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ThomasInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
