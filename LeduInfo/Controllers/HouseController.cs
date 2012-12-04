using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeduInfo.Models;
namespace LeduInfo.Controllers
{
    public class HouseController : Controller
    {
        private leduInfoDB db = new leduInfoDB();

        //
        // GET: /House/

        public ActionResult Index()
        {
            ViewBag.District = db.Districts.DefaultIfEmpty();
            return View(db.ImgResources.ToList());
        }

        public ActionResult HouseDetails(int id = 0)
        {
            HouseInfo houseinfo = db.HouseInfotbl.Find(id);
            if (houseinfo == null)
            {
                return HttpNotFound();
            }

            return View("HouseDetails", houseinfo);
        }
        //
        // GET: /House/Details/5

        public ActionResult Details(int id = 0)
        {
            HouseInfo houseinfo = db.HouseInfotbl.Find(id);
            if (houseinfo == null)
            {
                return HttpNotFound();
            }
            return View(houseinfo);
        }

        //
        // GET: /House/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /House/Create

        [HttpPost]
        public ActionResult Create(HouseInfo houseinfo)
        {
            if (ModelState.IsValid)
            {
                db.HouseInfotbl.Add(houseinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(houseinfo);
        }

        //
        // GET: /House/Edit/5

        public ActionResult Edit(int id = 0)
        {
            HouseInfo houseinfo = db.HouseInfotbl.Find(id);
            if (houseinfo == null)
            {
                return HttpNotFound();
            }
            return View(houseinfo);
        }

        //
        // POST: /House/Edit/5

        [HttpPost]
        public ActionResult Edit(HouseInfo houseinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(houseinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(houseinfo);
        }

        //
        // GET: /House/Delete/5

        public ActionResult Delete(int id = 0)
        {
            HouseInfo houseinfo = db.HouseInfotbl.Find(id);
            if (houseinfo == null)
            {
                return HttpNotFound();
            }
            return View(houseinfo);
        }

        //
        // POST: /House/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            HouseInfo houseinfo = db.HouseInfotbl.Find(id);
            db.HouseInfotbl.Remove(houseinfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}