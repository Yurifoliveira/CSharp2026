using Retanguloex;
using static System.Console;
Retangulo x = new Retangulo();
//entrad dados
WriteLine("digite as medidas retangulo 1 : ");

Write("digite a largura  :");
x.largura = double.Parse(ReadLine());

Write("digite a altura  : ");
x.altura = double.Parse(ReadLine());
x.Process();