using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        //method to perform logic on user input, below
        public double CalculateQuote(Insuree insuree) 
        {
            using (InsuranceEntities db = new InsuranceEntities())  //using statement, db connection is "unmanaged", so "using" wrap makes connection close and dispose of right away
            {
                var quote = 50; //base fee of 50
                var UserAge = new DateTime(DateTime.Now.Subtract(Convert.ToDateTime(insuree.DateOfBirth)).Ticks).Year - 1; //user age, calculate age...?
               
            if (UserAge <= 18) //if user is 18 or under
                {
                    quote += 100; //add 100 to base fee
                }
                else if (UserAge >= 19 && UserAge <= 25) //if user 19 to 25
                {
                    quote += 50; //add 50
                }
                else if (UserAge >= 26) //if user 26 or older
                {
                    quote += 25; //add 25
                }

                if (insuree.CarYear < 2000 || insuree.CarYear > 2015) //if car year is before 2000 OR after 2015
                {
                    quote += 25; //add $25
                }
                if (insuree.CarMake == "Porsche") //if car make is a Porsche
                {
                    quote += 25; //add $25
                }
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") //if car is a 911 Porsche Carrera
                {
                    quote += 50; //add $50
                }
                //take number of speeding tickets, x by 10 to add $10 for each ticket
                quote += Convert.ToInt32(insuree.SpeedingTickets) * 10;
                
                if (Convert.ToBoolean(insuree.DUI == true)) //if DUI field is checked
                {
                    quote += (int)(quote * .25); //add 25%
                }               
                if (Convert.ToBoolean(insuree.CoverageType == true)) //if coverage is full
                {
                    quote += (int)(quote * .5); //add 50%
                }
                return quote; //based on above logic, return final quote to user
            }
        }

        public ActionResult Admin() //admin view to see users and their quotes
        {
            List<Insuree> listInsuree = new List<Insuree>();
            foreach (var insuree in db.Insurees.ToList())
            {
                Insuree insured = new Insuree(); //create new insured client row
                insured.FirstName = insuree.FirstName; //with first name
                insured.LastName = insuree.LastName; //with last name
                insured.EmailAddress = insuree.EmailAddress; //with email address
                insured.Quote = insuree.Quote; //and their total quote
                listInsuree.Add(insured); //add this person to the listInsuree created above
            }
            return View(listInsuree); //can be viewed
        }

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        //THIS WAS MODIFIED
        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid) //if all fields are a pass
            {
                double quote = CalculateQuote(insuree); //call method to calculate quote
                insuree.Quote = Convert.ToDecimal(quote); //quote of particular insuree is converted to decimal
                db.Insurees.Add(insuree); //add to list
                db.SaveChanges(); //save changes to the db
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }


        //THIS WAS MODIFIED
        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                double quote = CalculateQuote(insuree);
                insuree.Quote = Convert.ToDecimal(quote);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
