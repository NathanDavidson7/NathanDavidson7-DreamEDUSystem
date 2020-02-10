<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sStaff.aspx.cs" Inherits="sStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            sID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtsID" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            sName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sName" runat="server" OnTextChanged="sName_TextChanged"></asp:TextBox>
            <br />
            sAddress&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="sAddress" runat="server" OnTextChanged="sAddress_TextChanged">
</asp:TextBox>
            <br />
            sTutorOrNot&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="sTutorOrNot" runat="server" OnTextChanged="sTutorOrNot_TextChanged"></asp:TextBox>
            <br />
            sPhone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sPhone" runat="server" OnTextChanged="sPhone_TextChanged"></asp:TextBox>
            <br />
            sJoiningDate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sJoiningdate" runat="server" OnTextChanged="sJoiningdate_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server"  Text="OK" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
