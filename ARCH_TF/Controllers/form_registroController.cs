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
    public class form_registroController : Controller
    {
        private DB_HidrocarburosEntities db = new DB_HidrocarburosEntities();

        // GET: form_registro
        public ActionResult Index()
        {
            return View(db.form_registro.ToList());
        }

        // GET: form_registro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: form_registro/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_registro,cedula,nombres,apellido_paterno,apellido_materno,telefono,email,direccion,num_personas")] form_registro form_registro)
        {
            if (ModelState.IsValid)
            {
                db.form_registro.Add(form_registro);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(form_registro);
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
