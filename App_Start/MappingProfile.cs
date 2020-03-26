using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(dest => dest.Id, m => m.Ignore());
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.Id, m => m.Ignore());
            Mapper.CreateMap<Genre, GenreDto>();
        }
    }
}