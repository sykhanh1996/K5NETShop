using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K5NETShop.BackendServer.API.Data.Interfaces
{
    public interface IDateTracking
    {
        string ModifiedBy { get; set; }
        string CreatedBy { get; set; }
        DateTime CreateDate { get; set; }
        DateTime? LastModifiedDate { get; set; }
    }
}
