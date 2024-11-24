create database Mymotos;
use Mymotos;
create table cliente(
nome varchar(45),
telefone varchar(14),
email varchar(45),
senha varchar (45),
Codcliente INT primary key auto_increment
) ; 
create table moto(
marcamoto varchar(45),
modelomoto varchar(45),
anomoto varchar (4),
numerochassi varchar(17),
herimetro varchar (5),
cormoto varchar(10),
tipomotor varchar (8),
cilindrada varchar (3),
Codmoto INT primary key auto_increment
) ;
create table dadosrevisao(
datarevisao varchar (8),
tiporevisao varchar (45),
kmmoto varchar (45),
servicosrealizados varchar (45),
pecassubstituidas varchar (45),
Coddadosrevisao INT primary key auto_increment
) ; 
create table oficina(
nome varchar (7),
descricao varchar (45),
endereco varchar (45),
telefone varchar (45),
email varchar (45),
servicosoferecidos varchar (45),
horario varchar (45),
codoficina INT primary key auto_increment
);
create table cadastroprodutos(
nomeproduto varchar (8),
descricaogeral varchar (45),
anodapeca varchar (45),
preco varchar (45), 
codcadprodutos INT primary key auto_increment
);
insert into cliente(nome,telefone,email) values("mymotos","419999","maymotos@gmail.com");
insert into cadastroprodutos(nomeproduto,descricaogeral,anodapeca,preco) values ("cambio","pecas de moto","2015", "100 reais");
insert into dadosrevisao(datarevisao,tiporevisao,kmmoto,servicosrealizados,pecassubstituidas) values ("3 de fevereiro","preventiva","2300km","troca de pecas","cambio");
insert into moto(marcamoto,modelomoto,anomoto,numerochassi,herimetro,cormoto,tipomotor,cilindrada) values ("suzuki","RMZ450","2024","YZB54382638NA","73","amarelo","4tempos","450");
insert into oficina(nome,descricao,endereco,telefone,email,servicosoferecidos,horario) values ("pampa motos","especializada em pecas","rua augusto zibarth","4199990","pampamotos@gmail.com","melhores revisoes","20h");

select *from cliente;

