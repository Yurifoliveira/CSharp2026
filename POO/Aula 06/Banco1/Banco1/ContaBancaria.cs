using static System.Console;
using System;
namespace Banco1
{
	internal class ContaBancaria
	{
		//campo

		private double saldo;
		private string titular;
		private int numero;

		//propriedades

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		public string Titular
		{
			get { return titular; }
			set { titular = value; }
		}


		public double Saldo
		{
			get { return saldo; }
			set
			{
				if (value > 0)
				{
					saldo = value;
				}
				else
				{
					saldo = 0;
					Write("Saldo negativo invalido");
				}
			}
		}
			
		//construtores ContaBancaria
		public ContaBancaria(int numero, string titular)
		{
			Numero = numero;
			Titular = titular;
			Saldo = 0;
		}

		// herança do construtor
		public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
		{

			Saldo = saldo;

		}
		//metodos
		public void Deposito(double quantia)
		{
			Saldo += quantia;
		}

		public void Saque(double quantia)
		{
			Saldo -= quantia;
		}
	    public void Dados()
		{
            Console.WriteLine($"dados da conta :\n "+ $"\tConta : {Numero}\n"+$"\tTitular : {Titular}\n"+$"Saldo : {Saldo:C}");
		}
    }
}

