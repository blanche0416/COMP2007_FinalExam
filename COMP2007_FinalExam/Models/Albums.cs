// Author's Name : Pui In Kwok
// Student Number : 200203793
// Data Modified : 17 Aug, 2016
// Short Version History : 0.0.0.1
// File Description : 

namespace COMP2007_FinalExam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Albums
    {
        public Albums()
        {

        }
        public Albums(string Title)
        {
            this.Title = Title;
        }

        public virtual int AlbumId { get; set; }

        public virtual int GenreId { get; set; }

        public virtual int ArtistId { get; set; }

        public virtual string Title { get; set; }

        public virtual decimal Price { get; set; }

        public virtual string AlbumArtUrl { get; set; }

        public virtual Artists Artists { get; set; }

        public virtual Genres Genres { get; set; }
    }
}
