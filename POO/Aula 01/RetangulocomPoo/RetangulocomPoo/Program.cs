using RetangulocomPoo;
using static System.Console;
Retangulo x = new Retangulo();
Retangulo y = new Retangulo();
//entrad dados
WriteLine("digite as medidas retangulo 1 : ");

Write("digite a largura 1 :");
x.largura = double.Parse(ReadLine());

Write("digite a altura 1 : ");
x.altura= double.Parse(ReadLine());
x.Process();

WriteLine("digite as medidas do retangulo 2 :");

Write("digite a largura 2 :");
y.largura = double.Parse(ReadLine());

Write("digite a altura 2 : ");
y.altura = double.Parse(ReadLine());
y.Process();