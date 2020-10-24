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
    }
}