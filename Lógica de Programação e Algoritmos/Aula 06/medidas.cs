using static System.Console;
try{
//====== declaração de variavel==
double a , b , c , areaQuadrado ,areaTriangulo , areaTrapezio ;
//------entrada de dados-----
Write("digite a medida de A :");
a = double.Parse(ReadLine());
Write("digite a medida de B :");
b = double.Parse(ReadLine());
Write("digite a medida C : ");
c = double.Parse(ReadLine());
//---------processamento de dados---
areaQuadrado = a * a ;
areaTriangulo = (a * b) / 2;
areaTrapezio = ((a + b) * c) / 2;
WriteLine ($"a area do triangulo é {areaTriangulo:F4}");
WriteLine ($"a area do quadrado é {areaQuadrado:F4}");
WriteLine ($"a area do trapezio é{areaTrapezio:F4}");
}
catch (Exception)
{
   WriteLine(" Valores invalidos inseridos ,  programa encerrado");
}