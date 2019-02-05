use itla_mysql;
create table estudiante
(
Matricula varchar(20),
Nombre varchar(50),
Apellido varchar(50),
Empresa varchar(50),
Edad varchar(2),
Salario varchar(20)
);
insert into estudiante values ('1651013462599', 'Camila', 'Horn', 'Donec Dignissim Magna Limited', '25', '6629.00');
insert into estudiante values ('1698127772699', 'Declan', 'Nieves', 'Pellentesque Tincidunt Industries', '33', '5679.00');
insert into estudiante values ('1697121894799', 'Neville', 'Bernad', 'elemetum dui corp', '35', '6782.00');
insert into estudiante values ('1693102604099', 'kaitlin', 'ryan', 'quisque LLP', '22', '7908.00');
insert into estudiante values ('1655101549399', 'ivana', 'fry', 'gravida limited', '41', '8158.00');
insert into estudiante values ('1666120966699', 'shaaleig', 'sims', 'Nec tempus consulting', '50', '5690.00');
insert into estudiante values ('1649062981899', 'michael', 'pennigton', 'sit amet led', '46', '8244.00');
insert into estudiante values ('1653013093799', 'Mara', 'Harvey', 'Cum LLC', '53', '7954');
insert into estudiante values ('1675051566999', 'Tashya', 'Calson', 'Vel Corporation', '38', '6239');
insert into estudiante values ('1660052778899', 'Alec', 'Jenkiss', 'Porttitor tellus llP', '51', '5328');
insert into estudiante values ('1674052546099', '', '', '', '', '');
select * from estudiante;
drop table estudiante;

