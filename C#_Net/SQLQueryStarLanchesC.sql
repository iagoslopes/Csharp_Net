create database slc#;

use slc#;

create table usuarios (
usuario varchar(30),
senha varchar(24),
email varchar(100),
nome varchar(200),
cpf varchar(14) Primary Key,
data_nasc varchar(11)
);

select * from usuarios;
