using Championships.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Championships.Data
{
    public class ChampionshipsContext : DbContext
    {
        public ChampionshipsContext() : base()
        {

        }

        public DbSet<Player> Players { get; set; }
    }
}