--op READ - ler --
/*SELECT * FROM Contas;
GO
*/

SELECT Id , Titular , Numero_da_conta ,Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas
WHERE Titular LIKE '%Silva%';
GO