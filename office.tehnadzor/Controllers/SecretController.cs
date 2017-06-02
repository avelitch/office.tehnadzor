using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace office.tehnadzor.Controllers
{
    public class SecretController : Controller
    {

        [Authorize]
        public ContentResult Secret()
        {
            return Content("Информация недоступна без регистрации");
        }
        public ContentResult Overt()
        {
            return Content("Доступ без регистрации");
        }
    }
}