using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace WebAPITest.Entityes
{
    
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext()
                : base("DefaultConnection")
            {

            }

            public DbSet<Employees> Employees { get; set; }
        }
    
}