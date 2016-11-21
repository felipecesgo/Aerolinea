Create Table TipoViaje
(
   IdTipoViaje int primary key identity(1,1),
   Nombre varchar(50)
 );
 Insert into TipoViaje(Nombre) values ('Ida y vuelta');
 Insert into TipoViaje(Nombre) values ('Sólo ida');
 GO

Alter table Vuelo add FechaRegreso datetime;
GO
 Alter table Vuelo add IdTipoViaje int not null FOREIGN KEY (IdTipoViaje) REFERENCES TipoViaje (IdTipoViaje);
 GO    


