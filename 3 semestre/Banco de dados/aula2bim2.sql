create database	Distribuidora
go
use Distribuidora
go
create table vendedor (cd_vendedor int not null primary key, nm_vendedor varchar(100), ds_endereco varchar(50), pc_comissao int)
go
create table cliente (cd_cliente int not null primary key, nm_cliente varchar(100), ds_endereco varchar(50), vl_faturamento money, vl_limite money, cd_vendedor int not null foreign key references vendedor)
go
create table armazem (cd_armazem int not null primary key, ds_endereco varchar(50))
go
create table peca (cd_peca int not null primary key, ds_peca varchar(100), vl_peca money, qt_estoque int, cd_armazem int not null foreign key references armazem)
go
create table pedido (cd_pedido int not null primary key, dt_pedido date, cd_cliente int not null foreign key references cliente, cd_vendedor int not null foreign key references vendedor, cd_peca int not null foreign key references peca)
