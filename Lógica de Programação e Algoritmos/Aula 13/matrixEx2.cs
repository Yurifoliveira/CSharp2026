using static System.Console;

Write ("digite a ordem da matriz (maximo =10) : ");
int n = int.Parse(ReadLine());
int [,] matriz = new int [n,n];
for( int i = 0 ; i <n ; i++)
{
    for (int j = 0 ; j <n ; j++)
    {
        Write($"Digite o valor p/ a posição [{i},{j}] : ");
        matriz[i,j] = int.Parse(ReadLine()); 
    }
}

WriteLine ("matriz preenchida : ");
for (int i = 0 ; i< n ; i++)
{
    for (int j = 0 ; j< n ; j++)
    {
        Write(matriz [i ,j] + " \t ");
    }
   WriteLine();
}
// diagonal principal
Write ("diagonal principal : ");
int neGativo =0 ; 
for (int i = 0 ; i< n ; i++)
{
    for (int j = 0 ; j <n ; j++)
    {
        if (i==j)
        {
        Write (matriz[i,j] + " \t ");
        }
        if (matriz[i,j] < 0)
        {
            neGativo++;
        }
}
}
WriteLine($"Quantidade de números negativos é : {neGativo}");
