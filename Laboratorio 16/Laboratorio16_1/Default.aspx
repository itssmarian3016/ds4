<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio161._Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Laboratorio 16-1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <h2>Laboratorio 16-1 - ASP.NET Web Forms</h2>
            <asp:Label ID="Label1" runat="server" Text="Presiona el botón para ver el mensaje:"></asp:Label><br /><br />
            <asp:Button ID="btnMensaje" runat="server" Text="Mostrar mensaje" OnClick="btnMensaje_Click" />
        </div>
    </form>
</body>
</html>
