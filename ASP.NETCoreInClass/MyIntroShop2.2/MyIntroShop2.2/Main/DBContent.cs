using Microsoft.EntityFrameworkCore;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main
{
    public class DBContent : DbContext
    {
            public DBContent(DbContextOptions<DBContent> options) : base(options)
            {

            }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<PhoneCategory> PhoneCategories { get; set; }
        //public DbSet<Motherboard> Motherboards { get; set; }
        //public DbSet<MotherboardCategory> MotherboardCategories { get; set; }
        //public DbSet<Procesor> Procesors { get; set; }
        //public DbSet<ProcesorCategory> ProcesorCategories { get; set; }
        //public DbSet<Ram> Rams { get; set; }
        //public DbSet<RamCategory> RamCategories { get; set; }
        //public DbSet<Ssd> Ssds { get; set; }
        //public DbSet<SsdCategory> SsdCategories { get; set; }
        //public DbSet<VideoCard> VideoCards { get; set; }
        //public DbSet<VideoCardCategory> VideoCardCategories { get; set; }
    }
}
