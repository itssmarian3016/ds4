<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio154._Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Laboratorio 15-4</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Suma de dos números</h3>
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox> +
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
            <br /><br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado: "></asp:Label>
        </div>
    </form>
</body>
</html>
