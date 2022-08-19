﻿// <auto-generated />
using CoderResort.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoderResort.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220818223212_addedFeaturedRoomAttribute")]
    partial class addedFeaturedRoomAttribute
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("CoderResort.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FeaturedRoom")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Size")
                        .HasColumnType("TEXT");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            Capacity = 2,
                            Description = "Double Deluxe Room.",
                            FeaturedRoom = true,
                            ImageUrl = "https://i.ibb.co/L9bYkSZ/room-1.jpg",
                            Name = "Double Deluxe",
                            Price = 400m,
                            Size = 500m
                        },
                        new
                        {
                            RoomId = 2,
                            Capacity = 5,
                            Description = "Family Standard Room.",
                            FeaturedRoom = true,
                            ImageUrl = "https://i.ibb.co/0yjxGxp/room-2.jpg",
                            Name = "Standard",
                            Price = 400m,
                            Size = 600m
                        },
                        new
                        {
                            RoomId = 3,
                            Capacity = 8,
                            Description = "Presidential Room.",
                            FeaturedRoom = false,
                            ImageUrl = "https://i.ibb.co/2tCwhYF/room-3.jpg",
                            Name = "Presidential",
                            Price = 600m,
                            Size = 1000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
