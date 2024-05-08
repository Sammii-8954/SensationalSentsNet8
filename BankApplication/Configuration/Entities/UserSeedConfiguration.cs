using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SensationalScentsWeb.Data;

namespace SensationalScentsWeb.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher= new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "0b7fbc79-9d52-42a2-81f5-f463703d36be",
                    Email = "admin@localhost1.com",
                    NormalizedEmail = "ADMIN@LOCALHOST1.COM",
                    NormalizedUserName= "ADMIN@LOCALHOST1.COM",
                    UserName = "admin@localhost1.com",
                    Firstname ="System",
                    Lastname ="Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed= true

                },
                new Employee
                {
                    Id = "bd90e64b-c379-40e3-ad61-5f4cd2c70038",
                    Email = "user@localhost1.com",
                    NormalizedEmail = "USER@LOCALHOST1.COM",
                    NormalizedUserName = "USER@LOCALHOST1.COM",
                    UserName = "user@localhost1.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed= true

                }


            );
        }
    }
}