--op READ - ler --
SELECT * FROM Contas;
GO

--seleciona de todas as contas as quais o saldo esta maior que 100--
SELECT Id , Titular , Numero_da_conta ,Saldo FROM Contas
WHERE Saldo > 1000;
GO
--seleciona de contas qual possui silva--
SELECT * FROM Contas
WHERE Titular LIKE '%Silva%';
GO
--seleciona em contas com o numero 1002--
SELECT * FROM Contas
WHERE Numero_da_conta = 1002
GO

--ordenar po saldo do maior p/ menor --
SELECT * FROM Contas
ORDER BY Saldo DESC
GO

--ordenar po saldo do menor p/ maior --
SELECT * FROM Contas
ORDER BY Saldo ASC
GO


--faz a contagem do total de contas--
SELECT COUNT(*)AS TotalContas FROM Contas

--Soma todos os saldos das contas na tabela
SELECT SUM(Saldo) AS SaldoTotal FROM Contas

--Média de saldo nas contas
SELECT AVG (Saldo) AS MediaSaldos FROM Contas
GO