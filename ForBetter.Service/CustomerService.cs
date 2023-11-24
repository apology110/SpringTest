using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forbetter.Service
{
    [Spring.Stereotype.Service]
    [Spring.Transaction.Interceptor.Transaction(ReadOnly=true)]
    public class CustomerService
        :ICustomerService
    {
        public Forbetter.Dao.ICustomerDao CustomerDao { set; get; }

        public IList<Domain.Customer> GetAllCustomers()
        {
            IQueryable<Domain.Customer> query = this.CustomerDao.GetAllCustomers();
            return query.ToList<Domain.Customer>();                    
        }
    }
}
