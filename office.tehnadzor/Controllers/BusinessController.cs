using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace office.tehnadzor.Controllers
{
    [Authorize(Users = "avelitch@sow.by,labkovich.mihail@gmail.com")]
    public class businessController : Controller
    {
        // GET: business
        public ActionResult Index()
        {
            return View();
        }



        [ValidateInput(false)]
        public ActionResult FileManager2Partial()
        {
            return PartialView("~/Views/business/_FileManager2Partial.cshtml", businessControllerFileManager2Settings1.Model);
        }

        public FileStreamResult FileManager2PartialDownload()
        {
            return FileManagerExtension.DownloadFiles("FileManager2", businessControllerFileManager2Settings1.Model);
        }
    }
    public class businessControllerFileManager2Settings1
    {
        public const string RootFolder = @"~\Content\Файлы проекта";

        public static string Model { get { return RootFolder; } }
    }




}