
CREATE DATABASE BibliotecaDB;
GO
USE BibliotecaDB;

CREATE TABLE Libros(
 Id INT IDENTITY PRIMARY KEY,
 Titulo NVARCHAR(150),
 Codigo NVARCHAR(50),
 Autor NVARCHAR(100),
 Anio INT,
 Genero NVARCHAR(50)
);

CREATE TABLE Prestamos(
    Id INT IDENTITY PRIMARY KEY,
    Usuario NVARCHAR(100) NOT NULL,
    LibroId INT NOT NULL,
    Fecha DATE NOT NULL,
    CONSTRAINT FK_Prestamos_Libros
        FOREIGN KEY (LibroId) REFERENCES Libros(Id)
);

INSERT INTO Libros (Titulo, Codigo, Autor, Anio, Genero) VALUES
('Harry Potter y la piedra filosofal','L002','J.K. Rowling',1997,'Fantasía'),
('El señor de los anillos','L003','J.R.R. Tolkien',1954,'Fantasía'),
('Crónica de una muerte anunciada','L004','Gabriel García Márquez',1981,'Novela'),
('Fahrenheit 451','L005','Ray Bradbury',1953,'Ciencia ficción'),
('La sombra del viento','L006','Carlos Ruiz Zafón',2001,'Misterio');

INSERT INTO Prestamos (Usuario, LibroId, Fecha) VALUES
('Ana López',2,'2024-02-05'),
('Carlos Pérez',3,'2024-02-10'),
('Ana López',1,'2024-03-01'),
('María Gómez',4,'2024-03-12'),
('Luis Martínez',5,'2024-03-20'),
('Carlos Pérez',2,'2024-04-02');

SELECT * FROM Libros;

SELECT * FROM Prestamos;

SELECT 
    p.Id AS PrestamoId,
    p.Usuario,
    l.Titulo,
    l.Autor,
    p.Fecha
FROM Prestamos p
INNER JOIN Libros l ON p.LibroId = l.Id;

SELECT 
    l.Titulo,
    COUNT(p.Id) AS TotalPrestamos
FROM Prestamos p
INNER JOIN Libros l ON p.LibroId = l.Id
GROUP BY l.Titulo
ORDER BY TotalPrestamos DESC;

SELECT *
FROM Prestamos
WHERE Fecha BETWEEN '2024-01-01' AND '2024-12-31';




