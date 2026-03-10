using static System.Console;
using static System.Linq.Enumerable;
List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("joão");
nomes.Add("clodoaldo");
nomes.Add("maria"); //permite nomes duplicados
System.Console.WriteLine("------------------------------");
nomes.Remove("Maria"); //remove o primeiro nome encontrado
foreach (var item in Range(0, nomes.Count))//metodo da classe para retornar o tamanho da lista igual Lenght do arranjo, contagem da lista
//var = tipo de variavel dinamica
{
    WriteLine (nomes[item]);
}
//nomes.Clear(); --- remove tudo
//nomes.Contains("respecrivo nome ou dado");