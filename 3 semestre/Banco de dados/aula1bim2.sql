create database biblioteca 

use biblioteca 

create table Usuario (ds_email varchar(100) not null, nm_usuario varchar(100), ds_senha varchar(30), cd_assinatura int) 
go
create table Assinatura (cd_assinatura int not null, nm_assinatura varchar(100), sg_nivel char(3)) 
go
create table Transacao (cd_transacao int not null, dt_transacao date, vl_transacao money, sg_tipo char(3), ds_email varchar(100), cd_livro int) 
go
create table Livro (cd_livro int not null, nm_titulo varchar(100), nm_autor varchar(100), sg_genero char(1), ds_sinopse varchar (1000), sg_disponibilidade bit) 
go
create table Avaliacao (cd_avaliacao int not null, ds_comentario varchar(500), cd_livro int, ds_email varchar(100)) 
go
alter table Avaliacao add primary key (cd_avaliacao) 
go
alter table Livro add primary key (cd_livro) 
go
alter table Transacao add primary key (cd_transacao) 
go
alter table Assinatura add primary key (cd_assinatura) 
go
alter table Usuario add primary key (ds_email) 
go
alter table Usuario add foreign key (cd_assinatura) references Assinatura 
go
alter table Avaliacao add foreign key (cd_livro) references Livro 
go
alter table Avaliacao add foreign key (ds_email) references Usuario 
go
alter table Transacao add foreign key (ds_email) references Usuario 
go
alter table Transacao add foreign key (cd_livro) references Livro
