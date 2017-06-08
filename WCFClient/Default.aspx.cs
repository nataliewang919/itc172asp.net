using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SumitButton_Click(object sender, EventArgs e)
    {
        WCFReference.GrantReClient gc = new WCFReference.GrantReClient();

        int result = gc.Login(UserTextBox.Text, PasswordTextBox.Text);

        if(result!=0)
        {
            Session["userKey"] = result;
            ResultLabel.Text = "Welcome"+result.ToString();
            Response.Redirect("apply.aspx");
        }
        else
        {
            ResultLabel.Text = "Invalid Login";
        }
    }
}