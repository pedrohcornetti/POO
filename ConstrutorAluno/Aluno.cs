using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        //declaração de atributos
        private long matricula;
        private string nome;
        private static int contador;

        //declaração de métodos
        public long Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { 
                if (value != "")
                    nome = value;
                else
                    Console.WriteLine("Digite um nome válido!");
            }
        }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media { get; private set; }
        
        public void CalcularMediaInterna()
        {
            Media = (P1 + P2) / 2;
        }
        public void CalcularMediaMain(double p1, double p2)
        {
            Media = (p1 + p2) / 2;
        }
        static Aluno()
        {
            contador = 1;
        }
        public Aluno()
        {
            Matricula = 1570482211000 + contador;
            contador ++;
        }
        public Aluno(string nome, double p1, double p2)
        {
            Nome = nome;
            P1 = p1;
            P2 = p2;
            this.CalcularMediaInterna();
            Matricula = 1570482211000 + contador;
            contador ++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Matrícula: " + Matricula +
            "\tNome: " + Nome + "\tP1: " + P1 + "\tP2: " + P2 +
            "\tMédia: " + Media);
        }

        //.*.*.*.* TRABALHO, VALE 1 PONTO *.*.*.*.
        //Data de entrega 31/03, pelo Teams, arquivo em .ZIP
        //Criar os atributos matrícula, nome, p1, p2, media
        //Criar os métodos/propriedade get e set, exceto o
        //atributo média
        //Criar o método para calcular a média do aluno

        //O atributo matrícula não terá o método set, pois
        //será gerado por um atributo static e armazenado
        //no atributo matricula 
        //Não use vetor
        //Crie o método MostrarAtributos, chame-o após cada
        //instância
        //Instancia no mínimo 4 objetos
    }
}