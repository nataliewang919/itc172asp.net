<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Login</h1>
        <table>
            <tr>
<td>User Name</td>
<td>
    <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox></td>
            </tr>
<tr>
<td>Password</td>
<td>
    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox></td>
            </tr>
<tr>
<td>
    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></td>
<td>
    <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label>
</td>
            </tr>

        </table>
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">Register</asp:LinkButton><br />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/GetBooks.aspx">GetBooks</asp:LinkButton>
    </form>
</body>
</html>
