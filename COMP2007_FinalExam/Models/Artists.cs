namespace COMP2007_FinalExam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Artists
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }
    }
}
