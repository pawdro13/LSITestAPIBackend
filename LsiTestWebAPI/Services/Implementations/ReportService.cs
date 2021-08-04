using AutoMapper;
using LsiTestWebAPI.Database;
using LsiTestWebAPI.Models;
using LsiTestWebAPI.ResultModels;
using LsiTestWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LsiTestWebAPI.Services.Implementations
{
    public class ReportService : IReportService
    {
        private readonly LSIDbContext _dbContext;
        private readonly IMapper _mapper;

        public ReportService(LSIDbContext dbContext, IMapper mapper)
        {
           _dbContext = dbContext;
            _mapper = mapper;
        }

        public ReportListResult GetReportList(string local = null, DateTime? DateFrom = null, DateTime? DateTo = null)
        {
            IList<Report> result = null;

            if (local != null && DateFrom == null)
            {
                result = _dbContext.Reports.Where(r => r.LocalName.Equals(local)).ToList();
            }
            else if (local == null && DateFrom != null)
            {
                result = _dbContext.Reports.Where(r => r.DateOfRaport > DateFrom && r.DateOfRaport < DateTo).ToList();
            }
            else if (local != null && DateFrom != null)
            {
                result = _dbContext.Reports.Where(r => r.DateOfRaport > DateFrom && r.DateOfRaport < DateTo && r.LocalName.Equals(local)).ToList();
            }
            else 
            {
                result = _dbContext.Reports.ToList();
            }
            return _mapper.Map<ReportListResult>(result);
        }
    }
}