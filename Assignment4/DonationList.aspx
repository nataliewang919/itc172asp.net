﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DonationList.aspx.cs" Inherits="DonationList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donation Summary</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
    </div>
    </form>
</body>
</html>


