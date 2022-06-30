<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Origen.aspx.cs" Inherits="Acumulador.Paginas.Origen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonRedirect" runat="server" Text="Redirect" OnClick="ButtonRedirect_Click" />
        </div>
        <div>
            <asp:Button ID="ButtonTransfer" runat="server" Text="Transfer" OnClick="ButtonTransfer_Click" />
        </div>
    </form>
</body>
</html>
