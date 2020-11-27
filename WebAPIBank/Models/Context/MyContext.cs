using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBank.Models.Entities;
using WebAPIBank.Models.Init;

namespace WebAPIBank.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit()); //burada MyInit sınıfmızı tetiklemiz gerekir ki overrise ettigimiz Seed metodu burada calıssın.
        }

        public DbSet<CardInfo> Cards { get; set; }
    }
}