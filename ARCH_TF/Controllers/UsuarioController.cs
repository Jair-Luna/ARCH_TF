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
        public ActionResult Index()
        {
            var email = User.Identity.Name;
            var user = db.usuario.FirstOrDefault(e => e.email == email);

            return View(user);
        }

    }
}