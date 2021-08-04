using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsiTestWebAPI.ResultModels
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ReportResult, ReportResult>();
            CreateMap<List<ReportResult>, ReportListResult>();
        }
    }
}