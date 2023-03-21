using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Security.Claims;

protected void btnlogout_Click(object sender, EventArgs e)
{
    //Session.Abandon();
    Session["Username"] = null;
    Response.Redirect("~/Default.aspx");

}