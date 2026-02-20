using static System.Console;
double  Base , altura , area , perimetro , diagonal;

WriteLine("digite o valor da base do retangulo");
Base =  double.Parse(ReadLine());
WriteLine ();
WriteLine("digite o valor da altura do retangulo");
altura = double.Parse(ReadLine());
WriteLine();
area = Base * altura ;
perimetro = (2 * Base) + (2 * altura);
diagonal = Math.Sqrt((Base * Base)+(altura * altura));

WriteLine($"a area do retangulo é de {area}");
WriteLine($" o perimetro do retangulo é de {perimetro}");
WriteLine($" a diagonal do retangulo é de {diagonal}");