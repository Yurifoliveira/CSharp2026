using static System.Console;
//declaração de variaveis
const int SENHAFIXA = 2002;
int senha,contagem = 0;
//entrada de dados
Write ("digite a senha; ");
senha = int.Parse(ReadLine());
//processamento de dados
while (senha!= SENHAFIXA)
{
    if(contagem>=3)
    {
        WriteLine("acesso bloqueado");
        break;
    }
    contagem++;
    Write("senha incorreta , digite novamente");
    senha = int.Parse(ReadLine());
    //Beep(500,800); apito sonoro
}
if (contagem<3)
{
WriteLine ("acesso permitido!");
}
else
{
    WriteLine ("acesso negado");
}