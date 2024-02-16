using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("FF1DC87B-7F05-4E15-A11B-CE5B8A448DAC"),
                RoleId = Guid.Parse("FADADACB-B4D3-4F81-A7F9-A97CB46DDCE5")
            }, 
            new AppUserRole
            {
                UserId = Guid.Parse("4473B6BC-3BE0-4BB0-A39F-3426CEC6FB03"),
                RoleId = Guid.Parse("DCB8D312-868B-4910-A055-76230497233F")
            });
        }
    }
}
