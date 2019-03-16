using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TunesAPI
{
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
        public Genre Genre { get; set; }
        public String AlbumCoverLink { get; set; }
        public double Price { get; set; }
        public String BuyLink { get; set; }
        public DateTime Realsed { get; set; }
        public String Duration { get; set; }
    }
}
