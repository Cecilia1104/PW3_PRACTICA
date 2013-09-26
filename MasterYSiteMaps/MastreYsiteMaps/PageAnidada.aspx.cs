using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MastreYsiteMaps
{
    public partial class PageAnidada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        void Page_PreInit(object sender, EventArgs args)
        {
            this.MasterPageFile = "MasterPage2.master";
        }
    }
}