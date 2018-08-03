using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LuminuxHousing.Dtos;
using LuminuxHousing.Models;

namespace LuminuxHousing.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Plot, PlotDto>();
            Mapper.CreateMap<PlotDto, Plot>();
        }
    }
}