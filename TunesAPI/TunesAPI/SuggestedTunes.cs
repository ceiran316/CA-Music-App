using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TunesAPI
{
    public class SuggestedTunes
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public String Title { get; set; }
        public String Artist { get; set; }
        public String Genre { get; set; }
    }
}
