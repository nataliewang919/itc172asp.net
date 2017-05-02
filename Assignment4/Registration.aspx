<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  <table>
        <tr>
<td>Last Name</td>
<td>
    <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="LastNameTextBox">
                </asp:RequiredFieldValidator>
            </td>
        </tr>
                <tr>
<td>First Name</td>
<td>
    <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
</td>
            <td></td>
        </tr>
              
                <tr>
<td>Email</td>
<td>
    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
</td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"  ControlToValidate="EmailTextBox" ErrorMessage ="Email is required" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>       
            </td>
        </tr>
                <tr>
<td>Password</td>
<td>
    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" Password is Required" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator></td>
        </tr>
                <tr>
<td>Confirm Password</td>
<td>
    <asp:TextBox ID="ConfirmTextBox" runat="server"></asp:TextBox>
</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" Confirm Password Required" ControlToValidate="ConfirmTextBox"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage=" Password do not match" ControlToValidate="ConfirmTextBox" ControlToCompare="PasswordTextBox"></asp:CompareValidator></td>
        </tr>

                <tr>
<td>Apt Number</td>
<td>
    <asp:TextBox ID="AptNumTextBox" runat="server"></asp:TextBox>
</td>
            <td></td>
        </tr>

    <tr>
<td>Street</td>
<td>
    <asp:TextBox ID="StreetTextBox" runat="server"></asp:TextBox>
</td>
            <td></td>
        </tr>
  
        <tr>
<td>City</td>
<td>
    <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox>
</td>
            <td></td>
        </tr>
      
        <tr>
<td>State</td>
<td>
    <asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox>
</td>
            <td></td>
        </tr>  
      
  <tr>
<td>Zip</td>
<td>
    <asp:TextBox ID="ZipTextBox" runat="server"></asp:TextBox>
</td>
            <td></td>
        </tr>  
      
      <tr>
<td>Home Phone</td>
<td>
    <asp:TextBox ID="HomePhoneTextBox" runat="server"></asp:TextBox>
</td>
            <td></td>
        </tr>   
      
      <tr>
<td>Work Phone</td>
<td>
    <asp:TextBox ID="WorkPhoneTextBox" runat="server"></asp:TextBox>
</td>
            <td></td>
        </tr>               
                <tr>
<td>
    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></td>
<td>
    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
</td>
           
        </tr>
    </table>  
    </div>
    </form>
</body>
</html>
