using K5NETShop.BackendServer.Data.Entities;
using K5NETShop.BackendServer.Data.Extension;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K5NETShop.BackendServer.Data.Configuration
{
    public class PermissionConfiguration : DbEntityConfiguration<Permission>
    {
        public override void Configure(EntityTypeBuilder<Permission> entity)
        {
            entity.HasKey(c => new { c.RoleId, c.FunctionId, c.CommandId });
            // etc.
        }
    }
}