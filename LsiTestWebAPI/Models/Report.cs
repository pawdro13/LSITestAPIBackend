using System;

namespace LsiTestWebAPI.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfRaport { get; set; }
        public string UserName { get; set; }
        public string LocalName { get; set; }

    }
}
