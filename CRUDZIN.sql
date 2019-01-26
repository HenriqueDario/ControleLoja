create database dbLoja
go

use dbLoja
go

create table tbFuncionario(
idFuncionario int identity(1,1) PRIMARY KEY,
Nome varchar(100) not null,
Rg varchar(20) not null,
Cpf varchar(20) not null,
Cargo varchar(100) not null,
DataDeNascimento date not null,
Endereco varchar(100) not null,
Bairro varchar(100) not null ,
Telefone varchar(20) not null
);

create table tbLogin(
idFuncionario int identity(1,1) PRIMARY KEY,
Login varchar(100) not null,
Senha varchar(100) not null
);


create table tbProduto(
idProduto int identity(1,1) primary key,
Nome varchar(100) not null,
Quantidade int not null,
Preco money not null,
Lote varchar(100),
Fabricacao date not null,
Validade date not null
);


drop table tbProduto

 insert into tbFuncionario(Nome, Rg, Cpf, Cargo, DataDeNascimento, Endereco, Bairro, Telefone)
 values
 ('Eu','393927258','50777783886','Vagabundo','04/08/2000','manuel bastos','nazaré','959292291');

insert into tbLogin(Login, Senha)
values
('jubileu','123')



 select * from tbFuncionario;
 select * from tblogin;
 select * from tbProduto;



update tbFuncionario SET Nome = 'Eu', Rg = '111' where idFuncionario = 3

delete from tbFuncionario where idFuncionario = 1

drop table tbFuncionario;
drop table tblogin;