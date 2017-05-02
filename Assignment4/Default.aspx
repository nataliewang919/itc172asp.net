﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Log In</h1>
        <table>
            <tr>
                <td>Email</td>
<td>
    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
</td>
            </tr>
  <tr>
                <td>Password</td>
<td>
    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
</td>
            </tr>
<tr>

<td>
  <asp:Button ID="Button1" runat="server" Text="LogIn" OnClick="Button1_Click" /></td>
    <td>
        <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>

</tr>


        </table>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Registration.aspx">Register</asp:LinkButton>
    </div>
    </form>
</body>
</html>
