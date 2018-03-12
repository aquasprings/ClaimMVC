using ClaimAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaimAssignment.Controllers
{
    public class ClaimController : Controller
    {
        // GET: Claim
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Index(tblclaim1349205 t)
        {
            if (ModelState.IsValid)
            {
                DB01TEST01Entities d = new DB01TEST01Entities();
                ObjectParameter o = new ObjectParameter("cid", 0);
                d.sp_tblclaim_2(o, t.claimdesc, t.claimtype, t.claimstatus, t.mobno, t.empid);
                int id = (int)o.Value;
                Response.Write("<script>alert('Your Claim ID is-" + id + "')</script>");
                ViewBag.Status = "Active" ;
             
            }
            return View("Index");
        }

        public ActionResult viewclaim()
        {
            DB01TEST01Entities d = new DB01TEST01Entities();
            var data=d.sp_viewclaim_1();
            return View("viewclaim",data.ToList());
        }
             
        public ActionResult approve(int id)
        {
            DB01TEST01Entities d = new DB01TEST01Entities();
            d.sp_approve_1(id);
            
            return RedirectToAction("viewclaim");
        }

    }
}
