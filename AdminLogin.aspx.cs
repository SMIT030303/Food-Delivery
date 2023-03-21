using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

   protected void btnLogin_Click(object sender, EventArgs e)
    {
       if ((txtUsername.Text.Equals("Admin")) && (txtPass.Text.Equals("Admin123")))
            {
                Response.Redirect("~/AdminHome.aspx");
            }
    }

    private void clr()
    {
        txtPass.Text = string.Empty;
        txtUsername.Text = string.Empty;
        txtUsername.Focus();

    }

    
}