CREATE DATABASE BDTCC
USE BDTCC

CREATE TABLE [Sacola](
	[ID_Sacola] INT PRIMARY KEY IDENTITY(1, 1),
	[Data_de_Retirada] DATETIME,
	[Data_de_acerto] DATETIME,
	[Valor_da_sacola] FLOAT,
	[ID_Vendedora] INT,
	CONSTRAINT [FK_Vendedora] FOREIGN KEY (ID_Vendedora) REFERENCES Vendedora (ID_Vendedora)
)

CREATE TABLE [Vendedora](
	[ID_Vendedora] INT PRIMARY KEY IDENTITY(1, 1),
	[Nome] VARCHAR(100),
	[Senha] VARCHAR(50),
	[LOGIN] VARCHAR(50)
)

CREATE TABLE [Produto](
	[ID_Produto] INT PRIMARY KEY IDENTITY(1, 1),
	[Nome] VARCHAR(100),
	[Referencia] INT,
	[Categoria] VARCHAR(50),
	[Preco] FLOAT,
	[Cor/Estampa] VARCHAR(50),
	[Cod_de_barras] INT,
	[Tamanho] VARCHAR(5)
)

CREATE TABLE [Devolucao](
	[ID_Devolucao] INT PRIMARY KEY IDENTITY(1, 1),
	[Valor_devolucao] Float,
)

CREATE TABLE [Venda](
	[ID_Venda] INT PRIMARY KEY IDENTITY(1, 1),
	[Comissao] FLOAT,
	[Valor_da_venda] FLOAT
)

CREATE TABLE [Sacola_produto](
	[ID_Devolucao] INT,
	CONSTRAINT [FK_Devolucao] FOREIGN KEY (ID_Devolucao) REFERENCES Devolucao(ID_Devolucao),
	[ID_Venda] INT,
	CONSTRAINT [FK_Venda] FOREIGN KEY (ID_Venda) REFERENCES Venda(ID_Venda),
	[ID_Sacola] INT,
	CONSTRAINT [FK_Sacola] FOREIGN KEY (ID_Sacola) REFERENCES Sacola(ID_Sacola),
	[ID_Produto] INT,
	CONSTRAINT [FK_Produto] FOREIGN KEY (ID_Produto) REFERENCES Produto(ID_Produto),
) 

