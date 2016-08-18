// Author's Name : Pui In Kwok
// Student Number : 200203793
// Data Modified : 17 Aug, 2016
// Short Version History : 0.0.0.1
// File Description : This is the database connection and allow related models to 
//                    get info from database

namespace COMP2007_FinalExam.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCMusicStoreContext : DbContext
    {
        public MVCMusicStoreContext()
            : base("name=MVCMusicStoreConnection")
        {
        }

        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
