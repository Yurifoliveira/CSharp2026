//exercicio dee lista com a estrutura de repetição for
using static System.Console;

//decla variael
int n = 0;
List<double> numeros= new List<double>();
//entrad dados
Write (" quantos numeros voce vai digitar :");
n = int.Parse(ReadLine());
for (int i = 0 ; i < n ; i++)
{
    Write ("digite um número :");
    numeros.Add(double.Parse(ReadLine())); //add metodo para adicionar na lista
}

    Write("Valores = ");

for (int i = 0; i < n ; i++)
{
     Write($"{numeros[i]}");
}

Write($"\n Soma = {numeros.Sum()}");

 Write($"\n Média = {numeros.Average()}");