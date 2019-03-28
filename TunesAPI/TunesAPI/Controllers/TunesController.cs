using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            return _context.Tunes.OrderBy(t => t.IrishChart);
        }

        [HttpGet("top10")]
        public IEnumerable<Tunes> GetTopTen()
        {
            return _context.Tunes.OrderBy(t => t.IrishChart).Take(10);
        }

        [HttpGet("top5")]
        public IEnumerable<Tunes> GetTop5()
        {
            return _context.Tunes.OrderBy(t => t.IrishChart).Take(5);
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

        //Get popular Tunes 
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

        // GET all suggested tunes
        [HttpGet("allSuggested")]
        public IEnumerable<SuggestedTunes> GetAllSuggested()
        {
            return _context.SuggestedTunes.OrderByDescending(t => t.Count);
        }

        [HttpPost]
        [ProducesResponseType(201)]             // created
        [ProducesResponseType(400)]             // bad request
        public IActionResult PostSuggestion([FromBody] string titleIn, string artistIn, string genreIn)
        {
            var record = _context.SuggestedTunes.SingleOrDefault(d => d.Title == titleIn);
            string connectionString = null;
            string sql = null;
            connectionString = "Server=tcp:tunesserver.database.windows.net,1433;Initial Catalog=tunesdb;Persist Security Info=False;User ID=antoneville;Password=JellyTots0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            if (record == null)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    sql = "SET IDENTITY_INSERT SuggestedTunes ON insert into SuggestedTunes ([Id],[Count],[Title],[Artist],[Genre]) values(@id,@count,@title,@artist,@genre)";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", 98);
                        cmd.Parameters.AddWithValue("@count", 1);
                        cmd.Parameters.AddWithValue("@title", titleIn);
                        cmd.Parameters.AddWithValue("@artist", artistIn);
                        cmd.Parameters.AddWithValue("@genre", genreIn);
                        cmd.ExecuteNonQuery();
                        return Ok(record);
                    }
                }
            }
            else
            {
                PutSuggestion(titleIn);
                return Ok();
            }
        }

        [HttpPut]
        [ProducesResponseType(201)]             // created
        [ProducesResponseType(400)]             // bad request
        public IActionResult PutSuggestion([FromBody] string titleIn)
        {
            var record = _context.SuggestedTunes.SingleOrDefault(d => d.Title == titleIn);
            string connectionString = null;
            string sql = null;
            connectionString = "Server=tcp:tunesserver.database.windows.net,1433;Initial Catalog=tunesdb;Persist Security Info=False;User ID=antoneville;Password=JellyTots0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            if (record != null)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    sql = "UPDATE SuggestedTunes SET Count = @count WHERE Title = @title";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@count", record.Count + 1);
                        cmd.Parameters.AddWithValue("@title", titleIn);
                        cmd.ExecuteNonQuery();
                        return Ok(record);
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("allNewHardSuggested")]
        public IEnumerable<SuggestedTunes> GetNewAllSuggested()
        {
            PostSuggestion("Thats the Way(I Like It)", "KC & The Sunshine Band", "Disco");
            return _context.SuggestedTunes.OrderByDescending(t => t.Count);
        }

        [HttpGet("allNewParamSuggested")]
        public IEnumerable<SuggestedTunes> GetNewAllSuggested(string titleIn, string artistIn, string genreIn)
        {
            PostSuggestion(titleIn, artistIn, genreIn);
            return _context.SuggestedTunes.OrderByDescending(t => t.Count);
        }

        //deleteing list entry from id input
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(200)]             // ok
        [ProducesResponseType(404)]             // not found
        public IActionResult DeleteEntry([FromRoute] int id)
        {
            var record = _context.SuggestedTunes.SingleOrDefault(d => d.Id == id);
            string connectionString = null;
            string sql = null;
            connectionString = "Server=tcp:tunesserver.database.windows.net,1433;Initial Catalog=tunesdb;Persist Security Info=False;User ID=antoneville;Password=JellyTots0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            if (record != null)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    sql = "DELETE FROM SuggestedTunes WHERE Id = @id";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        return Ok(record);
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
