using LsiTestWebAPI.ResultModels;
using System;

namespace LsiTestWebAPI.Services.Interfaces
{
    public interface IReportService
    {
        ReportListResult GetReportList(string local = null, DateTime? DateFrom = null, DateTime? DateTo = null);
    }
}