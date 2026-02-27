using static System.Console;

//decl variaveis
int codigo , quantidade ;
//--entrada de dados--
Write ("digite o codigo do produto :");
codigo = int.Parse(ReadLine());
Write("digite a quantidade do produto");
quantidade = int.Parse(ReadLine());
switch (codigo)
{
    case 1 :
    WriteLine ($"o valor total é de : {quantidade * 5.00}");
    break;

    case 2 : 
    WriteLine ($"o valor total é de : {quantidade * 4.50}");
    break;

    case 3 :
     WriteLine ($"o valor total é de : {quantidade * 3.75}");
    break;

   case 4 :
   WriteLine ($"o valor total é de : {quantidade * 8.99}");
   break;

   case 5 :
   WriteLine ($"o valor total é de : {quantidade * 11.33}");
   break;

}