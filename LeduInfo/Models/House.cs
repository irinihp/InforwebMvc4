﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace LeduInfo.Models
{
    
        public class HouseInfo
        {
            [Key]
            public int houseID { get; set; }
            public string Address { get; set; }
            public int ownerID { get; set; }
            public int renterID { get; set; }
            public bool rented { get; set; }
            public int houseStyleID { get; set; }
        }
        public class OwnerInfo
        {   
            [Key]
            public int ownerID { get; set; }
            public string ownerName { get; set; }
            public long phoneNumber { get; set; }
            public int DistrictID { get; set; }
        }

        public class RenterInfo
        {
            [Key]
            public int renterID { get; set; }
            public string renterName { get; set; }
            public long renterPhoneNumber { get; set; }
        }

        public class HouseStyle
        {
            [Key]
            public int houseStyleID { get; set; }
            public string houseStyle { get; set; }
        }

       public class ImgResource
        {
           [Key]
           public int imgID { get; set; }
           public string imgPath { get; set; }
           public int spanNum { get; set; }
           public string AltMsg { get; set; }
           public string Description { get; set; }
           public string smallDes { get; set; }
           public string warpwordsTitle { get; set; }
           public string warpContent { get; set; }
        }
    
}