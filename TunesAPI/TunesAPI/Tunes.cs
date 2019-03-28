using System;

namespace TunesAPI
{    
    public class Tunes
    {
        //ID autogenerates
        public int Id { get; set; }
        public int IrishChart { get; set; }
        public String Title { get; set; }
        public String Artist { get; set; }
        public String Album { get; set; }
        public String Genre{ get; set; }
        public String AlbumCoverLink { get; set; }
        public double Price { get; set; }
        public String BuyLink { get; set; }
        public DateTime Realsed { get; set; }
        public String Duration { get; set; }
    }
}
