using static System.Console;
//problema montanha russa
int  numPess,visiApt = 0;
double altuMax , altuMin ;

try
{
 Write("digite a quantidade de pessoas :");
   numPess=int.Parse(ReadLine());

    Write("digite a altura minima para entrar :");
    altuMin=double.Parse(ReadLine());

    Write("digite a altura maxima para entrar :");
    altuMax=double.Parse(ReadLine());

    for (int i = 0; i < numPess; i++)
    {
        Write($"digite a altura dos visitantes{i+1} : ");
        double altuPess = double.Parse(ReadLine());


        if (altuPess >= altuMin & altuPess <= altuMax)

        {
            visiApt++;
        }
}

WriteLine($"o numero de pessoas aptas a entrar na montanha russa é {visiApt}");
}
catch (Exception ex )
{
    WriteLine ("entrada inválida . Por favor , insira numeros válidos");
}

