Laboratorio 17 - Integración de Aplicaciones Web ASP.NET con Base de Datos
Profesor: Regis Rivera
Alumno: (complete su nombre)
Fecha: (complete la fecha)

Contenido entregado:
- Proyecto esqueleto Laboratorio171 con páginas Default.aspx y WebForm1.aspx
- web.config con cadena de conexión (reemplazar YOUR_SERVER_NAME por su servidor)
- Default.aspx usa un GridView ligado a SqlDataSource para la tabla Products (CRUD básico)
- WebForm1.aspx muestra cómo llamar a un procedimiento almacenado desde SqlDataSource

Instrucciones para ejecutar:
1) Abra Visual Studio 2022.
2) File -> Open -> Project/Solution y seleccione la carpeta 'Laboratorio171' o abra la solución si utiliza.
3) Asegúrese de tener la base de datos Northwind instalada en su SQL Server local.
4) Edite web.config y reemplace YOUR_SERVER_NAME por el nombre de su servidor (ej: .\SQLEXPRESS o NOMBREPC).
5) Si la base de datos no tiene el procedimiento almacenado dbo.GetProductsByCategoryId, puede crear uno con el siguiente script (ejecutar en Northwind):

-- Ejemplo de procedimiento almacenado:
IF OBJECT_ID('dbo.GetProductsByCategoryId') IS NOT NULL
    DROP PROCEDURE dbo.GetProductsByCategoryId;
GO
CREATE PROCEDURE dbo.GetProductsByCategoryId
    @CategoryID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ProductID, ProductName, UnitPrice, CategoryID
    FROM dbo.Products
    WHERE CategoryID = @CategoryID;
END;
GO

6) Ejecute la aplicación (F5). La página Default.aspx mostrará los productos y permitirá editar el nombre y precio desde el GridView.
7) WebForm1.aspx llamará al procedimiento almacenado y mostrará los productos filtrados por CategoryID.

Notas:
- El proyecto entregado es un esqueleto pensado para estudiantes: está documentado y funciona si existen los recursos (Northwind y permisos).
- Ajuste y mejore el código según su estilo para entregarlo como trabajo final.
