using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Jonathan Michaels", Id = 1},
                new Customer {Name = "Geroge Johnson", Id = 2}
            };
            

            return View();
        }
    }
}