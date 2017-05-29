using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Somebody" },
                new Customer { Id = 2, Name = "Once" },
                new Customer { Id = 3, Name = "Told Me" }
            };

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            return View();
            //return Content(""+id+"");
        }
    }
}