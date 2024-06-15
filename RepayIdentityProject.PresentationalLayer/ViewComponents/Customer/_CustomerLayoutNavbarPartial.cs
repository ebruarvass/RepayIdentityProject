using Microsoft.AspNetCore.Mvc;

namespace RepayIdentityProject.PresentationalLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
