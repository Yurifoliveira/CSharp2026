namespace App02
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario_Bruto;
        public double Imposto;
      
        public Funcionario (string Nome, double Salario_bruto, double Imposto)
        {
            this.Nome = Nome;
            this.Salario_Bruto = Salario_Bruto;
            this.Imposto= Imposto;
        }
       //metodo da classe
       public double Salario_liquido()
        {
            return Salario_Bruto - Imposto;
        }
        public double
        }
       }
    

