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


    public class VoteComments
    {
        [Key]
        public int CommentID { get; set; }
        public string Comments { get; set; }
        public bool ViewPoint { get; set; }
        public int UserID { get; set; }
    }
    

}