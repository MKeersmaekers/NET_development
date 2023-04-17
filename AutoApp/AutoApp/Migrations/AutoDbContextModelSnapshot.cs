﻿// <auto-generated />
using AutoApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoApp.Migrations
{
    [DbContext(typeof(AutoDbContext))]
    partial class AutoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutoApp.Models.Auto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Chassisnr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MerkID")
                        .HasColumnType("int");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MerkID");

                    b.ToTable("Autos");
                });

            modelBuilder.Entity("AutoApp.Models.Merk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Merken");
                });

            modelBuilder.Entity("AutoApp.Models.Auto", b =>
                {
                    b.HasOne("AutoApp.Models.Merk", "Merk")
                        .WithMany("Autos")
                        .HasForeignKey("MerkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Merk");
                });

            modelBuilder.Entity("AutoApp.Models.Merk", b =>
                {
                    b.Navigation("Autos");
                });
#pragma warning restore 612, 618
        }
    }
}
