using Microsoft.AspNetCore.Mvc;

namespace RepayIdentityProject.PresentationalLayer.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
