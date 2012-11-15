using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LeduInfo.Models
{
    public class bloggingModel
    {
        [Key]
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class MyClass
    {
        
    }

    public class BlogContext : DbContext
    {
        public BlogContext()
       
            : base("DefaultConnection")
        {
        }
        public DbSet<bloggingModel> Blogtbl { get; set; }
    }
}