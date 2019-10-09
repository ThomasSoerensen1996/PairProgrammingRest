using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLib;

namespace PairProgrammingRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase



    {
        private static List<Music> musicList = new List<Music>()
        {
            new Music("Hit me Baby one more time","Britney Spears", 3.20, 1998, 1),
            new Music("Not Afraid","MogM", 5.40, 2008,2),
            new Music("En sang","Emil Stabil", 3.50, 2018,3),

        };


        // GET: api/Musics
        [HttpGet]
        public IEnumerable<Music> Get()
        {
            return musicList;
        }

        // GET: api/Musics/5
        [HttpGet("{id}", Name = "Get")]
        public Music Get(int id)
        {
            return musicList.Find(c => c.Id == id);
        }

        // POST: api/Musics
        [HttpPost]
        public void Post([FromBody] Music value)
        {
            value.Id = Get().Count() + 1;
            musicList.Add(value);

        }

        // PUT: api/Musics/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Music value)
        {
           Music musicID = Get(id);

           if (musicID != null)
           {
               musicID.Id = value.Id;
               musicID.Titel = value.Titel;
               musicID.Artist = value.Artist;
               musicID.Duration = value.Duration;
               musicID.Year = value.Year;
           }
           


        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Music musicID = Get(id);
            musicList.Remove(musicID);
        }
    }
}
