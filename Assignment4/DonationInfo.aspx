<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DonationInfo.aspx.cs" Inherits="DonationInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enter your Donation</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>DonationAmount<asp:TextBox ID="DAmountTextBox" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></p>
    </div>
    </form>
</body>
</html>



 
