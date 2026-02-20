using static System.Console;
int dias , anos, meses ;
WriteLine("digite sua idade em dias");
dias = int.Parse(ReadLine());
anos = dias / 365 ;
meses =(dias % 365)/30;
dias = (dias % 365) % 30; 
WriteLine($"voce possui {anos} anos, {meses} meses e {dias} dias");