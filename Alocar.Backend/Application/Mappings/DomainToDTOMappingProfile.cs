﻿using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Vehicle, VehicleDTO>().ReverseMap();
            CreateMap<Allocation, AllocationDTO>().ReverseMap();
        }
    }
}
