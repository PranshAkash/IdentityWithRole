using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityWithRole.Helper
{
    public static class ModelBuilderExtension
    {
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole() { Id = "da576a70-2276-4872-a496-6765a07534e6", ConcurrencyStamp = "da576a70-2276-4872-a496-6765a07534e6", Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole() { Id = "da576a70-2276-4872-a496-6765a07534e4", ConcurrencyStamp = "b52abe85-ca0e-44ae-a4d0-fd1b315576ee", Name = "Student", NormalizedName = "STUDENT" },
                    new IdentityRole() { Id = "da576a70-2276-4872-a496-6765a07534e5", ConcurrencyStamp = "ct2abe85-ca0e-44ae-a5d0-fd1b315576ae", Name = "Teacher", NormalizedName = "TEACHER" }
               );
        }
    }
}
