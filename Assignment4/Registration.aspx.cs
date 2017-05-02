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

        Community_AssistEntities db = new Community_AssistEntities();
        int result = db.usp_Register(last, first, email, password,aptnum,street,city,state,zip,homephone,workphone);

        if (result != -1)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Something went terribly wrong";
        }
    }
}