using System.Security.Cryptography.X509Certificates;

namespace terreno
{
    internal class Terreno
    {
        //campos
        public double Largura, Comprimento, Valor;

        //contrutor
public Terreno double Largura , double Comprimento , double Valor;
        {
            this . Largura = Largura; //this para diferenciar campo de parametro
            this . Comprimento = Comprimento;
            this . Valor = Valor;
        }

        //metodos

        public double area()
        {
            return Largura * Comprimento;
        }
        public double preco()
       
   
                {
                return area() * Valor;
            }
            public void Saida()
            {
                Console.WriteLine($"Area do terreno = {area()}");
                Console.WriteLine($"Preço do terreno = {preco()} : ");

            }






        }

    }

