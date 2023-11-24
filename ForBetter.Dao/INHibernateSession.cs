using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbetter.Dao
{
    public interface INHibernateSession
    {
        NHibernate.ISession Session{ set; get; }
    }
}
