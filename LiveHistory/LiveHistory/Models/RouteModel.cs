using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveHistory.Models
{
    public class RouteModel
    {
        public int Id { get; set; } 
        public int City_Id { get; set; }
        public string Route_Name { get; set; }

        public virtual List<PointModel> Points { get; set; }
    }
}