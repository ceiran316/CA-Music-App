using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TunesAPI
{
    public class Tunes
    {
        //ID autogenerates
        public int Id { get; set; }
        public String Artist { get; set; }
        public String Song { get; set; }
        public String Album { get; set; }
        public String Genre { get; set; }
    }
}
