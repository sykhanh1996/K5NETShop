using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K5NETShop.BackendServer.API.Data.Entities;
using K5NETShop.BackendServer.API.Data.Extension;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K5NETShop.BackendServer.API.Data.Configuration
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
