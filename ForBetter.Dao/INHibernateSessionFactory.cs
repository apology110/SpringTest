using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forbetter.Dao
{
    interface INHibernateSessionFactory
    {
        NHibernate.ISessionFactory SessionFactory { set; get; }
    }
}
