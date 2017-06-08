using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        
        string last = LastNameTextBox.Text;
        string first = FirstNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;
        string aptnum = AptNumTextBox.Text;
        string street = StreetTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string zip = ZipTextBox.Text;
        string homephone = HomePhoneTextBox.Text;
        string workphone = WorkPhoneTextBox.Text;

        WCFReference.GrantReClient gc = new WCFReference.GrantReClient();
        
        bool result = gc.RegisterUser(last, first, email, password, aptnum, street, city, state, zip,
        homephone, workphone); 
        if (result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Something wrong";

        }
    }
}