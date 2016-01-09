using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveHistory.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string City_Name { get; set; }

        public virtual List<RouteModel> Routes { get; set; }
    }
}