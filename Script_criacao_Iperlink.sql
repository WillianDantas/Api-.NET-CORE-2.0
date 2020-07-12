CREATE DATABASE Iperlink

use Iperlink

CREATE TABLE Processo(
 Codigo bigint identity(1,1) primary key not null,
 NumeroDoProcesso varchar(100) not null,
 DataDeCriacaoDoProcesso datetime,
 Valor decimal(16,2),
 Escritorio varchar(100)
)


commit