create database EX04_P1
go

use EX04_P1
go

create table Categoria (
	cd_categoria int primary key,
	nm_categoria varchar(50) not null
)

create table Produto (
	cd_produto int primary key,
	nm_produto varchar(100) not null,
	vl_produto money,
	cd_categoria int foreign key references Categoria
)

create table Cliente (
	cd_cliente int primary key,
	nm_cliente varchar(100) not null,
	ds_endereco varchar(150),
	ds_telefone varchar(11),
	sg_status varchar(10) check (sg_status = 'bom' or sg_status = 'm�dio' or sg_status = 'ruim'),
	dt_nascimento date check (dt_nascimento < getdate()),
	vl_limite money default 0
)

create table Pedido (
	cd_pedido int primary key,
	dt_pedido date default getdate(),
	cd_cliente int foreign key references Cliente
)

create table ItemPedido (	
	cd_produto int foreign key references Produto not null,
	cd_pedido int foreign key references Pedido not null,
	qt_produto int check (qt_produto > 0),
	vl_produto money,	
)
go

alter table ItemPedido
	add primary key (cd_produto, cd_pedido)

go



-- Inserir dados na tabela Categoria
INSERT INTO Categoria (cd_categoria, nm_categoria) VALUES
(1, 'Eletr�nicos'),
(2, 'Roupas'),
(3, 'Alimentos'),
(4, 'M�veis'),
(5, 'Livros'),
(6, 'Brinquedos'),
(7, 'Utens�lios Dom�sticos'),
(8, 'Ferramentas'),
(9, 'Produtos de Limpeza'),
(10, 'Acess�rios Esportivos');
go

-- Inserir dados na tabela Produto
INSERT INTO Produto (cd_produto, nm_produto, cd_categoria, vl_produto) VALUES
(1, 'Smartphone', 1, 120),
(2, 'Camiseta', 2, 45),
(3, 'Arroz', 3, 56),
(4, 'Sof�', 4, 190),
(5, 'Livro de Fic��o', 5, 1212),
(6, 'Quebra-Cabe�a', 6, 21),
(7, 'Panela de Press�o', 7, 54),
(8, 'Furadeira', 8, 98),
(9, 'Detergente', 9, 65),
(10, 'T�nis', 10, 90),
(11, 'Gabarito da P2 de Banco de Dados', 10, 5000);
go

-- Inserir dados na tabela Cliente
INSERT INTO Cliente (cd_cliente, nm_cliente, ds_endereco, ds_telefone, sg_status, dt_nascimento, vl_limite) VALUES
(1, 'Jo�o da Silva', 'Rua A, 123', '1122334455', 'bom', '1980-05-15', 500.00),
(2, 'Maria Oliveira', 'Av. B, 456', '9988776655', 'm�dio', '1995-10-20', 300.00),
(3, 'Jos� Santos', 'Rua C, 789', '9988776655', 'ruim', '2000-02-10', 200.00),
(4, 'Ana Pereira', 'Rua D, 321', '1122334455', 'bom', '1975-07-25', 1000.00),
(5, 'Carlos Fernandes', 'Av. E, 654', '9988776655', 'm�dio', '1988-09-30', 700.00),
(6, 'Amanda Souza', 'Rua F, 987', '1122334455', 'ruim', '1992-04-05', 400.00),
(7, 'Pedro Costa', 'Av. G, 1234', '9988776655', 'bom', '1983-12-12', 800.00),
(8, 'Laura Carvalho', 'Rua H, 567', '1122334455', 'm�dio', '1997-08-18', 600.00),
(9, 'Roberto Almeida', 'Av. I, 890', '9988776655', 'ruim', '2002-01-08', 300.00),
(10, 'Fernanda Lima', 'Rua J, 1234', '1122334455', 'bom', '1972-03-22', 1200.00),
(11, 'Mariana Rodrigues', 'Av. K, 5678', '9988776655', 'm�dio', '1985-11-28', 900.00),
(12, 'Ricardo Nunes', 'Rua L, 4321', '1122334455', 'ruim', '1990-06-14', 200.00),
(13, 'Isabela Gomes', 'Av. M, 9876', '9988776655', 'bom', '1978-09-03', 1500.00),
(14, 'Felipe Barbosa', 'Rua N, 345', '1122334455', 'm�dio', '1993-02-17', 1000.00),
(15, 'Patr�cia Lima', 'Av. O, 6543', '9988776655', 'ruim', '1986-07-08', 500.00),
(16, 'Lucas Fernandes', 'Rua P, 9876', '1122334455', 'bom', '1981-01-30', 800.00),
(17, 'Tatiane Almeida', 'Av. Q, 2345', '9988776655', 'm�dio', '1996-05-12', 600.00),
(18, 'Bruno Oliveira', 'Rua R, 6543', '1122334455', 'ruim', '2001-08-20', 400.00),
(19, 'Luana Pereira', 'Av. S, 8765', '9988776655', 'bom', '1974-04-26', 1300.00),
(20, 'Gustavo Silva', 'Rua T, 3210', '1122334455', 'm�dio', '1987-10-10', 700.00);
go

