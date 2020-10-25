using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class BranchController : Controller
    {
        private EstateContext estateContext = new EstateContext();
        // GET: Branch
        public ActionResult Index()
        {
            List<Branch> AllBranches = estateContext.Branches.ToList();
            return View(AllBranches);
        }


        public ActionResult Create()
        {
            ViewBag.BranchDetails = estateContext.Branches;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Branch branch)
        {
            ViewBag.BranchDetails = estateContext.Branches;
            estateContext.Branches.Add(branch);
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            Branch branch = estateContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }

        public ActionResult Edit(string id)
        {
            Branch branch = estateContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            ViewBag.BranchDetails = new SelectList(estateContext.Branches, "BranchNo", "BranchNo");
            return View(branch);
        }

        [HttpPost]
        public ActionResult Edit(string id, Branch updatedBranch)
        {
            Branch branch = estateContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            branch.BranchNo = updatedBranch.BranchNo;
            branch.Street = updatedBranch.Street;
            branch.City = updatedBranch.City;
            branch.PostCode = updatedBranch.PostCode;
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            Branch branch = estateContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletedBranch(string id)
        {
            Branch branch = estateContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            estateContext.Branches.Remove(branch);
            estateContext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}