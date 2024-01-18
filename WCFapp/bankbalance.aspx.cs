using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFapp
{
    public partial class bankbalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bankservice.ServiceClient obj = new bankservice.ServiceClient();
           string b= obj.Balance(TextBox1.Text);
            Label1.Text = b;
        }
    }
}