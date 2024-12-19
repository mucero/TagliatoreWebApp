using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TagliatoreWebApp.Models;
using System.Data.Entity;

namespace TagliatoreWebApp.Controllers
{
    public class UsersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            using (DbTagliatore context = new DbTagliatore())
            {
                return View(context.Meseros.ToList());
            }
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            using (DbTagliatore context = new DbTagliatore())
            {
                return View(context.Meseros.Where(x => x.id_mesero == id));
            }
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult Create(Meseros meseros)
        {
            try
            {
                using (DbTagliatore context = new DbTagliatore())
                {
                    context.Meseros.Add(meseros);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbTagliatore context = new DbTagliatore())
            {
                return View(context.Meseros.Where(x => x.id_mesero == id).FirstOrDefault());
            }
        }

        // POST: Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Meseros meseros)
        {
            try
            {
                using (DbTagliatore context = new DbTagliatore())
                {
                    context.Entry(meseros).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbTagliatore context = new DbTagliatore())
            {
                return View(context.Meseros.Where(x => x.id_mesero == id).FirstOrDefault());
            }
        }

        // POST: Orders/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var context = new DbTagliatore())
                {
                    Meseros meseros = context.Meseros.Where(x => x.id_mesero == id).FirstOrDefault();
                    context.Meseros.Remove(meseros);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
