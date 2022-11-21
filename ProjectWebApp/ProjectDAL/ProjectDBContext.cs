using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public class ProjectDBContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Activiteit> Activiteiten { get; set; }
        public DbSet<ActiviteitGroep> ActiviteitGroepen { get; set; }
        public DbSet<Afbeelding> Afbeeldingen { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<ArtikelGroep> ArtikelGroeps { get; set; }
        public DbSet<Groep> Groepen { get; set; }
        public DbSet<Lid> Leden { get; set; }
        public DbSet<LidGroep> LidGroeps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProjectWebApp;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}