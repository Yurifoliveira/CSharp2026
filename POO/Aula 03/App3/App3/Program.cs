using App3;
using System;
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
            aluno.Nota1 = double.Parse(ReadLine());
            aluno.Nota2 = double.Parse(ReadLine());
            aluno.Nota3 = double.Parse(ReadLine());

            double notaFinal = aluno.NotaFinal();
            WriteLine("Nota final do aluno: " + notaFinal.ToString("F0"));

            if (aluno.AprovadoOuReprovado())
            {
                WriteLine("Aprovado");
            }
            else
            {
                WriteLine("Reprovado");
                WriteLine("Reprovado, faltou "
                    + aluno.Ponto().ToString("F0")
                    + " pontos");
            }

            WriteLine("\n" + new string('-', 30));
        }

        WriteLine("Fim do processamento (3 alunos).");
    }
}

