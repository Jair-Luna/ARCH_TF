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
                var emple = db.empleado.FirstOrDefault(a => a.cedula_empleado == email && a.contrasenia_empleado == password);



                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.email, true);
                    return RedirectToAction("Index", "Usuario", user);
                }
                else if (emple != null)
                {
                    FormsAuthentication.SetAuthCookie(emple.cedula_empleado, true);
                    return RedirectToAction("IndexEm", "Empleados");
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