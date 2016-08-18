namespace COMP2007_FinalExam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Genres
    {
        public Genres()
        {
            
        }
  
        public Genres(string Name)
        {
            this.Name = Name;
        }

        public virtual int GenreId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual List<Albums> Albums { get; set; }
    }
}
