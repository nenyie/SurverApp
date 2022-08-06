using Microsoft.AspNetCore.Mvc;

namespace SurveyApp.Api.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
