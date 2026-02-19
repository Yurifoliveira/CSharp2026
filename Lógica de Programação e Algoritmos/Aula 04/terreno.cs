using static System.Console;
//declaração de variaveis
double largura , comprimento ,valor ,area , preco ;
//entrada de dados
WriteLine("digite a largura do terreno");
largura = double.Parse(ReadLine());
WriteLine();
Write ("digite o comprimento do terreno");
comprimento = double.Parse(ReadLine());
WriteLine();
Write("digite o valor do metro quadrado do terreno");
valor = double.Parse(ReadLine());
//===============processamentop de dados===========
area= largura * comprimento ; 
preco = area * valor;
//saida de dados
System.Console.WriteLine($"a area do terreno é de {area} e o preco do terreno é de {preco}");