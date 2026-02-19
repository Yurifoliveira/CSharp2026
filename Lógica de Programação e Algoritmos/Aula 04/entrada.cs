// entrada de dados
System.Console.WriteLine("digite um nome");
string nome = Console.ReadLine();//entrada de dados
Console.WriteLine($" o valor digitado é de {nome}");
System.Console.WriteLine(" digite o primeiro numero");
double x = double.Parse (Console.ReadLine());//atribuiu o x como double e uniu o numero digitado a variavel x
System.Console.WriteLine("digite o segundo número");
double y = double.Parse (Console.ReadLine());//atribuiu o ycomo double e uniu o numero digitado a variavel y 


//-------------------------processamento de dados----------------

double soma = x + y ;// considerou a soma como possivel a numeros quebados e somou as variaveis x e y


//---------------------- saída de dados ------------------------

System.Console.WriteLine($"a soma dos dois valores é de {soma}");

