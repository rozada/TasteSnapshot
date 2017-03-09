using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TasteSnapshot.Models;

namespace TasteSnapshot.DAL
{
    public class TSContext : DbContext
    {
        public TSContext() : base("name=TSConnectionString")
        {

        }

        public DbSet<Yummy> Yummies { get; set; }
        public DbSet<CustomProperty> CustomProperties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
       
    }
}