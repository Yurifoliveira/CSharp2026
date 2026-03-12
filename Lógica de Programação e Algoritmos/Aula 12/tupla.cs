using static System.Console;
//tupla
var clodoaldo = (34 , 5000.34 , "Heitor", "SENAI",'B');//coleção ordenada por item , pode ser de tipos diferentes
System.Console.WriteLine($"idade do clodoaldo : {clodoaldo.Item1}");
System.Console.WriteLine($"salário do clodoaldo : {clodoaldo.Item2}");
System.Console.WriteLine($"nome do parente: {clodoaldo.Item3}");
clodoaldo.Item1 = 54; //mutavel  EM INFORMAÇÃO POREM TAMANHO FIXO
System.Console.WriteLine($"idade do clodoaldo : {clodoaldo.Item1}");