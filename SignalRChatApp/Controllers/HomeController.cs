
using System.Web.Mvc;

namespace SignalRChatApp.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            Chat();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}
