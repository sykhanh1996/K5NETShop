using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K5NETShop.BackendServer.API.Data.Enums;

namespace K5NETShop.BackendServer.API.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
