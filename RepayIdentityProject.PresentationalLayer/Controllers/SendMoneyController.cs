﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RepayIdentityProject.BusinessLayer.Abstract;
using RepayIdentityProject.DataAccessLayer.Concrete;
using RepayIdentityProject.DtoLayer.Dtos.CustomerAccountProcessDtos;
using RepayIdentityProject.EntityLayer.Concrete;

namespace RepayIdentityProject.PresentationalLayer.Controllers
{
    public class SendMoneyController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;
        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        [HttpGet]
        public IActionResult Index(string mycurrency)
        {
            ViewBag.currency = mycurrency;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var receiverAccountNumberID = context.CustomerAccounts.Where(x => x.CustomerAccountNumber == sendMoneyForCustomerAccountProcessDto.ReceiverAccountNumber).Select(y => y.CustomerAccountID).FirstOrDefault();

            var senderAccountNumberID=context.CustomerAccounts.Where(x=>x.AppUserID==user.Id).Where(y=>y.CustomerAccountCurrency=="Türk Lirası").Select(z=>z.CustomerAccountID).FirstOrDefault();


            var values = new CustomerAccountProcess();
            values.ProcessDate = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            values.SenderID = senderAccountNumberID;
            values.ProcessType = "Havale";
            values.ReceiverID = receiverAccountNumberID;
            values.Amount = sendMoneyForCustomerAccountProcessDto.Amount;
            values.Description = sendMoneyForCustomerAccountProcessDto.Description;

            _customerAccountProcessService.TInsert(values);

            //sendMoneyForCustomerAccountProcessDto.SenderID = user.Id;
            //sendMoneyForCustomerAccountProcessDto.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //sendMoneyForCustomerAccountProcessDto.ProcessType = "Havale";
            //sendMoneyForCustomerAccountProcessDto.ReceiverID = receiverAccountNumberID;

            //var values = new CustomerAccountProcess();
            //values.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //values.SenderID = user.Id;
            //values.ProcessType = "Havale";
            //values.ReceiverID = receiverAccountNumberID;
            //values.Amount = sendMoneyForCustomerAccountProcessDto.Amount;
            //context.CustomerAccountProcesses.Add(values);
            //context.SaveChanges();

            return RedirectToAction("Index", "Deneme");
        }

    }
}