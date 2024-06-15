using Microsoft.AspNetCore.Mvc;

namespace RepayIdentityProject.PresentationalLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
