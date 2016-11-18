using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvalAppCore.Models;
using EvalAppCore.CFT_specific;

namespace EvalAppCore.Models
{
    public class CFTDbContext : DbContext
    {
        public CFTDbContext(DbContextOptions<CFTDbContext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<ServiceClass> Services { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }

    }





}
