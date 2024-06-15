using Microsoft.EntityFrameworkCore;
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
    public class EfCustomerAccountProcessDal : GenericRepository<CustomerAccountProcess>, ICustomerAccountProcessDal
    {
        public List<CustomerAccountProcess> MyLastProcess(int id)
        {
            using var context = new Context();
            var values = context.CustomerAccountProcesses.Include(y=>y.SenderCustomer).Include(w=>w.ReceiverCustomer).ThenInclude(z=>z.AppUser).Where(x=>x.ReceiverID == id || x.SenderID == id).ToList();
            return values;
        }
    }
}
