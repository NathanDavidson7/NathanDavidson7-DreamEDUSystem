<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCourses" runat="server" Height="378px" Width="432px" OnSelectedIndexChanged="lstCourses_SelectedIndexChanged"></asp:ListBox>
        </div>
    </form>
</body>
</html>
