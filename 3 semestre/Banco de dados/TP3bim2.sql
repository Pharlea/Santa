--1
select * from Cliente where sg_status = 'bom' order by nm_cliente asc

--2
select * from Produto where cd_categoria = 1 order by nm_produto asc

--3
select sum(vl_produto) from ItemPedido where cd_pedido in(select cd_pedido from Pedido where cd_cliente in(select cd_cliente from Cliente where sg_status = 'médio'))

--4
select nm_cliente from Cliente where cd_cliente in(select cd_cliente from Pedido where dt_pedido like '2024-04%') order by nm_cliente asc

--5
select vl_produto, nm_produto from Produto where vl_produto > 100 order by vl_produto desc

--6
select * from Cliente where cd_cliente in(select cd_cliente from Pedido) and dt_nascimento in (select max(dt_nascimento) from Cliente)

--7
select nm_produto, qt_produto from ItemPedido, Produto order by qt_produto desc

--8
select nm_cliente from Cliente