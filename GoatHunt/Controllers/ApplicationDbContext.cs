using GoatHunt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoatHunt.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Hunt> Hunts { get; set; }
    }
}