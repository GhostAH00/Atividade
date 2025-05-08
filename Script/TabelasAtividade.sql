create database atividade1;

use atividade1;

-- drop table usuarios;

create table usuarios(
id int auto_increment,
nome varchar(60) not null,
cpf varchar(11) unique not null,
tipoUsuario enum ('Administrador', 'Funcionário', 'Visitante'),
senha varchar(32) not null,
foto blob not null,
primary key(id)
);

-- drop table registroAcesso;

create table registroAcesso(
id int auto_increment,
TipoOperacao enum ('Entrada', 'Saída'),
DataHora datetime default current_timestamp,
id_usuario int not null,
primary key(id),
foreign key (id_usuario) references usuarios(id)
);



