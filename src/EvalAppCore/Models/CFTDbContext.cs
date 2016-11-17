using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalAppCore.Models
{
    public class CFTDbContext : DbContext
    {
        public CFTDbContext(DbContextOptions<CFTDbContext> options) : base(options)
        { }

        //public DbSet<>
    }


    public class TimeEntry
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Employee{ get; set; }
        public string Client { get; set; }
        public string Contract { get; set; }
        public string Service { get; set; }
        public string Time { get; set; }
        public bool MakeUp { get; set; }
        public string Project { get; set; }


    }


    public class Clients
    {
        public int ClientID { get; set; }
        public string ClientName{ get; set; }
    }

    public class Contracts
    {
            public int ContractID { get; set; }
        public int ClientID { get; set; }
            public string Contract{ get; set; }

    }

}
