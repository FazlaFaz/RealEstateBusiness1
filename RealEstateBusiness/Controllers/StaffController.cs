using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class StaffController : Controller
    {
        private EstateContext estateContext = new EstateContext();
        // GET: Rent
        public ActionResult Index()
        {
            List<Staff> Allstaffs = estateContext.Staffs.ToList();
            return View(Allstaffs);
        }

        public ActionResult Create()
        {
            ViewBag.BranchDetails = estateContext.Branches;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            ViewBag.BranchDetails = estateContext.Branches;
            estateContext.Rents.Add(rent);
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {
            Staff staff = estateContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }

        public ActionResult Edit(string id)
        {
            Staff staff = estateContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            ViewBag.StaffDetails = new SelectList(estateContext.Staffs, "StaffNo", "StaffNo");
            return View(staff);
        }

        [HttpPost]
        public ActionResult Edit(string id, Staff updatedStaff)
        {
            Staff staff = estateContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            staff.StaffNo = updatedStaff.StaffNo;
            staff.Fname = updatedStaff.Fname;
            staff.Lname = updatedStaff.Lname;
            staff.Position = updatedStaff.Position;
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}