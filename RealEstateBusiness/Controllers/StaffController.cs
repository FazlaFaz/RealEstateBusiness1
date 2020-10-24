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
        public ActionResult Create(Staff staff)
        {
            ViewBag.BranchDetails = estateContext.Branches;
            estateContext.Staffs.Add(staff);
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
            ViewBag.BranchDetails = new SelectList(estateContext.Staffs, "BranchNoRef", "BranchNoRef");
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
            staff.DOB = updatedStaff.DOB;
            staff.Salary = updatedStaff.Salary;
            staff.BranchNoRef = updatedStaff.BranchNoRef;
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            Staff staff = estateContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletedStaff(string id)
        {
            Staff staff = estateContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            estateContext.Staffs.Remove(staff);
            estateContext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}