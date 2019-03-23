using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace TunesAPI.Controllers
{


    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TunesController : ControllerBase
    {
        private readonly TunesContext _context;

        public TunesController(TunesContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet("all")]
        public IEnumerable<Tunes> GetAll()
        { 
            //return bangers.OrderBy(c => c.IrishChart).Select(d => d.Title);
            return _context.Tunes.OrderBy(t => t.IrishChart);
        }

        //GET Tunes by name
        [HttpGet("title/{title}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetSongByName(string title)
        {
            var song =  _context.Tunes.Where(c => c.Title.ToLower() == title)
                .Select(g => new {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre
                });

            if (song == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(song);
            }
        }
        
        //Get Tunes by chart position
        [HttpGet("position/{pos}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetSongByPos(int pos)
        {
            var song = _context.Tunes.Where(c => c.IrishChart == pos)
                .Select(g => new {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre
                });
            if (song == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(song);
            }
        }

        //Get Tunes by artist
        [HttpGet("artist/{artist}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetSongByArtist(string artist)
        {
            var song = _context.Tunes.Where(c => c.Artist.ToLower() == artist)
                .OrderBy(c => c.IrishChart)
                .Select(g => new {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre
                });
            if (song == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(song);
            }
        }

        //Get Tunes by album
        [HttpGet("album/{album}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetSongByAlbum(string album)
        {
            var song = _context.Tunes.Where(c => c.Album.ToLower() == album)
                .OrderBy(c => c.IrishChart)
                .Select(g => new {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre
                });
            if (song == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(song);
            }
        }

        //Get Tunes by genre
        [HttpGet("genre/{genre}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async Task<ActionResult<Tunes>> GetGenreSongsAsync(string genre)
        {
            if (genre == null)
            {
                return NotFound();
            }
            var type = await _context.Tunes
                .Where(g => g.Genre.ToLower() == genre)
                .OrderBy(g => g.IrishChart)
                .Select(g => new {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre})
                .ToListAsync();
            if (type == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(type);
            }
        }

        //Get top 5 Tunes by genre
        [HttpGet("top5/{genre}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async Task<ActionResult<Tunes>> GetGenreTopFiveAsync(string genre)
        {
            if (genre == null)
            {
                return NotFound();
            }
            var type = await _context.Tunes
                .Where(g => g.Genre.ToLower() == genre)
                .OrderBy(g => g.IrishChart)
                .Select(g => new {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre
                }).Take(5)
                .ToListAsync();
            if (type == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(type);
            }
        }

        //Get latest Tunes
        [HttpGet("latest")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetLatestSongs()
        {
            var type = _context.Tunes
                .OrderByDescending(c => c.Realsed)
                .Select(g => new
                {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre,
                    g.Realsed
                }).Take(5)
                .ToList();
            if (type == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(type);
            }
        }

        //Get Oldest Tunes 
        [HttpGet("oldest")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetOldestSongs()
        {
            var type = _context.Tunes
                .OrderBy(c => c.Realsed)
                .Select(g => new
                {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre,
                    g.Realsed
                }).Take(5)
                .ToList();
            if (type == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(type);
            }
        }

        //Get cheapest Tunes 
        [HttpGet("cheapest")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetCheapestSongs()
        {
            var type = _context.Tunes
                .OrderBy(c => c.Price)
                .Select(g => new
                {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre,
                    g.Price
                }).Take(5)
                .ToList();
            if (type == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(type);
            }
        }

        //Get cheapest Tunes 
        [HttpGet("dearest")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetDearestSongs()
        {
            var type = _context.Tunes
                .OrderByDescending(c => c.Price)
                .Select(g => new
                {
                    g.IrishChart,
                    g.Title,
                    g.Artist,
                    g.Genre,
                    g.Price
                }).Take(5)
                .ToList();
            if (type == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(type);
            }
        }

        //Get priceSum Tunes 
        [HttpGet("priceSum")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetGenrePriceSum()
        {
            var type = _context.Tunes
                .GroupBy(x => x.Genre,
             (key, values) => new {
                 Genre = key,
                 Total = values.Sum(x => x.Price)
             }).OrderByDescending(x => x.Total)
                .ToList();
            if (type == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(type);
            }
        }

        //Get priceSum Tunes 
        [HttpGet("popular")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Tunes> GetMostPopularArtist()
        {
            var type = _context.Tunes
                 .GroupBy(c => c.Artist)
                 .Select(g => new
                 {
                     count = g.Count(),g.First().Artist
                 }).OrderByDescending(g => g.count)
                 .Take(5)
                 .ToList();
            if (type == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(type);
            }
        }

        // GET api/values


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
