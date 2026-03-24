namespace App02
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario_Bruto;
        public double Imposto;

        public Funcionario(string Nome, double Salario_Bruto, double Imposto)
        {
            this.Nome = Nome;
            this.Salario_Bruto = Salario_Bruto;
            this.Imposto = Imposto;
        }

        public double Salario_Liquido()
        {
            return Salario_Bruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double salarioLiquido = Salario_Liquido();
            double aumento = salarioLiquido * porcentagem / 100.0;
            double novoLiquido = salarioLiquido + aumento;

            Salario_Bruto = novoLiquido + Imposto;
        }
    }
}
