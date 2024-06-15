using RepayIdentityProject.DataAccessLayer.Abstract;
using RepayIdentityProject.DataAccessLayer.Concrete;
using RepayIdentityProject.DataAccessLayer.Repositories;
using RepayIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepayIdentityProject.DataAccessLayer.EntityFramework
{
    public class EfCustomerAccountDal: GenericRepository<CustomerAccount>, ICustomerAccountDal
    {   
        public List<CustomerAccount> GetCustomerAccountsList(int id)
        {
            using var context = new Context();
            var values=context.CustomerAccounts.Where(x=>x.AppUserID==id).ToList();
            return values;
        }
    }
}
