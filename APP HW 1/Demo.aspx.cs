using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP_HW_1
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DemoTest t = new DemoTest();
            Response.Write(t.Fname + " " + t.Lname);
        }
    }
}