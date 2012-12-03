﻿using System;
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
            
            
            var rootpath = ConfigurationManager.AppSettings["ImgBasePath"];
            if (Directory.Exists(rootpath))
            {
                foreach (var item in Directory.GetFiles(rootpath))
                {
                   var foo=@item;
                   var filepathInDB = from p in db.ImgPaths
                                  where p.Path==foo
                                  select p;
                   
                   if (filepathInDB.Any())
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