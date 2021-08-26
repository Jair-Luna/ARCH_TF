using ARCH_TF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ARCH_TF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Actuar y cumplir su misión con equidad.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página para contactarnos.";

            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                DB_HidrocarburosEntities db = new DB_HidrocarburosEntities();
                var user = db.usuario.FirstOrDefault(e => e.email == email && e.contrasenia_usuario == password);

                if(user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.email, true);
                    return RedirectToAction("Index", "Usuario");
                }
                else
                {
                    return RedirectToAction("Index", new { message = "Usuario o Contraseña Incorrectos" });
                }
            }
            else
            {
                return RedirectToAction("Index", new { message = "Llene el formulario para poder iniciar sesión" });
            }
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}