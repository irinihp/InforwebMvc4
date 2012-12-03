using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeduInfo.Models;
namespace LeduInfo.Models
{
    public class SpeicalShow
    {
        public SpeicalShow()
        {

            leduInfoDB db = new leduInfoDB();
            var houseId = from d in db.HouseInfotbl
                          where d.houseID>=0
                          select d.houseID;

        }
    }
}