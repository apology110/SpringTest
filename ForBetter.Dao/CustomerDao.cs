using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate.Linq;

namespace Forbetter.Dao
{
    [Spring.Stereotype.Repository]
    public class CustomerDao
        : ICustomerDao, INHibernateSessionFactory
    {
        // Nhibernate 会话支持
        public NHibernate.ISessionFactory SessionFactory { set; get; }

        public IQueryable<Domain.Customer> GetAllCustomers()
        {
            NHibernate.ISession session = this.SessionFactory.OpenSession();

            var query = session.Query<Domain.Customer>();

            var result = from customer in query
                         orderby customer.CompanyName
                         select customer;
            return result;
        }
    }
}
