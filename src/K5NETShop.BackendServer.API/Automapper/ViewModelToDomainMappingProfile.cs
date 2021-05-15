using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using K5NETShop.BackendServer.API.Data.Entities;
using K5NETShop.ViewModels.Systems;

namespace K5NETShop.BackendServer.API.Automapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RoleCreateRequest, AppRole>().ConstructUsing(c => new AppRole(c.Id, c.Name));

        }
    }
}
