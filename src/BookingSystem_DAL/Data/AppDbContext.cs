using BookingSystem_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem_DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }



        public DbSet<Room> Rooms { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add Branches
            modelBuilder.Entity<Branch>()
               .HasData(new
               {
                   Id = 1,
                   Name = "Cairo branch",
                   Address = "110 Gardens street, Nasr city, Cairo",
               },
               new
               {
                   Id = 2,
                   Name = "Alexandria branch",
                   Address = "510 King street, Mamoura, Alexandria",
               }
               );

            //Add Rooms
            modelBuilder.Entity<Room>()
                .HasData(new
                {
                    Id = 1,
                    Name = "R1",
                    Price = 100m,
                    Type = "Single",
                    MaxPeople = 1,
                    BranchId = 1
                },
                new
                {
                    Id = 2,
                    Name = "R2",
                    Price = 100m,
                    Type = "Single",
                    MaxPeople = 1,
                    BranchId = 1
                },
                new
                {
                    Id = 3,
                    Name = "R3",
                    Price = 100m,
                    Type = "Single",
                    MaxPeople = 1,
                    BranchId = 1
                },
                new
                {
                    Id = 4,
                    Name = "R4",
                    Price = 200m,
                    Type = "Double",
                    MaxPeople = 2,
                    BranchId = 1
                },
                new
                {
                    Id = 5,
                    Name = "R5",
                    Price = 200m,
                    Type = "Double",
                    MaxPeople = 2,
                    BranchId = 1
                },
                new
                {
                    Id = 6,
                    Name = "R6",
                    Price = 500m,
                    Type = "Suite",
                    MaxPeople = 3,
                    BranchId = 1
                },
                new
                {
                    Id = 7,
                    Name = "R7",
                    Price = 500m,
                    Type = "Suite",
                    MaxPeople = 3,
                    BranchId = 1
                },
                new
                {
                    Id = 1,
                    Name = "R1",
                    Price = 100m,
                    Type = "Single",
                    MaxPeople = 1,
                    BranchId = 2
                },
                new
                {
                    Id = 2,
                    Name = "R2",
                    Price = 100m,
                    Type = "Single",
                    MaxPeople = 1,
                    BranchId = 2
                },
                new
                {
                    Id = 3,
                    Name = "R3",
                    Price = 100m,
                    Type = "Single",
                    MaxPeople = 1,
                    BranchId = 2
                },
                new
                {
                    Id = 4,
                    Name = "R4",
                    Price = 200m,
                    Type = "Double",
                    MaxPeople = 2,
                    BranchId = 2
                },
                new
                {
                    Id = 5,
                    Name = "R5",
                    Price = 200m,
                    Type = "Double",
                    MaxPeople = 2,
                    BranchId = 2
                },
                new
                {
                    Id = 6,
                    Name = "R6",
                    Price = 500m,
                    Type = "Suite",
                    MaxPeople = 3,
                    BranchId = 2
                },
                new
                {
                    Id = 7,
                    Name = "R7",
                    Price = 500m,
                    Type = "Suite",
                    MaxPeople = 3,
                    BranchId = 2
                });



            modelBuilder.Entity<BookedRoom>()
                .HasKey(br => new { br.RoomId, br.BookingId });
        }
    }
}
