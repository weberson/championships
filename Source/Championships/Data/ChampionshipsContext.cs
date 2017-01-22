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
        public ChampionshipsContext() : base("ChampionshipsDB")
        {

        }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("VARCHAR"));

            //Map entity to table
            modelBuilder.Entity<Player>().ToTable("TbPlayer");
            modelBuilder.Entity<Player>().HasKey<int>(p => p.PlayerId);

        }
    }
}