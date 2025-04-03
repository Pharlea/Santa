create database Empresa
go
use Empresa
go
create table Cliente (cd_cnpj int primary key, nm_razao_social varchar(50) not null unique)
go
create table Seguradora (cd_cnpj int primary key, nm_razao_social varchar(50) not null unique)
go
create table Contrato(cd_contrato int primary key, dt_assinatura date default(getdate()), cd_cnpj_cliente int, foreign key(cd_cnpj_cliente) references Cliente, cd_cnpj_seguradora int, foreign key (cd_cnpj_seguradora) references Seguradora)
go
create table Plano (cd_plano int primary key, nm_plano varchar(50) not null)
go
create table Apolice (cd_apolice int primary key, dt_validade date not null, cd_plano int, foreign key(cd_plano) references Plano)
go
create table Segurado (cd_segurado int primary key, nm_segurado varchar(50) not null, dt_nascimento date, ic_titular varchar(50) not null)