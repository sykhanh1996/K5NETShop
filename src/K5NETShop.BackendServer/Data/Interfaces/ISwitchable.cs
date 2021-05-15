using K5NETShop.BackendServer.Data.Enums;

namespace K5NETShop.BackendServer.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}