CREATE DATABASE APIBD3
USE APIBD3

CREATE TABLE ProdutoAtual(
	Id INT,
	Nome VARCHAR(100),
	Referencia INT,
	Tamanho VARCHAR(10),
	Valor FLOAT,
	IdVendedora INT,
	Quantidade INT
)

CREATE TABLE ProdutosAnteriores(
	Id INT,
	Nome VARCHAR(100),
	Referencia INT,
	Tamanho VARCHAR(10),
	Valor FLOAT,
	IdSacola INT,
	Quantidade INT
)

CREATE TABLE ProdutoVendido(
	Id INT,
	Nome VARCHAR(100),
	Referencia INT,
	Tamanho VARCHAR(10),
	Valor FLOAT,
	IdVendedora INT,
	Quantidade INT
)

CREATE TABLE VendasAnteriores(
	Id INT,
	IdSacola INT,
	MesDeEntrega VARCHAR(20),
	Valor FLOAT
)
