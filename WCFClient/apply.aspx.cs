using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class apply : System.Web.UI.Page
{
    WCFReference.GrantReClient gc = new WCFReference.GrantReClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (!IsPostBack)
        {
            WCFReference.GrantType[] types = gc.GetTypes();
            DropDownGrantTypes.DataSource = types;
            DropDownGrantTypes.DataTextField = "GrantTypeName";
            DropDownGrantTypes.DataValueField = "GrantTypeKey";
            DropDownGrantTypes.DataBind();

        }
    }

    protected void SumitButton_Click(object sender, EventArgs e)
    {
        int key = (int)Session["userKey"];
        WCFReference.GrantRequest gre = new WCFReference.GrantRequest();
        gre.GrantRequestAmount = decimal.Parse(GrantTextBox.Text);
        gre.GrantRequestDate = DateTime.Now;
        gre.GrantRequestExplanation = ExplanationTextBox.Text;
        gre.GrantTypeKey = int.Parse(DropDownGrantTypes.SelectedValue.ToString());
        gre.PersonKey = key;

        bool result = gc.newGrant(gre);

        if (result)
        {
            WCFReference.GrantRequestInfo[] grf= gc.GetRequestGrantAmount(key);
            GridView1.DataSource = grf;
            GridView1.DataBind();
        }
        else
        {
            ResultLabel.Text = "Something wrong";

        }


    }
}