-- Inserir dados na tabela Pedido
INSERT INTO Pedido (cd_pedido, dt_pedido, cd_cliente) VALUES
(1, '2024-04-26', 1),
(2, '2024-04-26', 2),
(3, '2024-04-26', 3),
(4, '2024-04-26', 4),
(5, '2024-04-26', 5),
(6, '2024-04-26', 6),
(7, '2024-04-26', 7),
(8, '2024-04-26', 8),
(9, '2024-04-26', 9),
(10, '2024-04-26', 10),
(11, '2024-04-26', 11),
(12, '2024-04-26', 12),
(13, '2024-04-26', 13),
(14, '2024-04-26', 14),
(15, '2024-04-26', 15),
(16, '2024-04-26', 16),
(17, '2024-04-26', 17),
(18, '2024-04-26', 18),
(19, '2024-04-26', 19),
(20, '2024-04-26', 20);
go

-- Inserir dados na tabela ItemPedido
INSERT INTO ItemPedido (cd_produto, cd_pedido, qt_produto, vl_produto) VALUES
(1, 1, 2, 1500.00),
(2, 2, 3, 50.00),
(3, 3, 1, 10.00),
(4, 4, 1, 2000.00),
(5, 5, 1, 30.00),
(6, 6, 1, 20.00),
(7, 7, 1, 100.00),
(8, 8, 1, 150.00),
(9, 9, 2, 5.00),
(10, 10, 2, 100.00),
(1, 11, 3, 1500.00),
(2, 12, 3, 50.00),
(3, 13, 4, 10.00),
(4, 14, 1, 2000.00),
(5, 15, 1, 30.00),
(6, 16, 1, 20.00),
(7, 17, 2, 100.00),
(8, 18, 1, 150.00),
(9, 19, 2, 5.00),
(10, 20, 2, 100.00);
go 
--EX1--
select nm_cliente,sg_status 
from Cliente 
where sg_status = 'bom' 
order by nm_cliente asc
go
--EX2--
select nm_produto,cd_categoria 
from Produto
where cd_categoria = '1'
order by nm_produto asc
go
--EX3--
SELECT SUM(ip.qt_produto * ip.vl_produto) AS Valor_Total
FROM Pedido p
INNER JOIN Cliente c ON p.cd_cliente = c.cd_cliente
INNER JOIN ItemPedido ip ON p.cd_pedido = ip.cd_pedido
WHERE c.sg_status = 'm�dio';
--EX4--
SELECT DISTINCT c.nm_cliente
FROM Cliente c
INNER JOIN Pedido p ON c.cd_cliente = p.cd_cliente
WHERE YEAR(p.dt_pedido) = 2024 AND MONTH(p.dt_pedido) = 4
ORDER BY c.nm_cliente;
--EX5--
SELECT *
FROM Produto
WHERE vl_produto > 100
ORDER BY vl_produto DESC;
--EX6--
SELECT TOP 1 nm_cliente, dt_nascimento
FROM Cliente c
INNER JOIN Pedido p ON c.cd_cliente = p.cd_cliente
ORDER BY dt_nascimento DESC;
--EX7--
SELECT p.nm_produto, SUM(ip.qt_produto) AS Quantidade_Vendida
FROM Produto p
INNER JOIN ItemPedido ip ON p.cd_produto = ip.cd_produto
GROUP BY p.nm_produto
ORDER BY Quantidade_Vendida DESC;
--EX8--
SELECT c.nm_cliente, SUM(ip.qt_produto * ip.vl_produto) AS Total_Gasto
FROM Cliente c
INNER JOIN Pedido p ON c.cd_cliente = p.cd_cliente
INNER JOIN ItemPedido ip ON p.cd_pedido = ip.cd_pedido
GROUP BY c.nm_cliente
ORDER BY Total_Gasto DESC;
--EX9--
SELECT nm_categoria, COUNT(*) AS Numero_de_Produtos
FROM Produto p
INNER JOIN Categoria c ON p.cd_categoria = c.cd_categoria
GROUP BY nm_categoria
ORDER BY Numero_de_Produtos DESC
LIMIT 1;
--EX10--
SELECT p.*
FROM Produto p
LEFT JOIN ItemPedido ip ON p.cd_produto = ip.cd_produto
WHERE ip.cd_produto IS NULL;

