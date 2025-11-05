<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio161.WebForm1" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Segunda Página - WebForm1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Segunda página del Laboratorio 16-1</h2>
            <asp:Label ID="Label1" runat="server" Text="Esta es la segunda página del proyecto."></asp:Label><br /><br />
            <asp:Button ID="btnVolver" runat="server" Text="Volver al inicio" OnClick="btnVolver_Click" />
        </div>
    </form>
</body>
</html>
