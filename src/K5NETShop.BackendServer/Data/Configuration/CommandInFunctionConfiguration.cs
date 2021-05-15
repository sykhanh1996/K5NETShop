using K5NETShop.BackendServer.Data.Entities;
using K5NETShop.BackendServer.Data.Extension;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K5NETShop.BackendServer.Data.Configuration
{
    public class CommandInFunctionConfiguration : DbEntityConfiguration<CommandInFunction>
    {
        public override void Configure(EntityTypeBuilder<CommandInFunction> entity)
        {
            entity.HasKey(c => new { c.CommandId, c.FunctionId });
            // etc.
        }
    }
}