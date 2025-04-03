--##############################Exercício 1##############################
select * from Livro
select * from Categoria

Update Livro
set vl_preco = vl_preco * 1.1
where cd_categoria = 1

--##############################Exercício 2##############################
select * from Usuario

update Usuario
set ds_endereco = 'Avenida das palmeiras, 789'
where cd_usuario = 1

--##############################Exercício 3##############################
select * from Emprestimo

update Emprestimo
set dt_devolucao = '2024-02-20'
where cd_emprestimo = 2

--##############################Exercício 4##############################
select * from Categoria
select * from Livro

delete from Livro where cd_categoria = 5	

--##############################Exercício 5##############################
select * from Emprestimo

delete from Emprestimo where cd_emprestimo = 3

--##############################Exercício 6##############################
select * from Emprestimo

delete from Emprestimo where cd_usuario = 1