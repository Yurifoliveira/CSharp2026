using static System.Console;

static void Total(int qtd , double valor)// (parametro )referencia da funçao nao é variavel
{
    WriteLine ($"o valor total é de R$ : {qtd * valor}"); 
}
//decl variaveis
int codigo , quantidade ;
//--entrada de dados--
try {
Write ("digite o codigo do produto :");
codigo = int.Parse(ReadLine());
Write("digite a quantidade do produto");
quantidade = int.Parse(ReadLine());
switch (codigo)
{
    case 1 :
    Total(quantidade , 5.00);
    break;

    case 2 : 
   Total(quantidade , 4.50);
    break;

    case 3 :
    Total(quantidade , 3.75);
    break;

    case 4 :
   Total(quantidade , 8.99);
   break;

   case 5 :
   Total(quantidade , 11.33);
   break;
   default :
   WriteLine("Código do produto nao cadastrado no sistema");
   break;
   }
}
catch(Exception ex )
{
    WriteLine($"Digite valores válidos , erro : {ex.Message}");
}