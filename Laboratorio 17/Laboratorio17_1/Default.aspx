<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 17 - Integración Básica</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Productos (Northwind) - GridView básico</h2>
        <!-- NOTA: reemplace 'YOUR_SERVER_NAME' en web.config por el nombre de su servidor SQL Server -->
        <asp:SqlDataSource ID="SqlDataSourceProducts" runat="server"
            ConnectionString="<%$ ConnectionStrings:NorthwindConnection %>"
            SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM dbo.Products"
            UpdateCommand="UPDATE dbo.Products SET ProductName = @ProductName, UnitPrice = @UnitPrice WHERE ProductID = @ProductID">
            <UpdateParameters>
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
                <asp:Parameter Name="ProductID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <asp:GridView ID="GridViewProducts" runat="server" 
            DataSourceID="SqlDataSourceProducts" AutoGenerateColumns="False" 
            DataKeyNames="ProductID" AllowPaging="True" AllowSorting="True" AutoGenerateEditButton="True">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="ProductName" HeaderText="Nombre del Producto" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Precio Unitario" DataFormatString="{0:C}" />
            </Columns>
        </asp:GridView>
        <p>Si edita un producto y guarda, los cambios se aplicarán a la base de datos Northwind (si la cadena y permisos son correctos).</p>
        <p>Parte 1 completada: integración básica con GridView.</p>
    </div>
    </form>
</body>
</html>
