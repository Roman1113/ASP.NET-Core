using Microsoft.EntityFrameworkCore;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Entityes
{
        public class DBContext : DbContext
        {
            public DBContext(DbContextOptions<DBContext> options) : base(options)
            {

            }
            public DbSet<BlogModel> Blog { get; set; }

        }
}