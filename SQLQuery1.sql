CREATE DATABASE Gesmed;

CREATE TABLE Usuarios (
	UserId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre varchar(30) NOT NULL,
	ApellidoPaterno varchar(30) NOT NULL,
	ApellidoMaterno varchar(30),
	CorreoElectronico varchar(50),
	NomUsuario varchar(20),
	Contrasena varchar(12) NOT NULL
);

