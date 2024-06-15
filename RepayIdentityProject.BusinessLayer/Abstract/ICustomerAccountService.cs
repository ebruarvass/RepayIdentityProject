using RepayIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepayIdentityProject.BusinessLayer.Abstract
{
    public interface ICustomerAccountService:IGenericService<CustomerAccount>
    {
        public List<CustomerAccount> GetCustomerAccountsList(int id);
    }
}
