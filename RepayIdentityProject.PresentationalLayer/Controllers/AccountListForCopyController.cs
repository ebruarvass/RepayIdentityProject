using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RepayIdentityProject.BusinessLayer.Abstract;
using RepayIdentityProject.DataAccessLayer.Abstract;
using RepayIdentityProject.DataAccessLayer.Concrete;
using RepayIdentityProject.EntityLayer.Concrete;

namespace RepayIdentityProject.PresentationalLayer.Controllers
{
    public class AccountListForCopyController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountService _customerAccountService;

        public AccountListForCopyController(UserManager<AppUser> userManager, ICustomerAccountService customerAccountService)
        {
            _userManager = userManager;
            _customerAccountService = customerAccountService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();
            var values = _customerAccountService.GetCustomerAccountsList(user.Id);
            return View(values);
        }
    }
}
