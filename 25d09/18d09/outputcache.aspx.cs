﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _18d09
{
    public partial class outputcache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }
        protected static String SinCache (HttpContext sc)
        { return String.Format("<h1>No cachea:{0}</h1>", DateTime.Now.ToString()); //Cache primera parte y refresca.
        }
    }
}