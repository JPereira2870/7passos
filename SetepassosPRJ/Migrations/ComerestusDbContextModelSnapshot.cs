﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SetepassosPRJ.Models;

namespace SetepassosPRJ.Migrations
{
    [DbContext(typeof(ComerestusDbContext))]
    partial class ComerestusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SetepassosPRJ.Models.ModeloDeHiscores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ChaveEncontrada");

                    b.Property<int>("FugasDoInimigo");

                    b.Property<int>("InimigosDerrotados");

                    b.Property<int>("InvestigacaoDaArea");

                    b.Property<double>("MoedasDeOuro");

                    b.Property<string>("Nickname");

                    b.Property<int>("NumeroDeItensEncontrados");

                    b.Property<int>("PocoesTotais");

                    b.Property<int>("PocoesUsadas");

                    b.Property<int>("ResultadoFinal");

                    b.HasKey("Id");

                    b.ToTable("ModeloDeHiscores");
                });
#pragma warning restore 612, 618
        }
    }
}
