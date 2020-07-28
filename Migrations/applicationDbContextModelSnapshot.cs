﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gestionRondeBackEnd.models;

namespace gestionRondeBackEnd.Migrations
{
    [DbContext(typeof(applicationDbContext))]
    partial class applicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("gestionRondeBackEnd.models.Admin", b =>
                {
                    b.Property<string>("codeAdmin")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("nomAdmin")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("pawdAdmin")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("prenomAdmin")
                        .HasColumnType("varchar(150)");

                    b.HasKey("codeAdmin");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("gestionRondeBackEnd.models.Agent", b =>
                {
                    b.Property<string>("codeAgent")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("codePlanning")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("nomAgent")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("pawdAgent")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("prenomAgent")
                        .HasColumnType("varchar(150)");

                    b.HasKey("codeAgent");

                    b.HasIndex("codePlanning");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("gestionRondeBackEnd.models.BLE", b =>
                {
                    b.Property<string>("idBLE")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("heurAjout")
                        .HasColumnType("varchar(150)");

                    b.HasKey("idBLE");

                    b.ToTable("BLEs");
                });

            modelBuilder.Entity("gestionRondeBackEnd.models.Planning", b =>
                {
                    b.Property<string>("codePlanning")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("codeAdmin")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("desc")
                        .HasColumnType("varchar(150)");

                    b.HasKey("codePlanning");

                    b.HasIndex("codeAdmin");

                    b.ToTable("Plannings");
                });

            modelBuilder.Entity("gestionRondeBackEnd.models.Trace", b =>
                {
                    b.Property<string>("codeTrace")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("codeAgent")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("wifiName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("codeTrace");

                    b.HasIndex("codeAgent");

                    b.ToTable("Traces");
                });

            modelBuilder.Entity("gestionRondeBackEnd.models.Agent", b =>
                {
                    b.HasOne("gestionRondeBackEnd.models.Planning", "planning")
                        .WithMany()
                        .HasForeignKey("codePlanning");
                });

            modelBuilder.Entity("gestionRondeBackEnd.models.Planning", b =>
                {
                    b.HasOne("gestionRondeBackEnd.models.Admin", "admin")
                        .WithMany()
                        .HasForeignKey("codeAdmin");
                });

            modelBuilder.Entity("gestionRondeBackEnd.models.Trace", b =>
                {
                    b.HasOne("gestionRondeBackEnd.models.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("codeAgent");
                });
#pragma warning restore 612, 618
        }
    }
}
