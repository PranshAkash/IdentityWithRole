using IdentityWithRole.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace IdentityWithRole.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        private readonly DbContextOptions _options;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedRoles();

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.SeedRoles();
        //    modelBuilder.Entity<AppUser>().ToTable("AppUser");
        //}
        public DbSet<Student> Students { get; set; }
    }
}
