CREATE DATABASE  IF NOT EXISTS `my-finance`
USE `my-finance`;

DROP TABLE IF EXISTS `planoconta`;
CREATE TABLE `planoconta` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(255) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
)

go

insert into planoconta(descricao, tipo) values('Combust�vel', 'D')
insert into planoconta(descricao, tipo) values('Sal�rio', 'R')
insert into planoconta(descricao, tipo) values('Alimenta��o', 'D')

insert into planoconta(descricao, tipo) values('Impostos', 'D')
insert into planoconta(descricao, tipo) values('�gua', 'D')
insert into planoconta(descricao, tipo) values('Luz', 'D')
insert into planoconta(descricao, tipo) values('Internet', 'D')
insert into planoconta(descricao, tipo) values('Cart�o de Cr�dito', 'D')
insert into planoconta(descricao, tipo) values('Gastos com a Lata Velha', 'D')

DROP TABLE IF EXISTS `transacao`;
CREATE TABLE `transacao` (
  `id` int NOT NULL AUTO_INCREMENT,
  `historico` varchar(255) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `PlanoConta_Id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `planoconta_transacao_FK_idx` (`PlanoConta_Id`),
  CONSTRAINT `Transacao_planoConta_FK` FOREIGN KEY (`PlanoConta_Id`) REFERENCES `planoconta` (`id`)
)

go

insert into transacao(data, valor, historico, planoconta_id)
values (GETDATE(), 25, 'Caf� de Amanh�', 4)

insert into transacao(data, valor, historico, planoconta_id)
values (GETDATE(), 38, 'Gasolina Moto', 1)

insert into transacao(data, valor, historico, planoconta_id)
values ('20230608 15:30', 435, 'Gasolina Carro', 1)

insert into transacao(data, valor, historico, planoconta_id)
values ('20230613', 1000, 'Sal�rio Empresa 1', 2)
    
insert into transacao(data, valor, historico, planoconta_id)
values ('20230610', 350, 'IPTU', 5)

insert into transacao(data, valor, historico, planoconta_id)
values ('20230608', 250, 'Copasa', 6)

insert into transacao(data, valor, historico, planoconta_id)
values ('20230608', 387, 'CEMIG', 7)

insert into transacao(data, valor, historico, planoconta_id)
values ('20230605', 450, 'Cilindro de Embreagem do Carro', 10)

insert into transacao(data, valor, historico, planoconta_id)
values ('20230605', 125, 'Internet Casa', 8)

insert into transacao(data, valor, historico, planoconta_id)
values ('20230612', 6000, 'Cart�o Santander', 9)