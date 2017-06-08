<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apply.aspx.cs" Inherits="apply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Apply for grant</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Apply for your grant</h1>
         <table>
<tr>
    <td>Apply for grant</td>
    <td>
        <asp:TextBox ID="GrantTextBox" runat="server"></asp:TextBox></td>
</tr>
                <tr>
    <td>Grant Type</td>
    <td>
        <asp:DropDownList ID="DropDownGrantTypes" runat="server"></asp:DropDownList>   </td>
</tr>
             <tr>
    <td>Explanation</td>
    <td>
        <asp:TextBox ID="ExplanationTextBox" runat="server"></asp:TextBox></td>
</tr>
             <tr>
    <td>
        <asp:Button ID="SumitButton" runat="server" Text="Submit" OnClick="SumitButton_Click" /></td>
    <td>
        <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>
       
</tr>
             <tr> <td><asp:GridView ID="GridView1" runat="server"></asp:GridView></td></tr>
             </table>
       
    </div>
    </form>
</body>
</html>
