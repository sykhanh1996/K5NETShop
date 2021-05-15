using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using K5NETShop.BackendServer.API.Data.Entities;

namespace K5NETShop.BackendServer.API.Automapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<AppRole, RoleVm>().MaxDepth(2);
        }
    }
}
