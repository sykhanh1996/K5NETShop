using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K5NETShop.BackendServer.API.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeywords { set; get; }
        string SeoDescription { get; set; }
    }
}
