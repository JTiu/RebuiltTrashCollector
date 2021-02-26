using DraftTrashCollector.Data;
using DraftTrashCollector.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DraftTrashCollector.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomerController : Controller
    { 

        private ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context) 
        {
            _context = context;
        }
    

        // GET: CustomerController
        public ActionResult Index()
        {

            //whenever someone registers as a customer or logs in as a customer, they will be routed to this action
            //they are not a customer object yet if they have just registered, they are just a user
            //how do we know who this user is?
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //how can we find out if they exist in the customer table? need to query customer table

            //if they exist in the customer table, what do we want to do?
            //what if they don't exist in the customer table?

            //these steps might require us routing to other actions or other views
            //don't want a collection?
            //Console.WriteLine("went into the index action");
      
            return View(/*_context.Customer.ToList()*/);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Customer personFromDatabase = _context.Customer.Where(customer => customer.IdentityUserId == userId).SingleOrDefault();
            if(personFromDatabase == null)
            {
                return RedirectToAction("Create");
            }
            return View(personFromDatabase);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer Customer)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                Customer.IdentityUserId = userId;
                _context.Customer.Add(Customer);
               _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
                //small change to test github
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
