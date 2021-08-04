using LsiTestWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LsiTestWebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("getReport")]
        public ActionResult GetReport([FromQuery] string local, string dateFrom, string dateTo)
        {
            var result = _reportService.GetReportList(local, DateTime.Parse(dateFrom), DateTime.Parse(dateTo));
            return Ok(result);
        }
    }
}
