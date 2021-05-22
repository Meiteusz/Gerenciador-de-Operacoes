create database GerenciadorDeOperacoes;

use GerenciadorDeOperacoes;


create table Operacoes(
Id int primary key identity not null,
Cliente_Nome varchar(250) not null,
Moeda_Origem varchar(100) not null,
Moeda_Destino varchar(100) not null,
Data_Operacao datetime not null,
Valor_Original float not null,
Valor_Convertido float not null,
Taxa_Cobrada float not null
);


create table Moedas(
id int primary key identity not null,
Moeda varchar(50) not null,
Simbolo varchar(4) not null,
Valor_Conversao decimal(10,3) not null,

constraint UQ_Moeda unique (Moeda)
);

insert into Moedas values('Real', 1.00);