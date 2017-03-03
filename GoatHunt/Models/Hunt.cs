using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoatHunt.Models
{
    public class Hunt
    {
        [Key]
        public int Id { get; set; }
        public string HuntNumber { get; set; }
        public string HuntName { get; set; }
        public string Type { get; set; }
        public string Permits { get; set; }
        public string NumHuntersAfield { get; set; }
        public string Harvest { get; set; }
        public string AverageDays { get; set; }
        public string PercentSuccess { get; set; }
    }
}