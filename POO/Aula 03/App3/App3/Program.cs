using App3;
using System;
using System.Globalization;
using static System.Console; // Permite usar WriteLine e ReadLine diretamente

class Program
{
    static void Main(string[] args)
    {

        for (int i = 1; i <= 3; i++)
        {
            Aluno aluno = new Aluno();

            Write("Nome do aluno: ");
            aluno.NomeDoAluno = ReadLine();

            WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal();
            WriteLine("Nota final do aluno: " + notaFinal.ToString("F0", CultureInfo.InvariantCulture));

            if (aluno.AprovadoOuReprovado())
            {
                WriteLine("Aprovado");
            }
            else
            {
                WriteLine("Reprovado");
                WriteLine("Reprovado, faltou "
                    + aluno.Ponto().ToString("F0", CultureInfo.InvariantCulture)
                    + " pontos");
            }

            WriteLine("\n" + new string('-', 30));
        }

        WriteLine("Fim do processamento (3 alunos).");
    }
}

