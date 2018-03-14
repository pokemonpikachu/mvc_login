using login1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace login1.Controllers
{
    public class leaveController : Controller
    {
        // GET: leave
        public ActionResult login()
        {
            return View();
        }
        DB01TEST01Entities db = new DB01TEST01Entities();
        [HttpPost]
        public ActionResult Login(login_328 l)
        {
            if (ModelState.IsValid)
            {
                
                   var obj = db.login_328.Where(a => a.username.Equals(l.username) && a.pwd.Equals(l.pwd)).FirstOrDefault();
                   var obj2 = db.login_328.ToList();
                   ViewBag.Table = obj2;
                if (obj != null)
                {
                    foreach (var v in ViewBag.Table)
                    {
                        if ((obj.id == v.supid))
                            return RedirectToAction("welcome");                       
                    }
                }
                
                    Response.Write("<script>alert('access denied')</script>");

            }
            return View(l);
        }


        public ActionResult welcome()
        {

            return View();
        }

    
    }
}
