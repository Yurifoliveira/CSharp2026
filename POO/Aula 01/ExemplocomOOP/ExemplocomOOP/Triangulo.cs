namespace ExemplocomOOP
{
    internal class Triangulo
    {
        //campos ou atributos da classe
    
      public double ladoA;
      public double ladoB;
      public double ladoC; // public torna publico e permite a modificação de acesso

        //Método = função dentro de uma classe
        public double area()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            return area;
        }
    }
}
