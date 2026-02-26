using static System.Console;
double a , b , c , areaTra , p  , AreaTri;
WriteLine("digite o valor de a :");
a = double.Parse(ReadLine());
WriteLine("digite o valor de b :");
b = double.Parse(ReadLine());
WriteLine("digite o valor de c :");
c = double.Parse(ReadLine());

if(a < b + c & b < a + c & c < a + b) //condição para verificar se os valores formam um triangulo
{
 p = (a + b + c) / 2; //variavel interna da formula da area de heron
 AreaTri = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //formula da area de heron
 WriteLine($"o valor da area do triangulo é {AreaTri}");

}

else             // condição caso seja um trapezio
{
    WriteLine("os valores não formam um triangulo");

   areaTra = ((a+b)*c)/2;//area do trapezio
   WriteLine ($"a area do trapézio é de :{areaTra}");
}
