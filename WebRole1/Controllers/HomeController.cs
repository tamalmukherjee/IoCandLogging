namespace WebRole1.Controllers
{
    using NLog;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Warn("test warning");

            return View();
        }
    }
}