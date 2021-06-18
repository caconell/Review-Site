﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(TacoContext))]
    [Migration("20210618154029_add-migration sabotage061821")]
    partial class addmigrationsabotage061821
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "/images/spicy-shrimp-tacos.jpg",
                            Name = "Shrimp Tacos"
                        },
                        new
                        {
                            Id = 2,
                            Image = "/images/Keto-Tacos.jpg",
                            Name = "Keto Tacos"
                        },
                        new
                        {
                            Id = 3,
                            Image = "/images/ground-beef-tacos-3.jpg",
                            Name = "Ground Beef Tacos"
                        },
                        new
                        {
                            Id = 4,
                            Image = "/images/carnitas.jpg",
                            Name = "Carnitas Tacos"
                        },
                        new
                        {
                            Id = 5,
                            Image = "/images/instant-pot-shredded-chicken-tacos-5.jpg",
                            Name = "Chicken Tacos"
                        },
                        new
                        {
                            Id = 6,
                            Image = "/images/fish-taco.jpg",
                            Name = "Fish Tacos"
                        },
                        new
                        {
                            Id = 7,
                            Image = "/images/Vegetarian-Tacos-3.jpg",
                            Name = "Veggie Tacos"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Reviewername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "this tacos great",
                            Reviewername = "userreviewer"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ReviewsSite.Models.Product", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
