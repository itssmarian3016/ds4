<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Lista de Casos - Bufete</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Casos</h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
    </form>
</body>
</html>