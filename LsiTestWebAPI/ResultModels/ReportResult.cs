using System;

namespace LsiTestWebAPI.ResultModels
{
    public class ReportResult
    {
        public string Name { get; set; }
        public DateTime DateOfRaport { get; set; }
        public string UserName { get; set; }
        public string LocalName { get; set; }
    }
}