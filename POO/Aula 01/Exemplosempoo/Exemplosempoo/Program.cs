//entrada de dados
using static System.Console;
Title = " calculadora de triangulos";
WriteLine("digite as medidas do triangulo x : ");
Write("Digite o valor de a :");
double ax = double.Parse(ReadLine());
Write("Digite o valor de b :");
double bx = double.Parse(ReadLine());
Write("Digite o valor de c :");
double cx = double.Parse(ReadLine());

WriteLine("digite as medidas do triangulo y : ");
Write("Digite o valor de a :");
double ay = double.Parse(ReadLine());
Write("Digite o valor de b :");
double by = double.Parse(ReadLine());
Write("Digite o valor de c :");
double cy = double.Parse(ReadLine());

//processamento de dados
double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(px * (px - ay) * (px - by) * (px - cy));

//saida de dados
Console.WriteLine($"a area do triangulo x é de {areax :F2}");
Console.WriteLine($"a area do triangulo y é de {areay :F2}");

if(areax > areay)
    {
    Console.WriteLine("Maior área é do triangulo x ");
}
else if (areay > areax)
{
    Console.WriteLine("Maior área é do triangulo y ");
}
else
{
    Console.WriteLine("Os triangulos de áreas iguais ");
}

ReadKey(); 