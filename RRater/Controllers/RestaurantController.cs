using RRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RRater.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDbContext _context = new RestaurantDbContext();

        // GET: Restaurant/Index
        public ActionResult Index()
        {
            return View(_context.Restaurants.ToList()); ;
        }

        // Get: Restaurant/Create

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _context.Restaurants.Add(restaurant);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurant);

        }

        // GET: Restaurant/Delete/{id}

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Restaurant restaurant = _context.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }

            return View(restaurant);
        }

        // POST Restaurant/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Restaurant restaurant = _context.Restaurants.Find(id);
            _context.Restaurants.Remove(restaurant);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: Restaurant/Edit/{id}
        // Get and id fromt he user
        // Handle if the id is null
        // Find a Restaurant by that id
        // If it does not exist return the restaurant and the view


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Restaurant restaurant = _context.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }



        // POST: Restaurant/Edit/{id}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(restaurant).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurant);
        }


        // GET: Restaurant/Details/{id}

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Restaurant restaurant = _context.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);

        }

    }



}