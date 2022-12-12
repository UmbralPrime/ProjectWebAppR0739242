using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectModels;
using ProjectWebApp.Areas.Identity.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWebApp
{
    public class ProjectDBContext : IdentityDbContext<CustomUser>
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options) { }
        public DbSet<Activiteit> Activiteit { get; set; }
        public DbSet<ActiviteitGroep> ActiviteitGroepen { get; set; }
        public DbSet<Afbeelding> Afbeeldingen { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<ArtikelGroep> ArtikelGroeps { get; set; }
        public DbSet<Groep> Groepen { get; set; }
        public DbSet<Lid> Leden { get; set; }
        public DbSet<LidGroep> LidGroeps { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Activiteit>().ToTable(nameof(Activiteit));
            builder.Entity<ActiviteitGroep>().ToTable(nameof(ActiviteitGroep));
            builder.Entity<Afbeelding>().ToTable(nameof(Afbeelding));
            builder.Entity<Agenda>().ToTable(nameof(Agendas));
            builder.Entity<Album>().ToTable(nameof(Album));
            builder.Entity<Artikel>().ToTable(nameof(Artikel));
            builder.Entity<ArtikelGroep>().ToTable(nameof(ArtikelGroep));
            builder.Entity<Groep>().ToTable(nameof(Groep));
            builder.Entity<Lid>().ToTable(nameof(Lid));
            builder.Entity<LidGroep>().ToTable(nameof(LidGroep));
            builder.Entity<ActiviteitGroep>()
                .HasOne(p => p.Activiteit)
                .WithMany(x => x.Groepen)
                .HasForeignKey(p => p.ActiviteitId)
                .IsRequired();
            builder.Entity<ActiviteitGroep>()
                .HasOne(p => p.Groep)
                .WithMany(x => x.Activiteiten)
                .HasForeignKey(p => p.GroepId)
                .IsRequired();
            builder.Entity<LidGroep>()
                .HasOne(p => p.Lid)
                .WithMany(x => x.Groep)
                .HasForeignKey(p => p.LidId)
                .IsRequired();
            builder.Entity<LidGroep>()
                .HasOne(p => p.Groep)
                .WithMany(x => x.Leden)
                .HasForeignKey(p => p.GroepId)
                .IsRequired();
            builder.Entity<ArtikelGroep>()
                .HasOne(p => p.Artikel)
                .WithMany(x => x.Groepen)
                .HasForeignKey(p => p.ArtikelId)
                .IsRequired();
            builder.Entity<ArtikelGroep>()
                .HasOne(p => p.Groep)
                .WithMany(x => x.Artikels)
                .HasForeignKey(p => p.GroepId)
                .IsRequired();

        }
    }
}