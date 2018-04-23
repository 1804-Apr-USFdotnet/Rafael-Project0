using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ResterauntReview.dl.Models;

namespace ResterauntReview.dl
{
   public  class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(): base("DataContext")
        {


        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void ExecuteCommand(string command, params object[] parameters)
        {
            base.Database.ExecuteSqlCommand(command, parameters);
        }

        public DbSet<Resteraunt> Resteraunts { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
