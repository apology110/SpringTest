using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sprint_Web_1.Customer
{
    public partial class index : System.Web.UI.Page
    {
        public Forbetter.Service.ICustomerService CustomerService { set; get; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                IList<Forbetter.Domain.Customer> list = this.CustomerService.GetAllCustomers();
                this.gvCustomer.DataSource = list;
                this.gvCustomer.DataBind();
            }
        }
    }
}