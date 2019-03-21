using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TunesAPI
{

    public class TunesContext : DbContext
    {
        public TunesContext(DbContextOptions<TunesContext> options)
            : base(options)
        { }

        public DbSet<Tunes> Tunes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Tunes>().HasData(
                new Tunes { Id = 1, IrishChart = 1, Title = "Thriller", Artist = "Michael Jackson", Album = "Thriller", Genre = "Pop", Duration = "5.58", Realsed = new DateTime(1982, 11, 30), Price = 9.16, BuyLink = "https://www.amazon.com/Thriller-Michael-Jackson/dp/B00VSHH9GC/ref=tmm_acd_swatch_0?_encoding=UTF8&qid=1552692547&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/55/Michael_Jackson_-_Thriller.png/220px-Michael_Jackson_-_Thriller.png" },

            );
        }

    }


    public enum Genre
    {
        Pop, Rock, Blues, Folk, Dance, HipHop, Metal, Jazz, Country, Disco 
    }
    public class Tunes
    {
        //ID autogenerates
        public int Id { get; set; }
        public int IrishChart { get; set; }
        public int GlobalChart { get; set; }
        public String Title { get; set; }
        public String Artist { get; set; }
        public String Album { get; set; }
        //public Genre Genre { get; set; }
        public String Genre{ get; set; }
        public String AlbumCoverLink { get; set; }
        public double Price { get; set; }
        public String BuyLink { get; set; }
        public DateTime Realsed { get; set; }
        public String Duration { get; set; }
    }

}
