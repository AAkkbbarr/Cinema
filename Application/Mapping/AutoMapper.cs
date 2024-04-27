using Application.Commons.Requests;
using Application.Commons.Responses;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    internal class AutoMApper : Profile
    {
        public AutoMApper()
        {
            CreateMap<CreateCinemaRequest, Cinema>();
            CreateMap<UpdateCinemaRequest, Cinema>();
            CreateMap<CinemaResponse, Cinema>();
            CreateMap<GetAllResponse, Cinema>();
        }
    }
}
