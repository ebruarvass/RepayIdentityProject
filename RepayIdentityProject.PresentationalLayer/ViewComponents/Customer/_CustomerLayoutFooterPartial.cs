using Microsoft.AspNetCore.Mvc;

namespace RepayIdentityProject.PresentationalLayer.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
