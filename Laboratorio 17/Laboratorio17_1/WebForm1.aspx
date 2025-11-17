<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 17 - Integración con Stored Procedure</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Productos por Categoría (Procedimiento almacenado)</h2>

        <!-- Este SqlDataSource está configurado para llamar a un procedimiento almacenado llamado dbo.GetProductsByCategoryId
             Ver instrucciones en README.txt para crear el SP si no existe. -->
        <asp:SqlDataSource ID="SqlDataSourceSP" runat="server"
            ConnectionString="<%$ ConnectionStrings:NorthwindConnection %>"
            SelectCommand="dbo.GetProductsByCategoryId"
            SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:Parameter Name="CategoryID" Type="Int32" DefaultValue="1" />
            </SelectParameters>
        </asp:SqlDataSource>

        <asp:GridView ID="GridViewSP" runat="server" DataSourceID="SqlDataSourceSP" AutoGenerateColumns="True" />
        <p>Use el parámetro CategoryID para cambiar la categoría mostrada.</p>
        <p>Parte 2 completada: integración mediante procedimientos almacenados.</p>
    </div>
    </form>
</body>
</html>
