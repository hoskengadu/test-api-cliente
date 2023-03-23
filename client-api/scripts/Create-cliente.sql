USE [TesteDB]
CREATE TABLE dbo.Cliente
(
   id int IDENTITY(1,1),
   nome varchar(15) not null,
   sobrenome varchar(50) not null,
   numero_contato Int not null, 
   email varchar(30) not null,
   cpf int not null,
   data_nascimento date not null,
   sexo char not null,
   endereco varchar(50) not null,
   estado varchar(20) not null,
   cidade varchar(50) not null,
   primary key (id, cpf)
);
GO