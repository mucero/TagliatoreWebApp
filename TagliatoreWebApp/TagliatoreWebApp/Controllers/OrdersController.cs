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
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            using (DbTagliatore context = new DbTagliatore())
            {
                return View(context.Ordenes.ToList());
            }
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            using (DbTagliatore context = new DbTagliatore())
            {
                return View(context.Ordenes.Where(x => x.id_orden == id));
            }
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult Create(Ordenes ordenes)
        {
            try
            {
                using (DbTagliatore context = new DbTagliatore())
                {
                    context.Ordenes.Add(ordenes);
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
                return View(context.Ordenes.Where(x => x.id_orden == id).FirstOrDefault());
            }
        }

        // POST: Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ordenes ordenes)
        {
            try
            {
                using (DbTagliatore context = new DbTagliatore())
                {
                    context.Entry(ordenes).State = EntityState.Modified;
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
                return View(context.Ordenes.Where(x => x.id_orden == id).FirstOrDefault());
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
                    Ordenes ordenes = context.Ordenes.Where(x => x.id_orden == id).FirstOrDefault();
                    context.Ordenes.Remove(ordenes);
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
