using Microsoft.AspNetCore.Mvc;

namespace RepayIdentityProject.PresentationalLayer.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
