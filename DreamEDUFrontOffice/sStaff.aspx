<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sStaff.aspx.cs" Inherits="sStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 362px">
            sID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sID" runat="server"></asp:TextBox>
            <br />
            sName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="sName" runat="server"></asp:TextBox>
            <br />
            sAddress&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sAddress" runat="server"></asp:TextBox>
            <br />
            sTutorOrNot&nbsp;
            <asp:CheckBox ID="Yes" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
            <br />
            sPhone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="sPhone" runat="server"></asp:TextBox>
            <br />
            sJoiningdate&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sJoiningDate" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="OK" />
            <br />
        </div>
    </form>
</body>
</html>
