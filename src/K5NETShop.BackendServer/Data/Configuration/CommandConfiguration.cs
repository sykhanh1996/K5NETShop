using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K5NETShop.BackendServer.Data.Entities;
using K5NETShop.BackendServer.Data.Extension;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K5NETShop.BackendServer.Data.Configuration
{
    public class CommandConfiguration : DbEntityConfiguration<Command>
    {
        public override void Configure(EntityTypeBuilder<Command> entity)
        {
            entity.HasKey(c => new { c.Id});
            // etc.
        }
    }
}
