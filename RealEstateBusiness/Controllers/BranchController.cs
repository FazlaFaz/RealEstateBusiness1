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
            return View();
        }

        [HttpPost]
        public ActionResult Create(Branch branch)
        {
            estateContext.Branches.Add(branch);
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}