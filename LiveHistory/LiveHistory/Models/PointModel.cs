using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveHistory.Models
{
    public class PointModel
    {
        public int Id { get; set; }
        public int Route_Id { get; set; }
        public string lon { get; set; }
        public string lat { get; set; }
      
    }
}