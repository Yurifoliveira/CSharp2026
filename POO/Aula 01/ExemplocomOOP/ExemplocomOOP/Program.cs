using ExemplocomOOP;
using static System.Console;
//instanciação dos triangulos x e y
Triangulo x = new Triangulo(); //y é o objeto do tipo triangulo
Triangulo y = new Triangulo(); //x é o objeto do tipo triangulo
//entrada de dados

WriteLine("digite as medidas do triangulo X : ");
Write("digite a medida A:");
x.ladoA = double.Parse(ReadLine());
Write("digite a medida B:");
x.ladoB = double.Parse(ReadLine());
Write("digite a medida C:");
x.ladoC = double.Parse(ReadLine());

WriteLine("digite as medidas do triangulo Y : ");
Write("digite a medida A:");
y.ladoA = double.Parse(ReadLine());
Write("digite a medida B:");
y.ladoB = double.Parse(ReadLine());
Write("digite a medida C:");
y.ladoC = double.Parse(ReadLine());

//saida de dados
WriteLine($"a area do triangulo x é de : {x.area()}");
WriteLine($"a area do triangulo y é de : {y.area()}");

ReadKey();