namespace MvcMovie.Migrations.MovieDbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\MovieDbContext";
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            
             context.Movies.AddOrUpdate(
                  new Models.Movie { Title="MadMax", Genre="Action, Thriller", Price=10,ReleaseDate=new DateTime(2015,5,15)},
                  new Models.Movie { Title = "In a Valley  of  Violence", Genre = "Western", Price = 20, ReleaseDate = new DateTime(2016, 10, 15) },
                  new Models.Movie { Title = "10.000 km", Genre = "Romance", Price = 10, ReleaseDate = new DateTime(2016, 9, 15) }
                );
            context.SaveChanges();

        }
    }
}
