﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class Login : System.Web.UI.Page
{

    WebServiceSoapClient proxy = new WebServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        int Id = proxy.chklogin(txtuname.Text, txtpassword.Text);

        if (Id == 0)
        {
            string msg = "<script>alert('Invalid username or password')</script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", msg, false);
        }
        else
        {
            //string msg = "<script>alert('Successfully Logged In')</script>";
            //ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", msg, false);
                Session["Id"] = Id;
                Response.Redirect("Default3.aspx");
           

        }
    }
}