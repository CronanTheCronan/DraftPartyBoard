using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualDraftBoardApplication
{
    public partial class LeagueSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Name"] != null)
                lblLeagueName.Text = Session["Name"].ToString();
        }
    }
}