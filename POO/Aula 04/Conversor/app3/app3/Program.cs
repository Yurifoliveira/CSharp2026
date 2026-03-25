using System;
using static System.Console;
using app3;
WriteLine("qual é a cotação do dolar ? : ");
ConversorDeMoeda.cotacao = double.Parse(ReadLine());
WriteLine();
Write("Quantos dolares voce vai comprar? :");
ConversorDeMoeda.qtd = double.Parse(ReadLine());
Write($"Valor a ser pago em reais é de :{ConversorDeMoeda.CalcularValor():F2}");