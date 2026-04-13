using ImpostoApp.Models;

namespace ImpostoApp.Services
{
    /// <summary>
    /// Responsável por ler os dados dos contribuintes e exibir o relatório final.
    /// Separa a lógica de I/O das regras de negócio (princípio da responsabilidade única).
    /// </summary>
    public static class ContribuinteService
    {
        public static List<Contribuinte> LerContribuintes(int quantidade)
        {
            var lista = new List<Contribuinte>();

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"\n─── Contribuinte {i} de {quantidade} ───");
                Console.Write("Tipo (F = Física / J = Jurídica): ");
                char tipo = Console.ReadLine()!.Trim().ToUpper().FirstOrDefault();

                try
                {
                    Contribuinte contribuinte = tipo == 'F'
                        ? LerPessoaFisica()
                        : LerPessoaJuridica();

                    lista.Add(contribuinte);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Erro] {ex.Message} — contribuinte ignorado.");
                    i--; // permite nova tentativa
                }
            }

            return lista;
        }

        private static PessoaFisica LerPessoaFisica()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;

            Console.Write("Renda anual (R$): ");
            decimal renda = decimal.Parse(Console.ReadLine()!);

            Console.Write("Gastos com saúde (R$): ");
            decimal saude = decimal.Parse(Console.ReadLine()!);

            return new PessoaFisica(nome, renda, saude);
        }

        private static PessoaJuridica LerPessoaJuridica()
        {
            Console.Write("Razão social: ");
            string nome = Console.ReadLine()!;

            Console.Write("Renda anual (R$): ");
            decimal renda = decimal.Parse(Console.ReadLine()!);

            Console.Write("Número de funcionários: ");
            int funcionarios = int.Parse(Console.ReadLine()!);

            return new PessoaJuridica(nome, renda, funcionarios);
        }

        public static void ExibirRelatorio(List<Contribuinte> contribuintes)
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║              RELATÓRIO DE IMPOSTOS                          ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════╣");

            decimal totalImposto = 0m;

            foreach (var c in contribuintes)
            {
                decimal imposto = c.CalcularImposto();
                totalImposto += imposto;

                string tipo = c is PessoaFisica ? "PF" : "PJ";
                Console.WriteLine($"║  [{tipo}] {c.Nome,-30} → Imposto: {imposto,12:C2} ║");

                // Detalhes extras por tipo (polimorfismo via is/pattern matching)
                if (c is PessoaFisica pf && pf.GastosComSaude > 0)
                    Console.WriteLine($"║       Abatimento saúde: {pf.GastosComSaude * 0.5m,10:C2}                         ║");

                if (c is PessoaJuridica pj)
                    Console.WriteLine($"║       Funcionários: {pj.NumeroFuncionarios,-5}  Alíquota: {(pj.NumeroFuncionarios > 10 ? "14%" : "16%"),-4}                  ║");
            }

            Console.WriteLine("╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine($"║  TOTAL DE IMPOSTO ARRECADADO:          {totalImposto,12:C2}          ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
        }
    }
}