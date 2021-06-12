using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NightAlgorithm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NightAlgorithmProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Događaj> Događaj { get; set; }

        public DbSet<NightAlgorithm.Models.Administrator> Administrator { get; set; }

        public DbSet<NightAlgorithm.Models.Notifikacija> Notifikacija { get; set; }

        public DbSet<NightAlgorithm.Models.VlasnikObjekta> VlasnikObjekta { get; set; }

        public DbSet<NightAlgorithm.Models.RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }

        public DbSet<NightAlgorithm.Models.Objekat> Objekat { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Događaj>().ToTable("Dogadjaj");
            modelBuilder.Entity<Administrator>().ToTable("Admin");
            modelBuilder.Entity<Notifikacija>().ToTable("Notifikacija");
            modelBuilder.Entity<VlasnikObjekta>().ToTable("Vlasnik");
            modelBuilder.Entity<RegistrovaniKorisnik>().ToTable("RegistrovaniKorisnik");
            modelBuilder.Entity<Objekat>().ToTable("Objekat");

            base.OnModelCreating(modelBuilder);
        }
    }
}
