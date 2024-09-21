<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="testing_page.aspx.vb" Inherits="Alumni_Platform.testing_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <asp:Label ID="testin_lbl" runat="server" Text="testin_label"></asp:Label>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="Submit" />
    </form>
</body>
</html>
