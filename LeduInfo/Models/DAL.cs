using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LeduInfo.Models
{
    public class DAL
    {

        public class LeduInfoDBInitializer:CreateDatabaseIfNotExists<leduInfoDB>
        {

            protected override void Seed(leduInfoDB context)
            {
                base.Seed(context);
            }
            public static void CreateDB()
            {
                using (var db = new leduInfoDB())
                {
                    db.OwnerInfotbl.Add(new House.OwnerInfo { ownerName = "Robin", phoneName = 15210457610 });
                    db.SaveChanges();
                }
            }
         
        }
    }
}