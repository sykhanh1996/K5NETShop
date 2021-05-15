using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K5NETShop.BackendServer.API.Data.Entities;
using K5NETShop.BackendServer.API.Data.Extension;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K5NETShop.BackendServer.API.Data.Configuration
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
