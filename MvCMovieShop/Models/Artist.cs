using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvCMovieShop.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public int Name{ get; set; }

        public List<Album> Albums { get; set; }

    }
}