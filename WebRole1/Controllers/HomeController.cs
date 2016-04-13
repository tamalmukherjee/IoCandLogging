namespace WebRole1.Controllers
{
    using Microsoft.WindowsAzure.ServiceRuntime;
    using NLog;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var logger = LogManager.GetCurrentClassLogger();
            var theEvent = new LogEventInfo(LogLevel.Trace, RoleEnvironment.DeploymentId, "test log");
            //theEvent.Properties["subdomain"] = "testdomain";
            logger.Log(theEvent);

            return View();
        }
    }
}