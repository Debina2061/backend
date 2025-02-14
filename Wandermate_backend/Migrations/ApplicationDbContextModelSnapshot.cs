﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Wandermate_backend.Data;

#nullable disable

namespace Wandermate_backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Wandermate_backend.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("FreeCancellation")
                        .HasColumnType("boolean");

                    b.Property<List<string>>("Image")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<bool>("Reservation")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("Wandermate_backend.Models.Hotelinfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Hotelid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Hotelid")
                        .IsUnique();

                    b.ToTable("Hotelinfo");
                });

            modelBuilder.Entity("Wandermate_backend.Models.Hotelreview", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ReviewId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("HotelId")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ReviewId");

                    b.HasIndex("HotelId");

                    b.ToTable("Hotelreview");
                });

            modelBuilder.Entity("Wandermate_backend.Models.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("FreeCancellation")
                        .HasColumnType("boolean");

                    b.Property<List<string>>("Image")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<bool>("Reservation")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Travel");
                });

            modelBuilder.Entity("Wandermate_backend.Models.Hotelinfo", b =>
                {
                    b.HasOne("Wandermate_backend.Models.Hotel", "Hotel")
                        .WithOne("Hotelinfo")
                        .HasForeignKey("Wandermate_backend.Models.Hotelinfo", "Hotelid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Wandermate_backend.Models.Hotelreview", b =>
                {
                    b.HasOne("Wandermate_backend.Models.Hotel", "Hotel")
                        .WithMany("Hotelreviews")
                        .HasForeignKey("HotelId");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Wandermate_backend.Models.Hotel", b =>
                {
                    b.Navigation("Hotelinfo")
                        .IsRequired();

                    b.Navigation("Hotelreviews");
                });
#pragma warning restore 612, 618
        }
    }
}
