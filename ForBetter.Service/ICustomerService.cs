using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forbetter.Service
{
    public interface ICustomerService
    {
        Forbetter.Dao.ICustomerDao CustomerDao { set; get; }
        IList<Domain.Customer> GetAllCustomers();
    }
}
