using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vjezba2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistracija_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registracija.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}