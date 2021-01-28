﻿using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile  : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                .ForMember(c => c.Venue, o => o.MapFrom(s => s.Location.VenueName))
                .ReverseMap();
            this.CreateMap<Talk, TalkModel>();
            this.CreateMap<Speaker, SpeakerModel>();
        }
    }
}
