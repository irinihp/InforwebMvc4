using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.IO;


namespace LeduInfo.Models
{
    public class picpicker
    {
        public static void  imgPicker()
        {
            var db = new leduInfoDB();
            
            var rootpath = ConfigurationManager.AppSettings["DocBasePath"];
            if (Directory.Exists(rootpath))
            {
                
                foreach (var item in Directory.GetFiles(rootpath))
                {
                   var filepath = from p in db.ImgPaths
                                  where item==p.Path
                                  select p;

                   if (filepath!=null)
                   {
                       continue;
                   }
                    db.ImgPaths.Add(new ImgPath { Path = item});
                    
                }
                db.SaveChanges();
            }

        }
    }
}