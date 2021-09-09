using ARCH_TF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARCH_TF.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {

        private DB_HidrocarburosEntities db = new DB_HidrocarburosEntities();

        // GET: Usuario
        public ActionResult Index( string message = "")
        {
            ViewBag.Message = message;
            
            var email = User.Identity.Name;
            var user = db.usuario.FirstOrDefault(e => e.email == email);

            return View(user);
        }

        public ActionResult Solicitud()
        {
            var email = User.Identity.Name;
            var user = db.usuario.FirstOrDefault(e => e.email == email);
            return View(user);
        }

        [HttpPost]
        public ActionResult CrearSolicitud(string descripcion)
        {
            var email = User.Identity.Name;
            var user = db.usuario.FirstOrDefault(e => e.email == email);

            if (ModelState.IsValid)
            {
                try
                {
                    using (DB_HidrocarburosEntities db = new DB_HidrocarburosEntities())
                    {
                        formularios d = new formularios();
                        d.cedula_usuario = user.cedula_usuario;
                        d.tipo_formulario = 2;
                        d.descripcion = descripcion;

                        db.formularios.Add(d);
                        db.SaveChanges();

                        return RedirectToAction("Index", new { message = "Su formulario se ha enviado con exito" });
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            return View(user);
        }

        public ActionResult Quejas()
        {
            var email = User.Identity.Name;
            var user = db.usuario.FirstOrDefault(e => e.email == email);

            return View(user);
        }

        [HttpPost]
        public ActionResult CrearQueja(string descripcion)
        {
            var email = User.Identity.Name;
            var user = db.usuario.FirstOrDefault(e => e.email == email);

            if (ModelState.IsValid)
            {
                try
                {
                    using (DB_HidrocarburosEntities db = new DB_HidrocarburosEntities())
                    {
                        formularios d = new formularios();
                        d.cedula_usuario = user.cedula_usuario;
                        d.tipo_formulario = 3;
                        d.descripcion = descripcion;

                        db.formularios.Add(d);
                        db.SaveChanges();

                        return RedirectToAction("Index", new { message = "Su formulario se ha enviado con exito" });
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            return View(user);
        }
    }
}