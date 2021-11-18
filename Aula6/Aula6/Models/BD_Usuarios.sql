create table usuario(
	id		int primary key not null identity(1,1),
	nome	varchar(100),
	senha	varchar(100)
);

insert into usuario(nome, senha) VALUES('daniel', '123');

select * from usuario;

select id from usuario where nome = 'daniel' and senha = '123'; 