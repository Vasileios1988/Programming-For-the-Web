using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SET11105_CW2.Data;
using SET11105_CW2.Models;

namespace SET11105_CW2.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext db;

        private readonly ILogger<HomeController> _logger;

        //we need to make DBContext accessible from each controller so we add it to the controller class and setting it throught the constructor
        public HomeController(ILogger<HomeController> logger, MyDbContext db)
        {
            this.db = db;
            _logger = logger;
        }

        // we bind cause objects to a list which will use in the index.cshtml in order to show our page and date on html
        public IActionResult Index()
        {
            var causes = db.cause.ToList();
            return View(causes);
            

           
        }

            // show the page 
            public IActionResult CreateCause()
        {
            return View();
        }

        // we need to get the data from the user in order to pass it and store it to the database
        [HttpPost]
        public IActionResult CreateCause(Cause cause)
        {
            this.db.cause.Add(cause);

            try
            {
                this.db.SaveChanges();
            }

            catch (DbUpdateException exc)

            {
                Console.WriteLine(exc.Message, "Error");
            }


            return View(cause);
        }

        // SHOW LOG IN PAGE
            public IActionResult LogIn()
        {
            return View();
        }

        // SHOW SIGN UP PAGE
        public IActionResult SignUp()
        {
            

            return View();
        }

        // GET DATA FROM SIGN UP FORM AND STORE THEM INTO DATABSE
        [HttpPost]
        public IActionResult SignUp(Member member)
        {
            //we are adding a member object to the database
            this.db.member.Add(member);

            try{
                this.db.SaveChanges();
            }

        catch (DbUpdateException exc)

            {
                Console.WriteLine(exc.Message, "Error");
            }
            

            return View(member);
        }

        private object SaveChanges()
        {
            throw new NotImplementedException();
        }

        // SHOW VIEW CAUSES PAGE
        public IActionResult ViewCauses()
        {
            var causes = db.cause.ToList();
            return View(causes);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

