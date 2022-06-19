using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldenRing.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace EldenRing.Logic.DataAccess
{
    public class EldenRingContext : DbContext
    {
        public EldenRingContext(DbContextOptions<EldenRingContext> options) : base(options) { }
        public DbSet<Ammos> Ammos { get; set; }
        public DbSet<Armors> Armors { get; set; }
        public DbSet<AshesOfWar> AshesOfWar { get; set; }
        public DbSet<Boss> Boss { get; set; }
        public DbSet<Classes>Classes { get; set; }
        public DbSet<Creatures> Creatures { get; set; } 
        public DbSet<Incantations> Incantations { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<NPCS> NPCS { get; set; }
        public DbSet<Shields> Shields { get; set; }
        public DbSet<Sorceries> Sorceries { get; set; }
        public DbSet<Spirits>Spirits { get; set; }
        public DbSet<Talismans> Talismans { get; set; }
        public DbSet<Weapons> Weapons { get; set; }

    }
}
