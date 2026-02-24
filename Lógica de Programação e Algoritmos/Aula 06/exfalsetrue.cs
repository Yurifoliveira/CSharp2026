using static System.Console;

int a, b, c;

Write ("Digite o valor de A: ");
a = int.Parse(ReadLine());

Write ("Digite o valor de B: ");
b = int.Parse(ReadLine());

Write ("Digite o valor de C: ");
c = int.Parse(ReadLine());

bool valor1 = a == c;
bool valor2 = b != a;
bool valor3 = b > c;
bool valor4 = a <= c;

WriteLine($"O primeiro valor é igual ao tercerio valor? {valor1}");
WriteLine($"O segundo valor é diferente do primeiro valor? {valor2}");
WriteLine($"O segundo valor é maior que o terceiro valor? {valor3}");
WriteLine($"O primeiro valor é menor ou igual o terceiro valor? {valor4}");

bool per1 = valor1 & valor3;

WriteLine($"o resultado da comparação é {per1}");

bool per2 = valor2 | valor4 ;

Write($"o resultado da comparação é :{per2}");

bool per3 =! valor1 ; 
Write($" a negação da primeira pergunata é {per3}");
