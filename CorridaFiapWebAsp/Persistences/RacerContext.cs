using CorridaFiapWebAsp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorridaFiapWebAsp.Persistences
{
    public class RacerContext : DbContext
    {
        public DbSet<Corrida> Corridas { get; set; }

        public DbSet<Medalha> Medatlhas { get; set; }
        public DbSet<Atleta> Atletas { get; set; }
        public DbSet<Trajeto> Trajetos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Mapeando as chaves da tabela
            modelBuilder.Entity<CorridaAtleta>()
                .HasKey(c => new{ c.AtletaId, c.CorridaId});

            //Mapeando o relacionamento com o Atleta
            modelBuilder.Entity<CorridaAtleta>()
                .HasOne(c => c.Atleta)
                .WithMany(c => c.CorridaAtletas)
                .HasForeignKey(c => c.AtletaId);

            //Mapeando o relacionamento com a Corrida
            modelBuilder.Entity<CorridaAtleta>()
                .HasOne(c => c.Corrida)
                .WithMany(c => c.CorridaAtletas)
                .HasForeignKey(c => c.CorridaId);

            base.OnModelCreating(modelBuilder);
        }

        public RacerContext(DbContextOptions o) : base(o)
        {

        }
    }
}
