
create database Mymotos;
use Mymotos;
create table cliente(
nome varchar(45),
telefone varchar(14),
email varchar(45),
senha varchar (40),
Codcliente INT primary key auto_increment
) ; 
CREATE TABLE moto(	
    marcamoto VARCHAR(45),
    modelomoto VARCHAR(45),
    kmmoto VARCHAR(40),
    cormoto VARCHAR(40),
    Codmoto INT PRIMARY KEY AUTO_INCREMENT,
    codigo_cliente INT,
    FOREIGN KEY (codigo_cliente) REFERENCES cliente(Codcliente)
);

 create table dadosrevisao(
  datarevisao varchar (45), 
 kmmoto varchar (45),
servicosrealizados varchar (45),
codproduto int,
  pecassubstituidas varchar (45),
  Coddadosrevisao INT primary key auto_increment, 
  codmoto int, 
  codmecanico int
  ) ;

create table oficina(
nome varchar (45),
descricao varchar (45),
endereco varchar (45),
telefone varchar (45),
email varchar (45),
servicosoferecidos varchar (45),
horario varchar (45),
codoficina INT primary key auto_increment
);
create table cadastroprodutos(
nomeproduto varchar (45),
descricaogeral varchar (45),
anodapeca varchar (45),
preco varchar (45), 
codcadprodutos INT primary key auto_increment,
codigo_cliente INT,
FOREIGN KEY (codigo_cliente) REFERENCES cliente(Codcliente)
);
create table cadastromecanico(
nomeooficina varchar (45),
nomemecanico varchar (45),
emailmecanico varchar (45),
senhamecanico varchar (45),
codcadmecanico INT primary key auto_increment
); 
create table servicosprontos(
nomemecanico varchar (45),
nomeoficina varchar(45),
servico varchar(45),
codservico int primary key auto_increment
);

insert into cliente(nome,telefone,email) values("mymotos","419999","maymotos@gmail.com");
insert into cadastroprodutos(nomeproduto,descricaogeral,anodapeca,preco) values ("cambio","pecas de moto","2015", "100 reais");
insert into dadosrevisao(datarevisao,kmmoto,servicosrealizados,pecassubstituidas) values ("3 de fevereiro","2300km","troca de pecas","cambio");
insert into moto(marcamoto,modelomoto,cormoto, kmmoto,codigo_cliente) values ("suzuki","RMZ450","amarelo", "33Km", 1);
insert into oficina(nome,descricao,endereco,telefone,email,servicosoferecidos,horario) values ("pampa motos","especializada em pecas","rua augusto zibarth","4199990","pampamotos@gmail.com","melhores revisoes","20h");
insert into cadastromecanico(nomeooficina,nomemecanico,emailmecanico,senhamecanico) values ("tester","nomemecanico","emailmecanico","senhamecanico");

select *from cliente;
select * from  moto ;
select * from oficina;
select *from dadosrevisao;
select * from cadastroprodutos;
select *from cadastromecanico;



SELECT cliente.nome AS NomeCliente, cliente.telefone AS TelefoneCliente, moto.marcamoto AS MarcaMoto, cadastroprodutos.nomeproduto AS NomeProduto, cliente.Codcliente AS CodigoCliente, cadastroprodutos.codcadprodutos AS CodigoProduto, moto.Codmoto AS CodigoMoto FROM cliente INNER JOIN moto ON cliente.Codcliente = moto.codigo_cliente CROSS JOIN cadastroprodutos;

-- listar revisão com cliente e moto
select * from dadosrevisao inner join cliente
on cliente.Codcliente=dadosrevisao.codigo_cliente
inner join moto
on moto.codigo_cliente=cliente.codcliente;

select * from cliente inner join moto
on moto.codigo_cliente=cliente.codcliente;

select cliente.nome,
 cliente.telefone,
 moto.marcamoto,
 moto.modelomoto,
 cadastroprodutos.nomeproduto,
 cliente.Codcliente,
 moto.Codmoto,
 cadastroprodutos.codcadprodutos
 from cadastroprodutos 
 inner join cliente on cadastroprodutos.codigo_cliente = cliente.Codcliente
 inner join moto on cadastroprodutos.codigo_cliente = moto.codigo_cliente;

select * from cadastromecanico ;


