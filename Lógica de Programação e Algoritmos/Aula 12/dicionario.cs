using static System.Console;

//-----declar de um dicionario
Dictionary <string, int > pessoas = new Dictionary<string, int>()
{
    {"Joao",20},
    {"Maria",30}, //diconario nao permite chaves duplicadas
    {"Pedro",40}
};
//-----adicionar dados ao dicionario
pessoas.Add("Clodoaldo", 54);

WriteLine($"Tamanho = {pessoas.Count()}");
WriteLine(pessoas["Clodoaldo"]);
WriteLine($"Tamanho = {pessoas.Count()}");
WriteLine(pessoas["Clodoaldo"]);
pessoas.Remove("Clodoaldo");
WriteLine($"Tamanho = {pessoas.Count()}");
