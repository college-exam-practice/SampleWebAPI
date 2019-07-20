using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClubDomain.Classes.ClubModels;
using MVCClub.Models;

namespace MVCClub.Controllers
{
    public class EventAttendnacesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EventAttendnaces
        public ActionResult Index()
        {
            var eventAttendances = db.EventAttendances.Include(e => e.associatedEvent).Include(e => e.memberAttending);
            return View(eventAttendances.ToList());
        }

        // GET: EventAttendnaces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventAttendnace eventAttendnace = db.EventAttendances.Find(id);
            if (eventAttendnace == null)
            {
                return HttpNotFound();
            }
            return View(eventAttendnace);
        }

        // GET: EventAttendnaces/Create
        public ActionResult Create()
        {
            ViewBag.EventID = new SelectList(db.ClubEvents, "EventID", "Venue");
            ViewBag.AttendeeMember = new SelectList(db.Members, "MemberID", "StudentID");
            return View();
        }

        // POST: EventAttendnaces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EventID,AttendeeMember")] EventAttendnace eventAttendnace)
        {
            if (ModelState.IsValid)
            {
                db.EventAttendances.Add(eventAttendnace);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventID = new SelectList(db.ClubEvents, "EventID", "Venue", eventAttendnace.EventID);
            ViewBag.AttendeeMember = new SelectList(db.Members, "MemberID", "StudentID", eventAttendnace.AttendeeMember);
            return View(eventAttendnace);
        }

        // GET: EventAttendnaces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventAttendnace eventAttendnace = db.EventAttendances.Find(id);
            if (eventAttendnace == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventID = new SelectList(db.ClubEvents, "EventID", "Venue", eventAttendnace.EventID);
            ViewBag.AttendeeMember = new SelectList(db.Members, "MemberID", "StudentID", eventAttendnace.AttendeeMember);
            return View(eventAttendnace);
        }

        // POST: EventAttendnaces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EventID,AttendeeMember")] EventAttendnace eventAttendnace)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventAttendnace).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventID = new SelectList(db.ClubEvents, "EventID", "Venue", eventAttendnace.EventID);
            ViewBag.AttendeeMember = new SelectList(db.Members, "MemberID", "StudentID", eventAttendnace.AttendeeMember);
            return View(eventAttendnace);
        }

        // GET: EventAttendnaces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventAttendnace eventAttendnace = db.EventAttendances.Find(id);
            if (eventAttendnace == null)
            {
                return HttpNotFound();
            }
            return View(eventAttendnace);
        }

        // POST: EventAttendnaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventAttendnace eventAttendnace = db.EventAttendances.Find(id);
            db.EventAttendances.Remove(eventAttendnace);
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
