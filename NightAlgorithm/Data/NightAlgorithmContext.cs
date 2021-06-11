using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NightAlgorithm.Models;

namespace NightAlgorithm.Data
{
    public class NightAlgorithmContext : DbContext
    {
        public NightAlgorithmContext (DbContextOptions<NightAlgorithmContext> options)
            : base(options)
        {
        }

        public DbSet<NightAlgorithm.Models.Događaj> Događaj { get; set; }

        public DbSet<NightAlgorithm.Models.Administrator> Administrator { get; set; }

        public DbSet<NightAlgorithm.Models.Notifikacija> Notifikacija { get; set; }

        public DbSet<NightAlgorithm.Models.VlasnikObjekta> VlasnikObjekta { get; set; }

        public DbSet<NightAlgorithm.Models.RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }

        public DbSet<NightAlgorithm.Models.Objekat> Objekat { get; set; }
    }
}
