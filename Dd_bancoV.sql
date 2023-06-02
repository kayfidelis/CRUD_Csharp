create database dbAppBanco1;
use dbAppBanco1;
create table tbUsuario
(
idUsu int primary key auto_increment,
NomeUsu varchar(50) not null,
Cargo varchar(50) not null,
DataNasc datetime
);

insert into tbUsuario(NomeUsu, Cargo, DataNasc) values('Akira', 'Ator', '2000/05/15'),('Gohan', 'Chefe', '2001/03/23');
       
Select * from tbUsuario;

update tbUsuario set NomeUsu = '{0}', Cargo = '{1}', DataNasc = str_to_date('{2}' ,'%d/%m/%Y %H:%i:%s')  where idUsu = '{3}';


 /*values('{0}','{1}',  STR_TO_DATE('{14-6-2009}','%d/%m/%Y'));*/

       
Select NomeUsu from tbUsuario where IdUsu=6;




describe tbUsuario;
