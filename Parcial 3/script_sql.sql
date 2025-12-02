-- Script para crear la base de datos y tablas (SQL Server)
CREATE DATABASE MariaGonzalez_DB;
GO
USE MariaGonzalez_DB;
GO

CREATE TABLE MG_Clientes (
    ClienteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    Telefono NVARCHAR(50),
    Email NVARCHAR(100),
    Direccion NVARCHAR(250)
);

CREATE TABLE MG_Abogados (
    AbogadoID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    Especialidad NVARCHAR(100),
    Email NVARCHAR(100),
    Telefono NVARCHAR(50)
);

CREATE TABLE MG_Estados (
    EstadoID INT IDENTITY(1,1) PRIMARY KEY,
    NombreEstado NVARCHAR(50) NOT NULL
);

INSERT INTO MG_Estados (NombreEstado) VALUES ('Abierto'),('En Proceso'),('Cerrado'),('Archivado');

CREATE TABLE MG_Casos (
    CasoID INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(200),
    Descripcion NVARCHAR(MAX),
    FechaInicio DATE,
    FechaVencimiento DATE,
    AbogadoID INT FOREIGN KEY REFERENCES MG_Abogados(AbogadoID),
    ClienteID INT FOREIGN KEY REFERENCES MG_Clientes(ClienteID),
    EstadoID INT FOREIGN KEY REFERENCES MG_Estados(EstadoID),
    FechaUltimaActualizacion DATETIME DEFAULT GETDATE()
);

CREATE TABLE MG_Documentos (
    DocumentoID INT IDENTITY(1,1) PRIMARY KEY,
    CasoID INT FOREIGN KEY REFERENCES MG_Casos(CasoID),
    NombreArchivo NVARCHAR(255),
    RutaArchivo NVARCHAR(500),
    FechaSubida DATETIME DEFAULT GETDATE(),
    TipoDocumento NVARCHAR(100)
);

CREATE TABLE MG_Alertas (
    AlertaID INT IDENTITY(1,1) PRIMARY KEY,
    CasoID INT FOREIGN KEY REFERENCES MG_Casos(CasoID),
    FechaAlerta DATETIME,
    Mensaje NVARCHAR(300),
    Enviado BIT DEFAULT 0
);