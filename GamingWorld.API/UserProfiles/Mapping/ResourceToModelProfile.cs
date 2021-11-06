﻿using AutoMapper;
using GamingWorld.API.UserProfiles.Domain.Models;
using GamingWorld.API.UserProfiles.Resources;

namespace GamingWorld.API.UserProfiles.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveUserProfileResource, UserProfile>()
                .ForMember(target =>
                        target.GamingLevel,
                    options =>
                        options.MapFrom(source =>
                            (EGamingLevel) source.GamingLevel));
        }
    }
}