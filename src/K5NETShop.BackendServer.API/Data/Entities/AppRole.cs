using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace K5NETShop.BackendServer.API.Data.Entities
{
    public class AppRole : IdentityRole
    {
        public AppRole()
        {
        }

        public AppRole(string id, string name)
        {
            Id = id;
            Name = name;
            NormalizedName = name.ToUpper();
        }

        public ICollection<Permission> Permissions { get; set; }
    }
}
