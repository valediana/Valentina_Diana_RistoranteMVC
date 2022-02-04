﻿using Microsoft.EntityFrameworkCore;
using RistoranteMVC.Core.Entities;
using RistoranteMVC.RepositoryEF.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.RepositoryEF
{
    public class MasterContext : DbContext
    {
        //Elenco dei DbSet ovvero delle "tabelle/entità" 
        public DbSet<Piatto> Piatti { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Utente> Utenti { get; set; }

        public MasterContext()
        {

        }

        public MasterContext(DbContextOptions<MasterContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RistoranteMVCProvaFinale;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Piatto>(new PiattoConfiguration());
            modelBuilder.ApplyConfiguration<Menu>(new MenuConfiguration());
            modelBuilder.ApplyConfiguration<Utente>(new UtenteConfiguration());

        }
    }
}
