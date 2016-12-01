USE master;
GO
CREATE DATABASE Aerolinea;
USE Aerolinea;

CREATE TABLE Avion
(
    IdAvion int primary key  IDENTITY(1,1),
	Matricula nvarchar (20) NOT NULL,
    Marca nvarchar (20),
	Modelo nvarchar (20)
);

INSERT INTO Avion(Matricula, Marca, Modelo) VALUES
('A01', 'Boeing', '747'),
('A02', 'Boeing', '737'),
('A03', 'Boeing', '689'),
('A04', 'Embraer', 'ER145'),
('A05', 'Embraer', 'ER560');
GO

CREATE TABLE Ruta
(
	IdRuta int primary key  IDENTITY(1,1),
	Origen nvarchar (50) NOT NULL,
	Destino nvarchar (50) NOT NULL,
	Tarifa money NOT NULL,
	Imagen image
);

CREATE TABLE Rol
(
	IdRol int primary key  IDENTITY(1,1),
	Nombre nvarchar (50) NOT NULL,
	Descripcion nvarchar (256)
);
INSERT INTO Rol(Nombre, Descripcion) VALUES
('Administrador', 'Administrador del sistema'),
('Agente de Ventas', 'Agente de ventas');
GO

CREATE TABLE Agente
(
	IdAgente int primary key  IDENTITY(1,1),
	IdRol int  NOT NULL,
    Cedula nvarchar (25) NOT NULL,
	Nombre nvarchar (50) NOT NULL,
    Apellido nvarchar (50) NOT NULL,
    Telefono nvarchar(50),
    Email nvarchar (50),
	Residencia nvarchar (256),
	Usuario nvarchar (25)  NOT NULL,
    Contrasena nvarchar (256)  NOT NULL,
	Foreign key (IdRol) REFERENCES Rol(IdRol)
);

CREATE TABLE Cliente
(
	IdCliente int primary key  IDENTITY(1,1),
    Cedula nvarchar (25) NOT NULL,
	Nombre nvarchar (50) NOT NULL,
    Apellido nvarchar (50) NOT NULL,
    Telefono nvarchar(50),
    Email nvarchar (50),
	Residencia nvarchar (256),
	Usuario nvarchar (25) NOT NULL,
    Contrasena nvarchar (256) NOT NULL
);

CREATE TABLE Queja
(
  IdQueja int primary key  IDENTITY(1,1),
  IdVuelo int  NOT NULL , 
  IdCliente  int  NOT NULL ,
  Motivo nvarchar (256),
  Descripcion nvarchar (256),
  Foreign key (IdVuelo) REFERENCES Vuelo(IdVuelo),
  Foreign key (IdCliente) REFERENCES Cliente(IdCliente)
);

CREATE TABLE Piloto
(
	IdPiloto int primary key  IDENTITY(1,1),
    Cedula nvarchar (20) NOT NULL,
    Nombre nvarchar (50) NOT NULL,
    Apellido nvarchar (50) NOT NULL,
    Telefono nvarchar(50),
    Email nvarchar (20),
    Residencia nvarchar (256),
);

CREATE TABLE Vuelo
(
	IdVuelo int primary key  IDENTITY(1,1),
	IdAvion int NOT NULL,
	IdPiloto int NOT NULL,
	IdRuta int NOT NULL,
	EstadoVuelo nvarchar (25),
    FechaSalida datetime NOT NULL,
	FechaLlegada datetime NOT NULL,
    CapacidadAsientos int NOT NULL,
    Foreign key (IdAvion) REFERENCES Avion(IdAvion),
    Foreign key (IdPiloto) REFERENCES Piloto(IdPiloto),
	Foreign key (IdRuta) REFERENCES Ruta(IdRuta)
);



CREATE TABLE Tiquete
(
  IdTiquete int primary key  IDENTITY(1,1),
  IdVuelo int  NOT NULL,
  IdCliente int  NOT NULL,
  NumeroDeAsiento int,
  Fecha datetime NOT NULL DEFAULT GETDATE(),
  Foreign key (IdVuelo) REFERENCES Vuelo(IdVuelo),
  Foreign key (IdCliente) REFERENCES Cliente(IdCliente)
);

CREATE TABLE Pago
(
	IdPago int primary key  IDENTITY(1,1),
	IdTiquete int  NOT NULL,
	FormaPago nvarchar (25)  NOT NULL , 
	Monto MONEY NOT NULL,
	Foreign key (IdTiquete) REFERENCES Tiquete(IdTiquete)
)