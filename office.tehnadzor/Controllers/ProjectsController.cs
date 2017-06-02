using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace office.tehnadzor.Controllers
{
    [Authorize(Users = "avelitch@sow.by,labkovich.mihail@gmail.com")]

    public class ProjectsController : Controller
    {
        // GET: projects
        public ActionResult Index()
        {
            return View();
        }
    }
}