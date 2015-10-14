using System.Collections.Generic;

namespace MvCMovieShop.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }
         
        public Artist  Artist{ get; set; }

        public int ReviewID { get; set; }

        public virtual List<Review> Review { get; set; }
    }
}