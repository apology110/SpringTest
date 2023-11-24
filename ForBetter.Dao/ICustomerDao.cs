using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forbetter.Dao
{
    public interface ICustomerDao
    {
        IQueryable<Domain.Customer> GetAllCustomers();
    }
}
