using System.Web.Mvc;

namespace Laboratorio181.Controllers {
    public class AccessController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public ActionResult Verify(string email, string password) {
            if(email=="admin@test.com" && password=="1234")
                return Json(new { ok=true });
            return Json(new { ok=false });
        }
    }
}
