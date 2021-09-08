using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARCH_TF.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult IndexEm()
        {
            return View();
        }
    }
}