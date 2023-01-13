<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPLogin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            USER:<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button1" runat="server" Text="login" Height="27px" Width="120px" style="margin-top: 0px" />
        </p>
    </form>
</body>
</html>
