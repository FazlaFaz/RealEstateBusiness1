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
            List<Branch> branches = estateContext.Branches.ToList();
            return View(branches);
        }
    }
}