using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ARCH_TF.Models;

namespace ARCH_TF.Controllers
{
    public class estado_cocheController : Controller
    {
        private DB_HidrocarburosEntities db = new DB_HidrocarburosEntities();

        // GET: estado_coche
        public ActionResult Index()
        {
            return View(db.estado_coche.ToList());
        }

        // GET: estado_coche/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estado_coche estado_coche = db.estado_coche.Find(id);
            if (estado_coche == null)
            {
                return HttpNotFound();
            }
            return View(estado_coche);
        }

        // GET: estado_coche/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: estado_coche/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_estado_coche,nombre_estado")] estado_coche estado_coche)
        {
            if (ModelState.IsValid)
            {
                db.estado_coche.Add(estado_coche);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estado_coche);
        }

        // GET: estado_coche/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estado_coche estado_coche = db.estado_coche.Find(id);
            if (estado_coche == null)
            {
                return HttpNotFound();
            }
            return View(estado_coche);
        }

        // POST: estado_coche/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_estado_coche,nombre_estado")] estado_coche estado_coche)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estado_coche).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estado_coche);
        }

        // GET: estado_coche/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estado_coche estado_coche = db.estado_coche.Find(id);
            if (estado_coche == null)
            {
                return HttpNotFound();
            }
            return View(estado_coche);
        }

        // POST: estado_coche/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            estado_coche estado_coche = db.estado_coche.Find(id);
            db.estado_coche.Remove(estado_coche);
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
