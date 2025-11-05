<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio153._Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Laboratorio 15-3</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Introduce un texto:</h3>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Mostrar" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
