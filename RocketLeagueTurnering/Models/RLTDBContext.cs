using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RocketLeagueTurnering.Models
{
    public class RLTDBContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}