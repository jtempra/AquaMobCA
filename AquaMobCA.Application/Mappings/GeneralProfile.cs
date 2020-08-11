using System;
using System.Collections.Generic;
using System.Text;
using Application.Features.AnotacionOTFeatures.Commands;
using Application.Features.AnotacionOTFeatures.Queries;
using Application.Features.UserFeatures.Commands;
using Application.Features.UserFeatures.Queries;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<UserEntity, GetAllUsersViewModel>().ReverseMap();
            CreateMap<CreateUserCommand, UserEntity>();
            CreateMap<GetAllUsersQuery, GetAllUsersParameter>();

            CreateMap<AnotacionOTEntity, GetAllAnotacionesOTViewModel>().ReverseMap();
            CreateMap<CreateAnotacionOTCommand, AnotacionOTEntity>();
            CreateMap<GetAllAnotacionesOTQuery, GetAllAnotacionesOTParameter>();
        }
    }
}
