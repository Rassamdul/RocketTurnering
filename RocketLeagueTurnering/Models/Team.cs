using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RocketLeagueTurnering.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Medlem1 { get; set; }
        public string Medlem2 { get; set; }
        public string Medlem3 { get; set; }
    }
}