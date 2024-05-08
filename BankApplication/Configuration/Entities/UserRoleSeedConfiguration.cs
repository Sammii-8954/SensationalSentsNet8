using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SensationalScentsWeb.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                
                new IdentityUserRole<string>
                {
                    RoleId = "0a7fcd79-9c52-42c2-81f5-h463703d36be",
                    UserId= "0b7fbc79-9d52-42a2-81f5-f463703d36be",
                },

                new IdentityUserRole<string>
                {
                    RoleId = "0b8bbd79-6c52-42a3-81g5-h463503b36de",
                    UserId = "bd90e64b-c379-40e3-ad61-5f4cd2c70038",
                }




                );
        }
    }
}