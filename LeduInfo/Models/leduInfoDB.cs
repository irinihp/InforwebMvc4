using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LeduInfo.Models
{
    public class leduInfoDB:DbContext
    {
        public leduInfoDB()
            : base("LeduInfoDB")
        {

        }
        public DbSet<House.HouseInfo> HouseInfotbl { get; set; }
        public DbSet<House.HouseStyle> HouseStyletbl { get; set; }
        public DbSet<House.OwnerInfo> OwnerInfotbl { get; set; }
        public DbSet<House.RenterInfo> RenterInfotbl { get; set; }
    }
}