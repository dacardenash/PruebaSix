CREATE DATABASE PruebaSD;
GO

USE PruebaSD;
GO

CREATE TABLE Usuario (
	usuID NUMERIC(18, 0) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	apellido VARCHAR(100) NOT NULL,
    PRIMARY KEY (usuID)
);
GO

INSERT INTO Usuario (usuID, nombre, apellido) VALUES (1, 'Andres', 'Rodriguez Vera');
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (2, 'Jose', 'Giraldo Perez');
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (3, 'Sandra', 'Ramirez Jimenez');
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (4, 'Juan Jose', 'Santana Velasquez');
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (5, 'Olga Lucia', 'Zapata Huerta');
GO