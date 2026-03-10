using static System.Console;
int [] numeros = new int [5]; //new int esta instanciando o vetor na memoria heap
string [] nomes = {"joao" , "maria" , "pedro" , "ana" , "lucas"};
System.Console.WriteLine( nomes [2]);
numeros [0] = 10;
numeros [1] = 11;
numeros [2] = 0;
numeros [3] = 5;
numeros [4] = 7;
int tamanho = numeros.Length ; // tamanho do vetor
System.Console.WriteLine(" o tamanho do vetor é de :"+ tamanho);