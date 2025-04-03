CREATE DATABASE TP04
GO

USE TP04
GO

-- Criando a tabela Autor
CREATE TABLE Autor (
    cd_autor INT PRIMARY KEY,
    nm_autor VARCHAR(100) NOT NULL,
    dt_nascimento DATE,
    ds_nacionalidade VARCHAR(100),
    CONSTRAINT CK_Autor_dt_nascimento CHECK (dt_nascimento < GETDATE())
);

-- Criando a tabela Categoria
CREATE TABLE Categoria (
    cd_categoria INT PRIMARY KEY,
    nm_categoria VARCHAR(50) NOT NULL,
    CONSTRAINT UQ_Categoria_nm_categoria UNIQUE (nm_categoria)
);

-- Criando a tabela Livro
CREATE TABLE Livro (
    cd_livro INT PRIMARY KEY,
    nm_titulo VARCHAR(200) NOT NULL,
    cd_autor INT,
    cd_categoria INT,
    vl_preco MONEY DEFAULT 0,
    qt_estoque INT DEFAULT 0,
    FOREIGN KEY (cd_autor) REFERENCES Autor(cd_autor),
    FOREIGN KEY (cd_categoria) REFERENCES Categoria(cd_categoria)
);

-- Criando a tabela Usuario
CREATE TABLE Usuario (
    cd_usuario INT PRIMARY KEY,
    nm_usuario VARCHAR(100) NOT NULL,
    ds_endereco VARCHAR(150),
    ds_telefone VARCHAR(11),
    CONSTRAINT CK_Usuario_ds_telefone CHECK (LEN(ds_telefone) = 11)
);

-- Criando a tabela Emprestimo
CREATE TABLE Emprestimo (
    cd_emprestimo INT PRIMARY KEY,
    cd_livro INT,
    cd_usuario INT,
    dt_emprestimo DATE DEFAULT GETDATE(),
    dt_devolucao DATE,
    FOREIGN KEY (cd_livro) REFERENCES Livro(cd_livro),
    FOREIGN KEY (cd_usuario) REFERENCES Usuario(cd_usuario)
);

GO


-- Inserindo dados na tabela Autor
INSERT INTO Autor (cd_autor, nm_autor, dt_nascimento, ds_nacionalidade) VALUES
(1, 'Machado de Assis', '1839-06-21', 'Brasileira'),
(2, 'Carlos Drummond de Andrade', '1902-10-31', 'Brasileira'),
(3, 'Agatha Christie', '1890-09-15', 'Inglesa'),
(4, 'Stephen King', '1947-09-21', 'Americana'),
(5, 'George Orwell', '1903-06-25', 'Inglesa');

-- Inserindo dados na tabela Categoria
INSERT INTO Categoria (cd_categoria, nm_categoria) VALUES
(1, 'Romance'),
(2, 'Fic��o Cient�fica'),
(3, 'Suspense'),
(4, 'Poesia'),
(5, 'Autoajuda');

-- Inserindo dados na tabela Livro
INSERT INTO Livro (cd_livro, nm_titulo, cd_autor, cd_categoria, vl_preco, qt_estoque) VALUES
(1, 'Dom Casmurro', 1, 1, 35.90, 50),
(2, 'Mem�rias P�stumas de Br�s Cubas', 1, 1, 29.90, 30),
(3, 'Grande Sert�o: Veredas', 1, 1, 45.50, 20),
(4, 'Sagarana', 1, 1, 27.80, 15),
(5, 'Quincas Borba', 1, 1, 32.70, 25),
(6, 'Claro Enigma', 1, 1, 28.40, 10),
(7, 'Alguma Poesia', 2, 4, 20.00, 40),
(8, 'Sentimento do Mundo', 2, 4, 22.50, 35),
(9, 'A Morte de Ivan Ilitch', 3, 3, 19.90, 60),
(10, 'O Assassinato de Roger Ackroyd', 3, 3, 29.90, 45),
(11, 'It: A Coisa', 4, 3, 39.90, 55),
(12, 'O Iluminado', 4, 3, 36.80, 50),
(13, '1984', 5, 2, 34.90, 70),
(14, 'A Revolu��o dos Bichos', 5, 2, 25.50, 65);

-- Inserindo dados na tabela Usuario
INSERT INTO Usuario (cd_usuario, nm_usuario, ds_endereco, ds_telefone) VALUES
(1, 'Maria Silva', 'Rua das Flores, 123', '11223344555'),
(2, 'Jo�o Santos', 'Av. Principal, 456', '99887766555'),
(3, 'Ana Oliveira', 'Travessa das Palmeiras, 789', '55454332211'),
(4, 'Pedro Souza', 'Rua dos Alpes, 321', '33669955858'),
(5, 'Carla Lima', 'Av. Central, 789', '11445566757');

-- Inserindo dados na tabela Emprestimo (alguns empr�stimos fict�cios)
INSERT INTO Emprestimo (cd_emprestimo, cd_livro, cd_usuario, dt_emprestimo, dt_devolucao) VALUES
(1, 1, 1, '2024-02-01', '2024-02-15'),
(2, 4, 3, '2024-02-02', '2024-02-16'),
(3, 10, 2, '2024-02-03', '2024-02-17'),
(4, 13, 4, '2024-03-04', '2024-03-18'),
(5, 8, 5, '2024-03-05', '2024-03-19'),
(6, 7, 1, '2024-03-06', '2024-03-20'),
(7, 12, 3, '2024-04-07', '2024-04-21'),
(8, 5, 2, '2024-04-08', '2024-04-22'),
(9, 9, 4, '2024-04-09', '2024-04-23'),
(10, 14, 5, '2024-04-10', '2024-04-24'),
(11, 2, 1, '2024-04-11', '2024-04-25'),
(12, 3, 2, '2024-04-12', '2024-04-26'),
(13, 6, 3, '2024-04-13', '2024-04-27'),
(14, 11, 4, '2024-04-14', '2024-04-28'),
(15, 1, 5, '2024-04-15', '2024-04-29');


SELECT * FROM Categoria
SELECT * FROM Autor
SELECT * FROM Livro
SELECT * FROM Usuario
SELECT * FROM Emprestimo