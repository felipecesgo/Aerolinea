Create Table TipoViaje
(
   IdTipoViaje int primary key identity(1,1),
   Nombre varchar(50)
 );
 Insert into TipoViaje(Nombre) values ('Ida y vuelta');
 Insert into TipoViaje(Nombre) values ('Sólo ida');
 GO
 Alter table Vuelo add EstadoAsientos nvarchar(50);
Alter table Vuelo add FechaRegreso datetime;
GO
 Alter table Vuelo add IdTipoViaje int not null FOREIGN KEY (IdTipoViaje) REFERENCES TipoViaje (IdTipoViaje);
 GO    

 INSERT INTO avion (Matricula, Marca, Modelo) VALUES
(1, 'boing', '747'),
(2, 'Boeing', '737'),
(3, 'Boeing', '689'),
(4, 'Embraer', 'ER145'),
(5, 'Embraer', 'ER560');


CREATE TABLE Clase (
  IdClase int NOT NULL PRIMARY KEY Identity(1,1),
  tipo varchar(25) NOT NULL
);





