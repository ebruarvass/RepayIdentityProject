using Microsoft.AspNetCore.Mvc;

namespace RepayIdentityProject.PresentationalLayer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
