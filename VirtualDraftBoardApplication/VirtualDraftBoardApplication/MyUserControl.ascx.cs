using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualDraftBoardApplication
{
    public partial class MyUserControl : System.Web.UI.UserControl
    {
        public string GetTextBoxValue()
        {
            return this.txtSomeTextBox.Text;
        }

        public string GetLabelValue()
        {
            return this.lblSomeLabel.Text;
        }

        public void SetTextBoxValue(string newText)
        {
            this.txtSomeTextBox.Text = newText;
        }

        public void SetLabelValue(string newText)
        {
            this.lblSomeLabel.Text = newText;
        }

    }
}