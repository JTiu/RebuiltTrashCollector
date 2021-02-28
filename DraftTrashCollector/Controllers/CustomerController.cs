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
            Customer personFromDatabase = _context.Customer.Where(customer => customer.IdentityUserId == userId).FirstOrDefault();
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
        //Once user hits "Create" button - Customer into line 68
        public ActionResult Create(Customer customer)
        {
            try
            {
                //Find the ASP Identity User ID
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                //Link that ASP Identity User Id to the Customer object that was passed in
                customer.IdentityUserId = userId;

                //Add user to the database - row is added to the customer table
                _context.Customer.Add(customer);
               _context.SaveChanges();

                //Redirect them to desired page (this needs fixing)
                return RedirectToAction(nameof(Details));
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
            //Find user in database 
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Customer personFromDatabase = _context.Customer.Where(customer => customer.IdentityUserId == userId).FirstOrDefault();

            //Return the view and inject Customer into view 
            //Does this view accept whatever I am passing in? In order to check - go to .cshtml file and see what model is passed in
            return View(personFromDatabase);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                //Steps for what we want

                //Step 1 Create a new Customer object and fill out properties from the Form
                Customer customer = new Customer();
                customer.FirstName = collection["FirstName"];
                customer.LastName = collection["LastName"];
                customer.StreetAddress = collection["StreetAddress"];
                customer.PickUpDay = collection["PickUpDay"];

                //The form is returning a string date. customer.ExtraPickupDay is a DateTime - we need to convert 
                //the string date from the form into a DateTime object
                //Stack overflow where solution was found: https://stackoverflow.com/questions/919244/converting-a-string-to-datetime
                //Simple explanation: the form is giving you a string - you are turning that string into a DateTime because ExtraPickup day is a DateTime property
                var formDate = DateTime.Parse(collection["ExtraPickupDay"]);
                customer.ExtraPickupDay = formDate;

                //This lets the Update method know which customer to Update
                customer.Id = id;

                //Grab ASP Identity ID and tie it to Customer record we are building
                customer.IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                //Step 2: Save Customer object to the database
                //We want to update the customer information based on ASP Identity user ID
                _context.Customer.Update(customer);
                _context.SaveChanges();

                //Step 3: Redirect them to the details page 
                return RedirectToAction(nameof(Details));
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("An exception ({0}) occurred.",
                                  e.GetType().Name);
                Console.WriteLine("Message:\n   {0}\n", e.Message);
                Console.WriteLine("Stack Trace:\n   {0}\n", e.StackTrace);
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            //Find user in database 
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Customer personFromDatabase = _context.Customer.Where(customer => customer.IdentityUserId == userId).FirstOrDefault();

            //Return the view and inject Customer into view 
            //Does this view accept whatever I am passing in? In order to check - go to .cshtml file and see what model is passed in
            return View(personFromDatabase);
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
