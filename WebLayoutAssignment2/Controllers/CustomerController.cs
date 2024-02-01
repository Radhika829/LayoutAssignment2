using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLayoutAssignment2.Models;

namespace WebLayoutAssignment2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        static List<Customers> cus = new List<Customers>()
        {
          new Customers{CId=1,CName="Prashu",Salary=10000,Designation="HR" },
          new Customers{CId=2,CName="Raju",Salary=90000,Designation="Developer" },
          new Customers{CId=3,CName="John",Salary=80000,Designation="Manager" },
          new Customers{CId=4,CName="Manu",Salary=70000,Designation="Tester" },
        };
        public ActionResult Index()
        {
            ViewBag.msg = "Customers Home Page";
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["msg"] = "Success";
            return View(new Customers());
        }
        [HttpPost]
        public ActionResult Create(Customers cust)
        {
            if (ModelState.IsValid)
            {
                cus.Add(cust);
                TempData["tempmsg"] = " New Customer registration success";
                return RedirectToAction("Index");
            }
            else
            {
                return View(cust);
            }

            
        }
        
    }
}