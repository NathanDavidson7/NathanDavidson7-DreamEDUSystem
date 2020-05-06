<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sStaff.aspx.cs" Inherits="sStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 362px">
            sID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtsID" runat="server"></asp:TextBox>
            &nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click"  />
            <br />
            sName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtsName" runat="server"></asp:TextBox>
            <br />
            sAddress&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtsAddress" runat="server"></asp:TextBox>
            <br />
            sTutorOrNot&nbsp;&nbsp;
            <asp:CheckBox ID="chkYes" runat="server"  />
            <br />
            sPhone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtsPhone" runat="server"></asp:TextBox>
            <br />
            sJoiningDate&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtsJoiningDate" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click1" Text="OK" />
            &nbsp;<br />
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
