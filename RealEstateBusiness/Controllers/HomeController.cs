﻿using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class HomeController : Controller
    {
        private EstateContext estateContext = new EstateContext();
        // GET: Home
        public ActionResult Index()
        {
            List<Branch> AllBranches = estateContext.Branches.ToList();
            return View(AllBranches);
        }

        public ActionResult Index1()
        {
            List<Owner> AllOwners = estateContext.Owners.ToList();
            return View(AllOwners);
        }

        public ActionResult Index2()
        {
            List<Rent> AllRents = estateContext.Rents.ToList();
            return View(AllRents);
        }

        public ActionResult Index3()
        {
            List<Staff> AllStaffs = estateContext.Staffs.ToList();
            return View(AllStaffs);
        }

        public ActionResult BranchNames()
        {
            List<Branch> branch = estateContext.Branches.ToList();
            return View(branch);
        }

        public ActionResult StaffNames()
        {
            List<Staff> staffs = estateContext.Staffs.ToList();
            return View(staffs);
        }
        public ActionResult StaffinBranch(string branchNo)
        {
            List<Staff> staffs = estateContext.Staffs.Where(x => x.BranchNoRef == branchNo).ToList();
            return View(staffs);
        }

        public ActionResult StaffDetails(string id)
        {
            Staff staff = estateContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }

        public ActionResult OwnersProperty(string Id)
        {
            Owner owner = estateContext.Owners.SingleOrDefault(x => x.OwnerNo == Id);
            return View(owner);
        }

        public ActionResult PropDetails(string Id)
        {
            List<Rent> rent = estateContext.Rents.Where(x => x.OwnerNoRef == Id).ToList();
            return View(rent);
        }
    }
}