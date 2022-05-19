﻿// <auto-generated />
using System;
using BookingSystem_DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingSystem_DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220519140203_Added Guests")]
    partial class AddedGuests
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingSystem_DAL.Models.BookedRoom", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.HasKey("RoomId", "BookingId");

                    b.HasIndex("BookingId");

                    b.ToTable("BookedRoom");
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "110 Gardens street, Nasr city, Cairo",
                            Name = "Cairo branch"
                        },
                        new
                        {
                            Id = 2,
                            Address = "510 King street, Mamoura, Alexandria",
                            Name = "Alexandria branch"
                        });
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Yousef",
                            PhoneNumber = "01112233444",
                            SSN = "30001172511355"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aly",
                            PhoneNumber = "01112255666",
                            SSN = "30001172511477"
                        });
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("MaxPeople")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchId = 1,
                            MaxPeople = 1,
                            Name = "R1",
                            Price = 100m,
                            Type = "Single"
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            MaxPeople = 1,
                            Name = "R2",
                            Price = 100m,
                            Type = "Single"
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 1,
                            MaxPeople = 1,
                            Name = "R3",
                            Price = 100m,
                            Type = "Single"
                        },
                        new
                        {
                            Id = 4,
                            BranchId = 1,
                            MaxPeople = 2,
                            Name = "R4",
                            Price = 200m,
                            Type = "Double"
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 1,
                            MaxPeople = 2,
                            Name = "R5",
                            Price = 200m,
                            Type = "Double"
                        },
                        new
                        {
                            Id = 6,
                            BranchId = 1,
                            MaxPeople = 3,
                            Name = "R6",
                            Price = 500m,
                            Type = "Suite"
                        },
                        new
                        {
                            Id = 7,
                            BranchId = 1,
                            MaxPeople = 3,
                            Name = "R7",
                            Price = 500m,
                            Type = "Suite"
                        },
                        new
                        {
                            Id = 8,
                            BranchId = 2,
                            MaxPeople = 1,
                            Name = "R1",
                            Price = 100m,
                            Type = "Single"
                        },
                        new
                        {
                            Id = 9,
                            BranchId = 2,
                            MaxPeople = 1,
                            Name = "R2",
                            Price = 100m,
                            Type = "Single"
                        },
                        new
                        {
                            Id = 10,
                            BranchId = 2,
                            MaxPeople = 1,
                            Name = "R3",
                            Price = 100m,
                            Type = "Single"
                        },
                        new
                        {
                            Id = 11,
                            BranchId = 2,
                            MaxPeople = 2,
                            Name = "R4",
                            Price = 200m,
                            Type = "Double"
                        },
                        new
                        {
                            Id = 12,
                            BranchId = 2,
                            MaxPeople = 2,
                            Name = "R5",
                            Price = 200m,
                            Type = "Double"
                        },
                        new
                        {
                            Id = 13,
                            BranchId = 2,
                            MaxPeople = 3,
                            Name = "R6",
                            Price = 500m,
                            Type = "Suite"
                        },
                        new
                        {
                            Id = 14,
                            BranchId = 2,
                            MaxPeople = 3,
                            Name = "R7",
                            Price = 500m,
                            Type = "Suite"
                        });
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.BookedRoom", b =>
                {
                    b.HasOne("BookingSystem_DAL.Models.Booking", "Booking")
                        .WithMany("BookedRooms")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingSystem_DAL.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.Booking", b =>
                {
                    b.HasOne("BookingSystem_DAL.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.Room", b =>
                {
                    b.HasOne("BookingSystem_DAL.Models.Branch", "Branch")
                        .WithMany("Rooms")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.Booking", b =>
                {
                    b.Navigation("BookedRooms");
                });

            modelBuilder.Entity("BookingSystem_DAL.Models.Branch", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}