using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualDraftBoardApplication
{
    public partial class DraftBoard : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext dataContext = new SampleDataContext();

            if (!IsPostBack)
            {
                ddlTeamSelect.DataSource = from team in dataContext.Teams
                                           select team.team_name;

                ddlTeamSelect.DataBind();

                ddlPositionSelect.DataSource = from position in dataContext.Positions
                                               orderby position.position_id
                                               select position.position_name;

                ddlPositionSelect.DataBind();


                GridView1.DataSource = from player in dataContext.Players
                                       where player.team_id == 1
                                       orderby player.last_name ascending
                                       select player;

                GridView1.DataBind();

            }

        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            int newTeam = ddlTeamSelect.SelectedIndex + 1;
            int newPosition = ddlPositionSelect.SelectedIndex + 1;

            SampleDataContext sdc = new SampleDataContext();

            GridView1.DataSource = from player in sdc.Players
                                   from position in sdc.Positions
                                   from team in sdc.Teams
                                   where player.team_id == team.team_id && player.position_id == position.position_id
                                    && player.team_id == newTeam
                                    && player.position_id == newPosition
                                   orderby player.last_name ascending
                                   select new
                                   {
                                       player.last_name,
                                       player.first_name,
                                       position.position_name,
                                       team.team_name
                                   };

            GridView1.DataBind();
        }
    }
}