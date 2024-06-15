﻿using RepayIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepayIdentityProject.DataAccessLayer.Abstract
{
    public interface ICustomerAccountDal:IGenericDal<CustomerAccount>
    {
        List<CustomerAccount> GetCustomerAccountsList(int id);
    }
}