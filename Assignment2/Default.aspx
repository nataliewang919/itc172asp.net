<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar of Events</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <h1>Calendar Events</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <p><asp:Label ID="Label1" runat="server" Text="" CssClass="result"></asp:Label></p>
    </div>
    </form>
</body>
</html>
