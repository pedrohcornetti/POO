using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public bool Situacao { get; set; }
        public static int Contador { get; set; }
        public Conta()//construtor padrão
        {
            Contador ++;
        }
        
        public Conta(int numero)
        {
            Numero = numero;
            Contador ++;
        }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
            Contador ++;
        }
        public Conta(int numero, double saldo, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Contador ++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero +
            "\tTitular: " + Titular + "\tSaldo: "+ Saldo);
            System.Console.WriteLine(Situacao);
        }
        static Conta()
        {
            Contador = 1571000;
        }
    }
}