using AspNetCoreApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspNetCoreApp.DataContext
{
    public class TeamAppDb : DbContext
    {
        public TeamAppDb(DbContextOptions<TeamAppDb> options) : base(options)
        {
        }

        public DbSet<Tara> Tari { get; set; }

        public DbSet<Locatie> Locatii { get; set; }

        public DbSet<Antrenor> Antrenori { get; set; }

        public DbSet<Jucator> Jucatori { get; set; }

        public DbSet<Echipa> Echipe {  get; set; }
    }
}