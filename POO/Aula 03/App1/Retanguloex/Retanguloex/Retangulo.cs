using static System.Console;
namespace Retanguloex;

internal class Retangulo
{
    public double altura;
    public double largura;





    public void Process()
    {
        double area = (altura * largura);
        double p = ((2 * altura) + (2 * largura));
        double diagonal = Math.Sqrt((largura * largura) + (altura * altura));
        WriteLine($"a area é  : {area} , o perimetro é de : {p} e a diagonal é de : {diagonal} ");


    }

}