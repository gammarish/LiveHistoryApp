using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LiveHistory.Models
{
    public class MainDBContext : DbContext
    {
        public MainDBContext()
            : base("name=RoutesDataEntities")
        {

        }
        public DbSet<CityModel> City { get; set; }
        public DbSet<PointModel> Point { get; set; }
        public DbSet<RouteModel> Route { get; set; }

    }
}