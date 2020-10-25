using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class RentController : Controller
    {
        private EstateContext estateContext = new EstateContext();
        // GET: Rent
        public ActionResult Index()
        {
            List<Rent> Allrents = estateContext.Rents.ToList();
            return View(Allrents);
        }

        public ActionResult Create()
        {
            ViewBag.OwnerDetails = estateContext.Owners;
            ViewBag.StaffDetails = estateContext.Staffs;
            ViewBag.BranchDetails = estateContext.Branches;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            ViewBag.OwnerDetails = estateContext.Owners;
            ViewBag.StaffDetails = estateContext.Staffs;
            ViewBag.BranchDetails = estateContext.Branches;
            estateContext.Rents.Add(rent);
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {
            Rent rent = estateContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rent);
        }

        public ActionResult Edit(string id)
        {
            Rent rent = estateContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            ViewBag.OwnerDetails = new SelectList(estateContext.Rents, "OwnerNoRef", "OwnerNoRef");
            ViewBag.StaffDetails = new SelectList(estateContext.Rents, "StaffNoRef", "StaffNoRef");
            ViewBag.BranchDetails = new SelectList(estateContext.Rents, "BranchNoRef", "BranchNoRef");
            return View(rent);
        }

        [HttpPost]
        public ActionResult Edit(string id, Rent updatedRent)
        {
            Rent rent = estateContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            rent.PropertyNo = updatedRent.PropertyNo;
            rent.Street = updatedRent.Street;
            rent.City = updatedRent.City;
            rent.Ptype = updatedRent.Ptype;
            rent.rent1 = updatedRent.rent1;
            rent.Rooms = updatedRent.Rooms;
            rent.OwnerNoRef = updatedRent.OwnerNoRef;
            rent.StaffNoRef = updatedRent.StaffNoRef;
            rent.BranchNoRef = updatedRent.BranchNoRef;
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            Rent rent = estateContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rent);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletedRent(string id)
        {
            Rent rent = estateContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            estateContext.Rents.Remove(rent);
            estateContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult PropertyCity()
        {
            List<Rent> rent = estateContext.Rents.ToList();
            return View(rent);
           
        }

        public ActionResult Counts(string branch)
        {
            List<Rent> rent = estateContext.Rents.ToList();
            return View(rent);

        }
    }
}