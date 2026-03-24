namespace App3
{
    internal class Aluno
 
    {
        public string NomeDoAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool AprovadoOuReprovado()
        {
            return NotaFinal() >= 60.0;
        }

        public double Ponto()
        {
            if (AprovadoOuReprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }