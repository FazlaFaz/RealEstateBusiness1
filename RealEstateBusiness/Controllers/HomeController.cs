using RealEstateBusiness.Models;
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
            List<Branch> Branches = estateContext.Branches.ToList();
            return View(Branches);
        }

        public ActionResult Index1()
        {
            List<Owner> Owners = estateContext.Owners.ToList();
            return View(Owners);
        }

        public ActionResult Index2()
        {
            List<Rent> Rents = estateContext.Rents.ToList();
            return View(Rents);
        }

        public ActionResult Index3()
        {
            List<Staff> Staffs = estateContext.Staffs.ToList();
            return View(Staffs);
        }
    }
}