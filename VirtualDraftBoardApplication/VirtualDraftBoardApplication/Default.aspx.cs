using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualDraftBoardApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem noSelection = new ListItem("--", "0");
            ddlNumberOfTeams.Items.Add(noSelection);

            for(int i = 0; i < 30; i++)
            {
                string currentNumber = (i + 1).ToString();
                string currentValue = currentNumber;
                ListItem selection = new ListItem(currentNumber, currentValue);
                ddlNumberOfTeams.Items.Add(selection);    
            }

            
        }

        protected void btnLeagueInit_Click(object sender, EventArgs e)
        {
            int n = ddlNumberOfTeams.SelectedIndex;

            if(n == 0)
            {
                //Logic to tell user that they need to make a correct selection
            }
            else
            {
                for(int i = 0; i < n; i++)
                {
                    DropDownList ddlPlayerStatus = new DropDownList();
                    ddlPlayerStatus.ID = "ddlPlayerStatus" + (i + 1);
                    ListItem noSelection = new ListItem("--", "0");
                    ListItem atTheParty = new ListItem("At the party", "1");
                    ListItem draftingRemote = new ListItem("Drafting Remotely", "2");
                    ListItem autoDraft = new ListItem("AutoDraft", "3");

                    ddlPlayerStatus.Items.Add(noSelection);
                    ddlPlayerStatus.Items.Add(atTheParty);
                    ddlPlayerStatus.Items.Add(draftingRemote);
                    ddlPlayerStatus.Items.Add(autoDraft);

                    Label playerLabel = new Label();
                    TextBox playerTextBox = new TextBox();
                    playerLabel.ID = "lblPlayer" + (i + 1);
                    playerLabel.Text = "Player " + (i + 1);
                    playerLabel.CssClass = "playerLabel";
                    playerTextBox.ID = "txtPlayer" + (i + 1);
                    playerTextBox.CssClass = "txtPlayer";
                    Panel1.Controls.Add(playerLabel);
                    Panel1.Controls.Add(playerTextBox);
                    Panel1.Controls.Add(ddlPlayerStatus);

                    Panel1.Controls.Add(new LiteralControl("<br />"));
                }
            }

            Session["Name"] = txtLeagueName.Text;
            Response.Redirect("~/LeagueSetup.aspx");
            btnLeagueInit.Visible = false;
        }

        //protected void ddlNumberOfTeams_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int n = ddlNumberOfTeams.SelectedIndex + 4;

        //    for (int i = 0; i < 20; i++)
        //    {
        //        Label playerLabel = new Label();
        //        TextBox TB = new TextBox();
        //        playerLabel.ID = "lblPlayer" + (i) ;
        //        playerLabel.Text = "Player " + (i);
        //        Panel1.Controls.Add(playerLabel);
        //        Panel1.Controls.Add(TB);
        //        Panel1.Controls.Add(new LiteralControl("<br />"));
        //    }
        //}
    }
}