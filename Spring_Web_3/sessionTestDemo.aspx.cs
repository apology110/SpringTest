using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sprint_Web_1
{
    public partial class sessionTestDemo : System.Web.UI.Page
    {
        public NHibernate.ISession NHibernateSession { set; get; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblMessage.Text = this.NHibernateSession.IsOpen ?
                            "Nhibernate Session is Opened" :
                            "Error";
        }
    }
}