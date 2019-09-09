﻿// <auto-generated />
using CorridaFiapWebAsp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CorridaFiapWebAsp.Migrations
{
    [DbContext(typeof(AllCorridaContext))]
    partial class AllCorridaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CorridaFiapWebAsp.Models.Corrida", b =>
                {
                    b.Property<int>("CorridaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoria");

                    b.Property<float>("Distancia");

                    b.Property<string>("Nome");

                    b.Property<bool>("Premiacao");

                    b.HasKey("CorridaId");

                    b.ToTable("Corridas");
                });
#pragma warning restore 612, 618
        }
    }
}
