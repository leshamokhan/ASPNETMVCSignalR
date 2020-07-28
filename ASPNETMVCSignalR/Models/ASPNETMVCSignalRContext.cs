using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNETMVCSignalR.Models
{
    public class ASPNETMVCSignalRContext : DbContext
    {
        public ASPNETMVCSignalRContext() : base("ASPNETMVCSignalR")
        {
        }

        public DbSet<Person> People { get; set; }

    }
}