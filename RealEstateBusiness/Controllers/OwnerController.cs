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

        public ActionResult Detail(string id)
        {
            Owner owner = estateContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }
        public ActionResult Edit(string id)
        {
            Owner owner = estateContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            ViewBag.OwnerDetails = new SelectList(estateContext.Owners, "OwnerNo", "OwnerNo");
            return View(owner);
        }

        [HttpPost]
        public ActionResult Edit(string id, Owner updatedOwner)
        {
            Owner owner = estateContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            owner.OwnerNo = updatedOwner.OwnerNo;
            owner.Fname = updatedOwner.Fname;
            owner.Lname = updatedOwner.Lname;
            owner.Address = updatedOwner.Address;
            owner.TelNo = updatedOwner.TelNo;
            estateContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            Owner owner = estateContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletedOwner(string id)
        {
            Owner owner = estateContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            estateContext.Owners.Remove(owner);
            estateContext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}