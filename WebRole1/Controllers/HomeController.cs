namespace WebRole1.Controllers
{
    using Logging;
    using Microsoft.WindowsAzure.ServiceRuntime;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        ILogger _logger;

        public HomeController(ILogger logger)
        {
            this._logger = logger;
        }

        // GET: Home
        public ActionResult Index()
        {
            _logger.LogTrace("test");

            return View();
        }

        [Route("just-a-test-page/{name?}")]
        public ActionResult TestPage(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}