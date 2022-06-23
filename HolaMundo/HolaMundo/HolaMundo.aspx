<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HolaMundo.aspx.cs" Inherits="HolaMundo.HolaMundo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="TestLabel" runat="server" Text="Hola Mundo"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
        </p>
    </form>
</body>
</html>
