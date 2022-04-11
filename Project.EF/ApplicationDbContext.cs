using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.EF
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<College> College { get; set; }
        public DbSet<TicketStatus> TicketStatus { get; set; }
        public DbSet<TicketType> TicketType { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Notification> Notification { get; set; }
    }
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<TicketStatus>().HasData(
               new TicketStatus
               {
                   TicketStatus_ID=1,
                   Name_Ar="منشأ",
                   Name_En="Created",
                   IsActive=true,
                   IsDeleted = false
               },
               new TicketStatus
               {
                   TicketStatus_ID = 2,
                   Name_Ar = "معتمد",
                   Name_En = "Approved",
                   IsActive = true,
                   IsDeleted = false
               }
               ,
               new TicketStatus
               {
                   TicketStatus_ID = 3,
                   Name_Ar = "مرفوض",
                   Name_En = "Rejected",
                   IsActive = true,
                   IsDeleted = false
               }
               ,
               new TicketStatus
               {
                   TicketStatus_ID = 4,
                   Name_Ar = "محذوف",
                   Name_En = "Deleted",
                   IsActive = true,
                   IsDeleted = false
               }
           );
        }
    }
}
