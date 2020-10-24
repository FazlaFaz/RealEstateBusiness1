using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class OwnerController : Controller
    {
        private EstateContext estateContext = new EstateContext();
        // GET: Owner
        public ActionResult Index()
        {
            List<Owner> Owners = estateContext.Owners.ToList();
            return View(Owners);
        }

        public ActionResult OwnerDetails(string id)
        {
            Owner owner = estateContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Owner owner)
        {
            estateContext.Owners.Add(owner);
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}