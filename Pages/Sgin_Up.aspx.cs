﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Sgin_Up : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void sign_in_Click(object sender, EventArgs e)
    {
        Response.Redirect("Sign_In.aspx");
    }
}   