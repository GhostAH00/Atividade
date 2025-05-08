select * from atividade.registroacesso;

insert into registroacesso (id_usuario, TipoOperacao) 
values (1,'Entrada');

insert into registroAcesso (id_usuario, TipoOperacao, DataHora)
values (1, 'Saída', NOW());

insert into registroAcesso (id_usuario, TipoOperacao) 
values (2, 'Entrada');

insert into registroAcesso (id_usuario, TipoOperacao) 
values (2, 'Saída');

insert into registroAcesso (id_usuario, TipoOperacao) 
values (6, 'Entrada');

insert into registroAcesso (id_usuario, TipoOperacao) 
values (6, 'Saída');

select ra.id, u.nome, ra.DataHora, ra.TipoOperacao
from registroAcesso ra
join usuarios u on ra.id_usuario = u.id
order by ra.DataHora desc limit 10;


-- select * from atividade1.registroacesso;






