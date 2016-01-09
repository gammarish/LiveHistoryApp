namespace LiveHistory.Migrations
{
    using LiveHistory.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LiveHistory.Models.MainDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LiveHistory.Models.MainDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.City.AddOrUpdate(
              new CityModel { City_Name = "Czestochowa" },
              new CityModel { City_Name = "Krakow" },
              new CityModel { City_Name = "Katowice" }
            );

            context.Point.AddOrUpdate(
            new PointModel { lat = "50.8093206", lon = "19.1227711", Route_Id = 1, Id = 1 },
            new PointModel { lat = "50.812331", lon = "19.104446", Route_Id = 1, Id = 2 },
             new PointModel { lat = "50.812165", lon = "19.11076", Route_Id = 1, Id = 3 }
          );

            context.Route.AddOrUpdate(
             new RouteModel { Route_Name = "Czestochowa tour", City_Id = 1, Id = 1 }
           );

           
            
        }
    }
}
