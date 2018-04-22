using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ResterauntReview.dl.Models;

namespace ResterauntReview.dl
{
    class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(): base("DataContext")
        {


        }

        public DbSet<Resteraunt> Resteraunts { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
