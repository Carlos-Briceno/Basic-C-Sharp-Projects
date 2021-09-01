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

        public ActionResult Breakdown(int? id)
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

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageTypes,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);

            //Age

            public decimal CalculateQuote(Insuree insuree)
        {

                var DOB = insuree.DateOfBirth.Year;
                int adjust = DOB + DOB;
                int currentYear = DateTime.Now.Year;
                int age = adjust - currentYear;
                int intial = 50;
                string me = "o";
                int yearlyTotal;
                if (insuree.Quote >= 0)
            {
                if (age > 1)
                {
                    //Age
                    //18 or under adds $100 a month 
                    if (age <= 18)
                    {
                        intial += 100;
                    }

                    // 19-25 adds $50 a month 
                    if (Enumerable.Range(19, 25).Contains(age))
                    {
                        intial += 50;
                    }
                    // 25 or older adds $25 na month 
                    if (age >= 25)
                    {
                        intial += 25;
                    }
                }

                if (insuree.CarYear > 0)
                {
                    // Car Year
                    if (insuree.CarYear < 2000)
                    {
                        intial += 25;
                    }
                    if (insuree.CarYear > 2015)
                    {
                        intial += 25;
                    }
                }
                if (insuree.CarMake.Length > me.Length)
                {
                    if (insuree.CarMake == "Porsche")
                    {
                        intial += 25;
                    }
                    if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                    {
                        intial += 25;
                    }
                }

                // Speeding tickets
                if (insuree.SpeedingTickets > 0)
                {
                    intial += insuree.SpeedingTickets * 10;
                }

                // DUI
                if (insuree.DUI == true)
                {
                    intial += intial / 4;
                }

                // Coverage
                if (insuree.CoverageTypes == true)
                {
                    intial += intial / 2;
                    yearlyTotal = intial * 12;
                    insuree.Quote = yearlyTotal;
                }
                if (insuree.CoverageTypes == false)
                {
                    yearlyTotal = intial * 12;
                    insuree.Quote = yearlyTotal;
                }
                    return insuree.Quote;

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

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageTypes,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
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
