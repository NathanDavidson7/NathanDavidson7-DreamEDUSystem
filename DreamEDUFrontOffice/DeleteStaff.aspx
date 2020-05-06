<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 233px; width: 493px">
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
