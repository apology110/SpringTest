using System;

namespace Spring_Web_1
{
    public partial class index : System.Web.UI.Page
    {
        // 定义一个注入点
        public Framework Framework { set; get; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblFramework.Text = this.Framework.Name;
        }
    }
}