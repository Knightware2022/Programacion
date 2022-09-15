create database pruebas2;

create table Usuarios(
	idUsuario int primary key not null
);
create table Vip(
	    idUsuario int not null,
        correo varchar(60) not null unique,
        contrasenia varchar(60) not null,
        nombre varchar(40) not null ,
        mesesSuscritos int not null,
        rol int not null,
        primary key (idUsuario, nombre),
		constraint foreign key (idUsuario) references Usuarios(idUsuario)
);
create table Guest(
     	idUsuario int primary key,
        nombreAutogen varchar(500) unique
 );
 
 create table Publicidad(
	   idPublicidad int primary key,
        url varchar(500)
 );

create table Deportes
(
	idDeporte int primary key,
    cantidadJugadores int not null,
    categoria varchar(50) not null,
    nombre varchar(50) not null unique
);


create table DeportesFavoritos
(
	idUsuario int not null,
    deporteFavorito int not null,
	primary key (idUsuario, deporteFavorito)
);
drop table deportesFavoritos;
alter table deportesfavoritos add constraint fk_depoFavUSU foreign key (idUsuario) references usuarios(idUsuario);
alter table deportesfavoritos add constraint fk_depoFavDEPO foreign key (deporteFavorito) references Deportes(idDeporte);
SELECT nombre 
FROM deportes
WHERE deportes.idDeporte IN 
(
   SELECT deporteFavorito 
   FROM deportesFavoritos
   where idUsuario = 2
);

 create user 'consultas'@'localhost' identified by 'consultasSQL';
GRANT SELECT ON pruebas2.* TO 'usuarioConsultas';
GRANT update, insert ON pruebas2.Vip TO 'usuarioConsultas';
GRANT update, insert ON pruebas2.Usuarios TO 'usuarioConsultas';
select * from vip;
create user 'administrator'@'localhost' identified by 'administrador1234';
GRANT ALL ON pruebas2.* TO 'administrator';
select * from publicidad;
insert into publicidad(idPublicidad, url) values (123, "https://www.instasent.com/blog/wp-content/uploads/2019/09/cover_6_ejemplos_banners.png");
insert into Usuarios(idUsuario) values (123);
insert into Usuarios(idUsuario) values (231);
insert into Vip(idUsuario, correo, contrasenia, nombre, mesesSuscritos, rol) values (231, "hol2@gmail.com", "Jl3h5nVBGtg=", " santi", 1, 1);
insert into Usuarios(idUsuario) values(1234);
insert into Vip(idUsuario, correo, contrasenia, nombre, mesesSuscritos, rol) values (231, "hol2@gmail.com", "Jl3h5nVBGtg=", " santi", 1, 1);
insert into Vip(idUsuario, correo, contrasenia, nombre, mesesSuscritos, rol) values (1234, "hola22@gmail.com", "WtXHXZYjgyA=", " roberto", 121, 1);

/***********************************************************/
insert into deportes(idDeporte, cantidadJugadores, categoria, nombre ) values(123, 20, 'Juevenil', 'Futbol');
insert into deportes(idDeporte, cantidadJugadores, categoria, nombre ) values(231, 23, 'Seleccion', 'basquetball');
insert into deportes(idDeporte, cantidadJugadores, categoria, nombre ) values(432, 5, 'Sub-20', 'handball');
insert into deportes(idDeporte, cantidadJugadores, categoria, nombre ) values(234, 14, 'Viejos', 'ajedrez');
insert into deportesFavoritos(idUsuario, deporteFavorito) values (2074885754, 123);
insert into deportesFavoritos(idUsuario, deporteFavorito) values (2074885754, 231);
insert into deportesFavoritos(idUsuario, deporteFavorito) values (2074885754, 432);
/********************/
