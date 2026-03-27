using static System.Console;
using System;
namespace Banco
{
    internal class ContaBancaria
    {
        // campos ou atributos / necessita construtor para referenciar no program por ser private
        private int numero;
        private string titular;
        private double saldo;

        //sobrecarga
        public ContaBancaria(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0;
        }
        
        //construtor / foi utilizado o reaproveitamento do construtor no trecho this (numero,titular)
        public ContaBancaria (int numero, string titular, double saldo): this(numero , titular)
        {
            this.saldo = saldo;
        }
        //Metodos 
        public void Deposito (double quantia)
        {
            saldo += quantia; 
        }
        public void Saque(double quantia)
        {
            saldo -= quantia;
        }
        public void dados()
        {
        WriteLine("Dados da conta cadastrada : ");
        WriteLine($"\tTitular : {titular}\n" + $"\tNumero da conta : {numero}\n" + $"\tSaldo da conta : R$ {saldo}");

        }
    }
}
