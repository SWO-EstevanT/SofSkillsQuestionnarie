using AutoMapper;
using MicroserviceUser.Domain.Commands;
using MicroserviceUser.Domain.Entities;
using MicroserviceUser.Infraestructure.MongoAdapter.MongoEntities;

namespace Users.Api.AutoMapper
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<UserMongo, User>().ReverseMap();
            CreateMap<CreateUser, UserMongo>().ReverseMap();
        }

    }
}
