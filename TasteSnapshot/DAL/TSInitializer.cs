using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TasteSnapshot.Models;

namespace TasteSnapshot.DAL
{
    public class TSInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TSContext>
    {
        protected override void Seed(TSContext context)
        {
            var yummies = new List<Yummy>
            {
                new Yummy { Name = "URL1", Description = "Very Yummy" },
                new Yummy { Name = "URL2", Description = "Too yummy" }
            };

            yummies.ForEach(u => context.Yummies.Add(u));
            context.SaveChanges();

            var customProperties = new List<CustomProperty>
            {
                new CustomProperty { Name = "quid", Description = @"I don't know", YummyID = 1},
                new CustomProperty { Name = "yummy", Description = "Yummy", YummyID = 1},
                new CustomProperty { Name = "Prop3", Description = "Furniture", YummyID = 2 },
                new CustomProperty { Name = "Prop4", Description = "New, used, and refurbished computers and parts", YummyID = 2 }
            };
            
            customProperties.ForEach(i => context.CustomProperties.Add(i));
            context.SaveChanges();
        }
    }
}