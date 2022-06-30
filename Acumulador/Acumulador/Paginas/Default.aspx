<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Acumulador.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Acumulador</h1>
        <hr />
        <asp:Label ID="lblValor" runat="server" Text="Valor de la variable: 0"></asp:Label>
        <hr />
        <asp:Button ID="Button" runat="server" Text="Postback" OnClick="Button_Click" />
        <hr />
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
