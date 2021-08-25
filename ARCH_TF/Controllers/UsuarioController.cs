using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARCH_TF.Controllers
{
    
    public class UsuarioController : Controller
    {

        // GET: Usuario
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}