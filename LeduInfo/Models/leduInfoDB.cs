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
            : base("leduInfo")
        {

        }
        public DbSet<HouseInfo> HouseInfotbl { get; set; }
        public DbSet<HouseStyle> HouseStyletbl { get; set; }
        public DbSet<OwnerInfo> OwnerInfotbl { get; set; }
        public DbSet<RenterInfo> RenterInfotbl { get; set; }
        public DbSet<ImgResource> ImgResources { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<ImgPath> ImgPaths { get; set; }
        public DbSet<LoginModel> UserLogin { get; set; }
        public DbSet<VoteComments> VoteComment { get; set; }
    }
}